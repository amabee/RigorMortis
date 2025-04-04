using RigorMortis.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RigorMortis.Properties.Classes
{
    public class HelpCommands : CommandsInterface
    {
        public void Execute(RichTextBox commandBox, string[] args)
        {
            commandBox.AppendText("Available commands:" + Environment.NewLine);
            commandBox.AppendText("clear || cls - Clears the terminal." + Environment.NewLine);
            commandBox.AppendText("help - Displays this help message." + Environment.NewLine);
            commandBox.AppendText("exit || quit - Exits the application." + Environment.NewLine);
            commandBox.AppendText("about - Displays information about the application." + Environment.NewLine);
            commandBox.AppendText("credits - Displays credits for the application." + Environment.NewLine);
            commandBox.AppendText("license - Displays the license information." + Environment.NewLine);
            commandBox.AppendText("version - Displays the version of the application." + Environment.NewLine);
        }
    }
}
