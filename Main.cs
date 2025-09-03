using System.Windows.Forms;
using Kbg.NppPluginNET.PluginInfrastructure;

namespace Kbg.NppPluginNET
{
    class Main
    {
        internal const string PluginName = "xkPasswd";

        public static void OnNotification(ScNotification notification)
        {
        }

        internal static void CommandMenuInit()
        {
            PluginBase.SetCommand(0, "Generate", ShowGenerator, new ShortcutKey(false, false, false, Keys.None));
        }

        internal static void SetToolBarIcon()
        {
        }

        internal static void PluginCleanUp()
        {
        }


        internal static void ShowGenerator()
        {
            Form frmPrompt = new frmGeneratePassword()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };
            frmPrompt.ShowDialog();
        }
    }
}