using RigorMortis.Interface;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace RigorMortis.Properties.Classes
{

    public class WhoIs : CommandsInterface
    {
        private int WHOIS_PORT = 43;
        //I DUNNO HOW TO USE THIS SHIT BUT I GUESS IT STILL WORKS TEHEE private string WHOIS_SERVER = "whois.iana.org"; 
        private string WHOIS_SERVER = "whois.arin.net";
        private string WHOIS_EDU = "whois.educase.edu";
        private string WHOIS_DEFAULT = "whois.internic.net";

      

        public async void Execute(RichTextBox commandBox, string[] args)
        {
            if (args.Length == 0)
            {
                commandBox.AppendText("Usage: whois <username or IP>\n");
                return;
            }

            string input = args[0];
            string query = input;

            string whoIsHost;
            string queryString;


            if (IsValidIpAddress(input))
            {   
                // IP address case
               
                whoIsHost = this.WHOIS_SERVER;
                queryString = "n " + input;

            }else if (query.EndsWith(".edu"))
            {
                // .EDU domain case

                whoIsHost = this.WHOIS_EDU;
                queryString = "domain=" + input;
            }
            else
            {
                // DEFAULT SHIT

                whoIsHost = this.WHOIS_DEFAULT;
                queryString = "domain=" + input;
            }

            string response = await WhoIsLookUp(whoIsHost, WHOIS_PORT, queryString);

            commandBox.Font = new Font("Consolas", 14);
            commandBox.SelectionColor = Color.DarkGreen;
            commandBox.SelectionIndent = (commandBox.Width / 6);
            commandBox.AppendText(response + Environment.NewLine);
            commandBox.SelectionColor = commandBox.ForeColor;


        }

        private bool IsValidIpAddress(string input)
        {
            System.Net.IPAddress ipAddr;
            return System.Net.IPAddress.TryParse(input, out ipAddr);
        }

        private static async Task<string> WhoIsLookUp(string ip_domain, int port, string query)
        {
            try
            {
                using (var tcpClient = new TcpClient(ip_domain, port))
                using (var stream = tcpClient.GetStream())
                using (var writer = new StreamWriter(stream))
                using (var reader = new StreamReader(stream))
                {

                    writer.WriteLine(query);
                    writer.Flush();

                    string response = await reader.ReadToEndAsync();
                    return response;
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }


    }

}