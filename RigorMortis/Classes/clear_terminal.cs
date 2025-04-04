using RigorMortis.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RigorMortis.Properties.Classes
{
    public class ClearTerminal : CommandsInterface
    {
        public void Execute(RichTextBox commandBox)
        {
            commandBox.Clear();
        }
    }
}
