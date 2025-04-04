using RigorMortis.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RigorMortis.Properties.Classes
{
    public class About : CommandsInterface
    {
        public void Execute(RichTextBox commandBox, string[] args)
        {
            string aboutText = @"
┌─────────────────────────────────────────────┐
│                RigorMortis                  │
├─────────────────────────────────────────────┤
│  Coded in the shadows with C# + WinForms    │
│  Unauthorized access is... encouraged :)    │
│                                             │
│  Features:                                  │
│  - Custom command parsing                   │
│  - ASCII injection ready (cumming soon)     │
│  - History & FS emulation (cumming soon)    │
│                                             │
│  Version : 1.0.0                            │
│  Creator : @amabee                          │
│  Repo    : github.com/amabee/rigormortis    │
└─────────────────────────────────────────────┘

Type 'help' to begin infiltration...
";

            commandBox.Font = new Font("Consolas", 14);
            commandBox.WordWrap = false;
            commandBox.SelectionIndent = (commandBox.Width / 6);
            commandBox.SelectionColor = Color.LimeGreen;
            commandBox.AppendText(aboutText + Environment.NewLine);
            commandBox.SelectionColor = commandBox.ForeColor;
        }
    }
}
