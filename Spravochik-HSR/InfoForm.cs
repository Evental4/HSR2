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
        public InfoForm(string name)
        {
            InitializeComponent();

            Text = name;
            label.Text = name;

            pictureBox1.Load("../../Pictures/" + name + ".png");
        }

        
    }
}
