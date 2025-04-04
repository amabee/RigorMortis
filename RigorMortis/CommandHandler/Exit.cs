using RigorMortis.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RigorMortis.Properties.Classes
{
    public class Exit : CommandsInterface
    {
        public void Execute(RichTextBox commandBox)
        {
            commandBox.AppendText("Exiting RigorMortis..." + Environment.NewLine);
            System.Windows.Forms.Application.Exit();
        }
    }
}
