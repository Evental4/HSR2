using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Spravochik_HSR
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            Text = "Регистрация";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassTB.Text == PassPodTB.Text)
            {
                File.AppendAllText("users.txt", NemeTB.Text + ", " + FamTB.Text + ", " + LogTB.Text + ", " + PassTB.Text + 
                    " " + Environment.NewLine);

                MessageBox.Show("Регистрация прошла успешна");
                Close();

            }
            else MessageBox.Show("Не совпадаую пороли");

        }


    }
}
