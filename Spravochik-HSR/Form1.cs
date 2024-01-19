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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text = "Началная страница";
            button1.Text = "Нфжми меня";

            pictureBox2.Load("../../Pictures/Путь_Разрушение.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            Label lbl = new Label();
            lbl.Location = new Point(70, 255);
            lbl.Size = new Size(150, 25);
            lbl.Font = new Font("Times New Roman", 15F);
            lbl.Text = "Celys";
            lbl.Click += new System.EventHandler(label1_Click);
            Controls.Add(lbl);

            PictureBox pb = new PictureBox();
            pb.Location = new Point(440, 50);
            pb.Size = new Size(185, 185);
            pb.Load("../../Pictures/Тип_урона_Физический.png");
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Click += new System.EventHandler(pictureBox1_Click);
            Controls.Add(pb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
     
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочник открыт");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Зачем ты тыкнул Келиуса ");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
