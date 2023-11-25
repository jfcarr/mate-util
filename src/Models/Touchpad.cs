using System.ComponentModel;
using Spectre.Console.Cli;

namespace MateUtil.Models
{
    public class Touchpad : CommandSettings { }

    public class TouchpadSettings : Touchpad
    {
        public string schema = "org.mate.peripherals-touchpad";
        public string key = "touchpad-enabled";
    }

    [Description("Display the current touchpad setting.")]
    public class TouchpadCheck : Command<TouchpadSettings>
    {
        public override int Execute(CommandContext context, TouchpadSettings settings)
        {
            var result = ProcessHandler.RunCommand("gsettings", $"get {settings.schema} {settings.key}");
            Console.WriteLine($"Current setting: {result.Item2.Trim()}");

            return result.Item1;
        }
    }

    [Description("Enable the touchpad.")]
    public class TouchpadEnable : Command<TouchpadSettings>
    {
        public override int Execute(CommandContext context, TouchpadSettings settings)
        {
            var result = ProcessHandler.RunCommand("gsettings", $"set {settings.schema} {settings.key} true");

            Console.WriteLine((result.Item1 == 0) ? "Touchpad enabled" : $"[ERROR] {result.Item2}");

            return result.Item1;
        }
    }

    [Description("Disable the touchpad.")]
    public class TouchpadDisable : Command<TouchpadSettings>
    {
        public override int Execute(CommandContext context, TouchpadSettings settings)
        {
            var result = ProcessHandler.RunCommand("gsettings", $"set {settings.schema} {settings.key} false");

            Console.WriteLine((result.Item1 == 0) ? "Touchpad disabled" : $"[ERROR] {result.Item2}");

            return result.Item1;
        }
    }
}