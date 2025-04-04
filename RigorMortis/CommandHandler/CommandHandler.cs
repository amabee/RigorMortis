using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RigorMortis.Interface;
using RigorMortis.Properties.Classes;

namespace RigorMortis
{
    public class CommandHandler
    {
        private RichTextBox commandBox;
        private TextBox commandTextBox;


        private Dictionary<string, CommandsInterface> commandDictionary;

        public CommandHandler(RichTextBox commandBox, TextBox commandTextBox)
        {
            this.commandBox = commandBox;
            this.commandTextBox = commandTextBox;

            commandDictionary = new Dictionary<string, CommandsInterface>
            {
                { "clear", new ClearTerminal() },
                { "cls", new ClearTerminal() },
                { "help", new HelpCommands() },
                { "exit", new Exit() },
                { "quit", new Exit() },
                { "about", new About() },
                { "credits", new ClearTerminal() },
                { "license", new ClearTerminal() },
                { "version", new ClearTerminal() }
            };
        }

        private void AppendText(RichTextBox box, string text, System.Drawing.Color color)
        {
            commandBox.SelectionStart = commandBox.TextLength;
            commandBox.SelectionLength = 0;

            commandBox.AppendText(text + Environment.NewLine);
        }

        public void SendCommand(Object sender, KeyEventArgs keyEvent)
        {
            if (keyEvent.KeyCode == Keys.Enter)
            {
                keyEvent.SuppressKeyPress = true;

                string command = commandTextBox.Text.Trim();

                if (string.IsNullOrEmpty(command))
                {
                    return;
                }

                AppendText(this.commandBox, $"RigorMortis> {command}" + Environment.NewLine, System.Drawing.Color.White);

                if (commandDictionary.ContainsKey(command.ToLower())) {
                    
                    commandDictionary[command.ToLower()].Execute(commandBox);
                }
                else
                {
                    AppendText(this.commandBox, $"'{command}' is not recognized as a command." + Environment.NewLine, System.Drawing.Color.Red);  
                }

                commandTextBox.Clear();
            }
        }
    }
}
