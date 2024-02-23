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
    public partial class SelectForm : Form
    {
        public static List<Pers>  my_pers_list = new  List<Pers>();
        


        public SelectForm()
        {
            InitializeComponent();
            int y = 50;

            for (int i = 0; i < my_pers_list.Count; i++)
            {
                Pers pers = my_pers_list[i];

                #region изображение обекта
                PictureBox pb = new PictureBox();
                pb.Image = pers.pic.Image;
                pb.Location = new Point(50 ,y);
                pb.Size = new Size(185, 185);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                #endregion

                #region название обекта
                Label lbl1 = new Label();
                lbl1.Text = pers.name;
                lbl1.Location = new Point(450 ,y);
                lbl1.Size = new Size(100, 30);
                Controls.Add(lbl1);
                #endregion

                y += 150;

            }
        }



        
    }
}
