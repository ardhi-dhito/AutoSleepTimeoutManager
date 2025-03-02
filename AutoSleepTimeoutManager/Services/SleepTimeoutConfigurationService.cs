using AutoSleepTimeoutManager.Utils;

namespace AutoSleepTimeoutManager.Services
{
    public class SleepTimeoutConfigurationService
    {
        private const string PowerSchemeCmd = "powercfg /query SCHEME_CURRENT";
        private const string ACTimeoutCmd = "powercfg /change standby-timeout-ac";
        private const string DCTimeoutCmd = "powercfg /change standby-timeout-dc";

        public static void SetSleepTimeout(int timeout)
        {
            CommandExecutor.ExecuteCommand($"{ACTimeoutCmd} {timeout}");
            CommandExecutor.ExecuteCommand($"{DCTimeoutCmd} {timeout}");
        }

        public static string GetCurrentPowerScheme()
        {
            return CommandExecutor.ExecuteCommand(PowerSchemeCmd);
        }
    }
}
