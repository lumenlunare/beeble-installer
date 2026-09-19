launcher
    
    using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

class Program
{
    static int Main(string[] args)
    {
        Console.Title = "opsec blox 999";
        Console.CursorVisible = false;

        if (args.Length == 0)
        {
            Fail("could not find valid uri reg");
            return 1;
        }

        string uri = args[0];

        if (!uri.StartsWith("r08://", StringComparison.OrdinalIgnoreCase))
        {
            Fail("incorrect protocol params");
            return 1;
        }

        if (!TryParseLaunch(uri, out string scriptUrl, out bool reused))
        {
            Fail("invalid script params");
            return 1;
        }

        if (!Uri.TryCreate(scriptUrl, UriKind.Absolute, out Uri parsed)
            || (parsed.Scheme != Uri.UriSchemeHttp
                && parsed.Scheme != Uri.UriSchemeHttps))
        {
            Fail("could not fetch join script");
            return 1;
        }

        Animate("requesting server", ConsoleColor.Red, 6);

        Animate(
            reused ? "gameserver found! joining" : "gameserver started! joining",
            ConsoleColor.Yellow,
            4
        );

        try
        {
            bool launched = StartGameCom(scriptUrl);

            if (!launched)
                StartGameProcess(scriptUrl);
        }
        catch (Exception ex)
        {
            Fail(ex.Message);
            return 1;
        }

        Thread.Sleep(800);
        return 0;
    }

    static string InstallDir()
    {
        return AppContext.BaseDirectory.TrimEnd('\\', '/');
    }

    static bool StartGameCom(string scriptUrl)
    {
        Type launcherType = null;

        string[] progIds =
        {
            "RobloxLauncher.Launcher",
            "RobloxLauncher.Launcher.2",
            "Roblox.App"
        };

        foreach (string progId in progIds)
        {
            try
            {
                launcherType = Type.GetTypeFromProgID(progId, false);

                if (launcherType != null)
                    break;
            }
            catch
            {
            }
        }

        if (launcherType == null)
            return false;

        object launcher = null;

        try
        {
            launcher = Activator.CreateInstance(launcherType);
        }
        catch
        {
            return false;
        }

        string escapedScriptUrl = scriptUrl
            .Replace("\\", "\\\\")
            .Replace("'", "\\'");

        string luaScript =
            "loadfile('" + escapedScriptUrl + "')()";

        string[] methodNames =
        {
            "StartGame",
            "OpenGame",
            "Launch",
            "ExecScript"
        };

        foreach (string methodName in methodNames)
        {
            try
            {
                object[] parameters;

                if (methodName.Equals("ExecScript", StringComparison.OrdinalIgnoreCase))
                    parameters = new object[] { luaScript };
                else
                    parameters = new object[] { scriptUrl };

                launcherType.InvokeMember(
                    methodName,
                    BindingFlags.InvokeMethod,
                    null,
                    launcher,
                    parameters
                );

                return true;
            }
            catch
            {
            }
        }

        return false;
    }

    static void StartGameProcess(string scriptUrl)
    {
        string dir = InstallDir();
        string robloxPath = Path.Combine(dir, "Roblox.exe");

        string lua =
            "loadfile('" +
            scriptUrl
                .Replace("\\", "\\\\")
                .Replace("'", "\\'") +
            "')()";

        Process.Start(new ProcessStartInfo
        {
            FileName = robloxPath,
            Arguments = "-script \"" + lua + "\"",
            WorkingDirectory = dir,
            UseShellExecute = false
        });
    }

    static bool TryParseLaunch(
        string uri,
        out string scriptUrl,
        out bool reused
    )
    {
        scriptUrl = null;
        reused = false;

        int scriptIndex = uri.IndexOf(
            "script=",
            StringComparison.OrdinalIgnoreCase
        );

        if (scriptIndex < 0)
            return false;

        string rest = uri.Substring(
            scriptIndex + "script=".Length
        );

        int reusedIndex = rest.IndexOf(
            "&reused=",
            StringComparison.OrdinalIgnoreCase
        );

        string rawScriptUrl;

        if (reusedIndex >= 0)
        {
            rawScriptUrl = rest.Substring(0, reusedIndex);

            string reusedValue = rest.Substring(
                reusedIndex + "&reused=".Length
            );

            reused = reusedValue.StartsWith(
                "1",
                StringComparison.OrdinalIgnoreCase
            );
        }
        else
        {
            rawScriptUrl = rest;
        }

        try
        {
            scriptUrl = Uri.UnescapeDataString(rawScriptUrl);
        }
        catch
        {
            return false;
        }

        return !string.IsNullOrWhiteSpace(scriptUrl);
    }

    static void Animate(
        string text,
        ConsoleColor color,
        int ticks
    )
    {
        Console.ForegroundColor = color;

        for (int n = 0; n < ticks; n++)
        {
            Console.Write(
                "\r" +
                text +
                new string('.', (n % 3) + 1) +
                "   "
            );

            Thread.Sleep(280);
        }

        Console.WriteLine();
        Console.ResetColor();
    }

    static void Fail(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();

        Thread.Sleep(2000);
    }
}
