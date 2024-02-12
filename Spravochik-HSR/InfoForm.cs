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
    public partial class InfoForm : Form
    {
        public InfoForm(Pers pers)
        {
            InitializeComponent();

            Text = pers.name;
            label.Text = pers.name;

            pictureBox1.Load("../../Pictures/" + pers.name + ".png");


            rolelabel.Text = pers.role;
            tiplabel.Text = pers.tip;
            pytelabel.Text = pers.pyte;
            //типы
            if(pers.tip == "Физический")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Физический.png");
            }
            if (pers.tip == "Ветреной")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Ветреной.png");
            }
            if (pers.tip == "Леденой")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Леденой.png");
            }
            if (pers.tip == "Мнимый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Мнимый.png");
            }
            if (pers.tip == "Электрический")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Электрический.png");
            }
            if (pers.tip == "Огненый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Огненый.png");
            }
            if (pers.tip == "Квантовый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Квантовый.png");
            }
            //пути
            if (pers.pyte == "Разрушение")
            {
                PytepictureBox.Load("../../Pictures/Путь_Разрушение.png");
            }





        }




        
    }
}
