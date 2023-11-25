using MateUtil.Models;
using Spectre.Console.Cli;

namespace MateUtil
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            var app = new CommandApp();

            app.Configure(config =>
            {
                config.AddBranch<Touchpad>("touchpad", touchpad =>
                {
                    touchpad.AddCommand<TouchpadCheck>("check");
                    touchpad.AddCommand<TouchpadEnable>("enable");
                    touchpad.AddCommand<TouchpadDisable>("disable");
                });
            });

            return app.Run(args);
        }
    }
}