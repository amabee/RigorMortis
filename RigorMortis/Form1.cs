using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RigorMortis
{
    public partial class Form1 : Form
    {

        private CommandHandler _commandHandler;

        public Form1()
        {
            InitializeComponent();

            _commandHandler = new CommandHandler(commandBox, commandTextBox);

            commandTextBox.KeyDown += _commandHandler.SendCommand;
        }

      
    }
}
