using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatePapoAES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendtoServer("João - " + SpeakAText.Text);
            SpeakAText.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendtoServer("Maria - " + SpeakBText.Text);
            SpeakBText.Clear();
        }



        #region Server
        public void sendtoServer(string Message)
        {
            string encryptedMessage = Criptografia.Encrypt(Message);
            ServerLog.AppendText(encryptedMessage + "\n");
            txtConversa.AppendText(Criptografia.Decrypt(encryptedMessage) + "\n");
        }
        #endregion
    }
}
