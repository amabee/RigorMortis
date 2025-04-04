using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                { "whois", new WhoIs()},
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

                string command = commandTextBox.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(command))
                {
                    return;
                }

                string[] parts = Regex.Matches(command, @"[\""].+?[\""]|[^ ]+")
                               .Cast<Match>()
                               .Select(m => m.Value.Replace("\"", ""))
                               .ToArray();

                string commandName = parts[0];
                string[] args = parts.Skip(1).ToArray();

                AppendText(this.commandBox, $"RigorMortis> {command}" + Environment.NewLine, System.Drawing.Color.White);

                if (commandDictionary.TryGetValue(commandName, out CommandsInterface commandObj))
                {
                    commandObj.Execute(commandBox, args);
                }
                else
                {
                    commandBox.AppendText($"'{commandName}' is not recognized as a command.\n");
                }

                commandTextBox.Clear();
            }
        }

    }
}
