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
            Pers[] Pers_list = new Pers[9];
        public MainForm()
        {
            InitializeComponent();

            Pers_list[0] = new Pers("Келус", "DD or SapDD","Физический" ,"Разрушение", "Hp 1203","Def 460","Atc 620","Spid 100");
            Pers_list[1] = new Pers("Блейд", "DD or SapDD", "Ветреной", "Разрушение","Hp 1400","Def 800","Atc 420","Spid 97");
            Pers_list[2] = new Pers("Жуань Мэй","Sap","Леденой", "Гармония", "Hp 1100","Def 400","Atc 520","Spid 100");
            Pers_list[3] = new Pers("ХоХо","Hiler", "Ветреной", "Изобилие","Hp 1434","Def 600","Atc 420","Spid 102");
            Pers_list[4] = new Pers("Броня", "Sap", "Ветреной", "Гармония","Hp 1200","Def 450","Atc 520","Spid 100");
            Pers_list[5] = new Pers("Доктор Рацио", "DD", "Мнимый", "Охота", "Hp 1200", "Def 450", "Atc 620", "Spid 100");
            Pers_list[6] = new Pers("Дань хен", "DD", "Ветреной", "Охота","Hp 1150","Def 450", "Atc 540", "Spid 100");
            Pers_list[7] = new Pers("Цзин Юань", "DD", "Электрический", "Эрудикция","Hp 1200", "Def 450", "Atc 720", "Spid 99");
            Pers_list[8] = new Pers("Пела", "Debaffer", "Леденой","Небытие ", "Hp 1100", "Def 400", "Atc 450", "Spid 97");


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
            Button btn = (Button)sender;
            InfoForm info = new InfoForm(btn.Text);
            info.ShowDialog(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            int x = 10;
            int y = 90;
            for (int i = 0; i < 9; i++)
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
                if (x > this.Size.Width - 150)
                {
                    y += 250;
                    x = 10;

                }


            }
        }

        private void ViewPanel_Resize(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }

        private void Auth_button_Click(object sender, EventArgs e)
        {
            if (AuthForm.Login == "")
            {
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();
            }
            else
            {
                AuthForm.Login = "";
            }

            if (AuthForm.Login == "")
            {
                Auth_button.Text = "Войти";
                Hellolabel.Visible = false;
            }
            else 
            {
                Auth_button.Text = "Выйти";
                Hellolabel.Visible = true;
                Hellolabel.Text = "Вы аторизовались как" +  AuthForm.Login;
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

            for (int i =0; i < 9; i++)
            {
                Pers_list[i].btn.Visible = true;
                Pers_list[i].pic.Visible = true;
                if (roleCheckedListBox.CheckedItems.Count>0 &&
                    roleCheckedListBox.CheckedItems.Contains(Pers_list[i].role))
                {
                    Pers_list[i].btn.Visible = false;
                    Pers_list[i].pic.Visible = false;
                }


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
                    if (x > this.Size.Width - 150)
                    {
                        y += 250;
                        x = 10;
                    }
                }
            }



        }

        
    }
 
}
