using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.UnturnedManager.V1
{
    public partial class FORM_SETTINGS : Form
    {
        FORM_INICIO FormInicio_Objects = (FORM_INICIO)Application.OpenForms["FORM_INICIO"];

        public static string OldIP;
        public static string OldPort;
        public static string OldDB;
        public static string OldUser;
        public static string OldPass;

        public static string IP;
        public static string Port;
        public static string DB;
        public static string User;
        public static string Pass;

        public FORM_SETTINGS()
        {
            InitializeComponent();

            IP = Properties.Settings.Default.ip;
            Port = Properties.Settings.Default.port;
            DB = Properties.Settings.Default.db;
            User = Properties.Settings.Default.user;
            Pass = Properties.Settings.Default.pass;

            OldIP = Properties.Settings.Default.ip;
            OldPort = Properties.Settings.Default.port;
            OldDB = Properties.Settings.Default.db;
            OldUser = Properties.Settings.Default.user;
            OldPass = Properties.Settings.Default.pass;

            TEXTBOX_IP.Text = IP;
            TEXTBOX_PORT.Text = Port;
            TEXTBOX_DB.Text = DB;
            TEXTBOX_USER.Text = User;
            TEXTBOX_PASS.Text = Pass;
        }

        private void BUTTON_SAVE_Click(object sender, EventArgs e)
        {
            IP = TEXTBOX_IP.Text;
            Port = TEXTBOX_PORT.Text;
            DB = TEXTBOX_DB.Text;
            User = TEXTBOX_USER.Text;
            Pass = TEXTBOX_PASS.Text;

            Properties.Settings.Default.ip = IP;
            Properties.Settings.Default.port = Port;
            Properties.Settings.Default.db = DB;
            Properties.Settings.Default.user = User;
            Properties.Settings.Default.pass = Pass;
            Properties.Settings.Default.Save();

            this.Close();            
        }

        private void FORM_SETTINGS_FormClosed(object sender, FormClosedEventArgs e)
        {
            IP = TEXTBOX_IP.Text;
            Port = TEXTBOX_PORT.Text;
            DB = TEXTBOX_DB.Text;
            User = TEXTBOX_USER.Text;
            Pass = TEXTBOX_PASS.Text;

            if (IP != OldIP || Port != OldPort || DB != OldDB || User != OldUser || Pass != OldPass)
            {
                Properties.Settings.Default.ip = IP;
                Properties.Settings.Default.port = Port;
                Properties.Settings.Default.db = DB;
                Properties.Settings.Default.user = User;
                Properties.Settings.Default.pass = Pass;
                Properties.Settings.Default.Save();

                Task.WaitAll();
                Application.Restart();
            }

            else
                this.Close();
        }
    }
}
