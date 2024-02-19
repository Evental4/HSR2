using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochik_HSR
{
    public struct Pers
    {
        public string name;
        public string role;
        public string tip;
        public string pyte;
        public string Hp;
        public string Def;
        public string Atc;
        public string Spid;
        public Button btn;
        public PictureBox pic;
        public PictureBox path;
        public PictureBox element;

        public Pers(string _name, string _role, string _tip, string _pyte, string _Hp, string _Def, string _Atc, string _Spid)
        {
            name = _name;
            role = _role;
            tip = _tip;
            pyte = _pyte;
            Hp = _Hp;
            Def = _Def;
            Atc = _Atc;
            Spid = _Spid;
            btn = new Button();
            pic = new PictureBox();
            path = new PictureBox();
            element = new PictureBox();

            btn.Font = new Font("Microsoft Sans Serif", 12F);
            btn.Text = name;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load("../../Pictures/" + name + ".png");
        }
    }

    public partial class MainForm : Form
    {
        public static string Login = "";

        List<Pers> Pers_list = new List<Pers>();

        public MainForm()
        {
            InitializeComponent();

            string[] strs = System.IO.File.ReadAllLines("Pers.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "},StringSplitOptions.None);
                Pers_list.Add(new Pers(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]));
            }

            


            Text = "Справочник по HSR";
            Hellolabel.Visible = false;
          
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Pers_list.Count; ++i)
            { 
                if(((Button)sender).Text == Pers_list[i].btn.Text)
                {
                    InfoForm info = new InfoForm(Pers_list[i]);
                    info.ShowDialog();

                }
            }   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            int x = 10;
            int y = 90;
            for (int i = 0; i < Pers_list.Count; i++)
            {
                Pers_list[i].btn.Location = new Point(x, y + 190);
                Pers_list[i].btn.Size = new Size(150, 40);
                Pers_list[i].btn.UseVisualStyleBackColor = true;
                Pers_list[i].btn.Click += new EventHandler(button1_Click);
                ViewPanel.Controls.Add(Pers_list[i].btn);

                Pers_list[i].pic.Location = new Point(x, y);
                Pers_list[i].pic.Size = new Size(185, 185);
                Pers_list[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                ViewPanel.Controls.Add(Pers_list[i].pic);

                x += 205;
                if (x > this.Size.Width - 185)
                {
                    y += 250;
                    x = 10;

                }


            }
        }

        private void ViewPanel_Resize(object sender, EventArgs e)
        {
            FindButton_Click(null, null);
        }

        private void Auth_button_Click(object sender, EventArgs e)
        {
            if (Login == "")
            {
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();
            }
            else
            {
                Login = "";
            }

            if (Login == "")
            {
                Auth_button.Text = "Войти";
                Hellolabel.Visible = false;
                RegButton.Visible = true;
            }
            else 
            {
                Auth_button.Text = "Выйти";
                Hellolabel.Visible = true;
                Hellolabel.Text = "Вы аторизовались как" + MainForm.Login;
            }


        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 90;

            for (int i =0; i < Pers_list.Count; i++)
            {
                Pers_list[i].btn.Visible = true;
                Pers_list[i].pic.Visible = true;


                if (rolecomboBox.Text != "" && rolecomboBox.Text != Pers_list[i].role)
                {
                    Pers_list[i].btn.Visible = false;
                    Pers_list[i].pic.Visible = false;
                }
                if (pytecomboBox.Text != "" && pytecomboBox.Text != Pers_list[i].pyte)
                {
                    Pers_list[i].btn.Visible = false;
                    Pers_list[i].pic.Visible = false;
                }
                if (tipcomboBox.Text != "" && tipcomboBox.Text != Pers_list[i].tip)
                {
                    Pers_list[i].btn.Visible = false;
                    Pers_list[i].pic.Visible = false;
                }

                if (Pers_list[i].btn.Visible)
                {
                    Pers_list[i].btn.Location = new Point(x, y + 190);
                    Pers_list[i].pic.Location = new Point(x, y);

                    x += 205;
                    if (x > this.Size.Width - 185)
                    {
                        y += 250;
                        x = 10;
                    }
                }
            }

           



    }

        
    }
 
}
