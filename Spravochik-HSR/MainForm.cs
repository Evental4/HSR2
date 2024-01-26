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
 public partial class MainForm : Form
 {
    public struct Pers
    {
        public string name;
        public string role;
        public string Hp;
        public string Def;
        public string Atc;
        public string Spid;
        public Button btn;
        public PictureBox pic;
        public PictureBox path;
        public PictureBox element;

        public Pers(string _name, string _role, string _Hp, string _Def, string _Atc, string _Spid)
        {
            name = _name;
            role = _role;
            Hp = _Hp;
            Def = _Def;
            Atc = _Atc;
            Spid = _Spidp;
            btn = new Button();
            pic = new PictureBox();
            path = new PictureBox();
            element = new PictureBox();

            btn.Font = new Font("Microsoft Sans Serif" , 12F);
            btn.Text = name;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load("../../Pictures/"+ name +".png"); 
        }
    }

       public partial class MainForm : Form
       {
        Pers cel = new Pers("Келус","DD or SapDD","Hp 1203","Def 460","Atc 620","Spid 100");
        Pers blei = new Pers("Блейд","DD or SapDD","Hp 1400", "Def 500","Atc 420", "Spid 97");




        public MainForm()
        {
            InitializeComponent();

            Text = "Справочник по HSR";
            
            
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
       }
 }
}
