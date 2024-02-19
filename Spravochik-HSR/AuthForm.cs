using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochik_HSR
{
    public partial class AuthForm : Form
    {
       
      
        public AuthForm()
        {
            InitializeComponent();

            Text = "Авторизация";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("users.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);

                if (LoginTextBox.Text == parts[2] && PassTextBox.Text == parts[3])
                {                    
                    MainForm.Login =parts[2];
                    Close();
                    return;
                }
            }
            MessageBox.Show("Неправильный логин/пороль");


        }

        
    }
}
