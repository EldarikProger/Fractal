using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SmallBasic.Library;

namespace Fractal
{
    public partial class Form1 : Form
    {
        private MyFractal fractal;


        public Form1()
        {
            InitializeComponent();
            fractal = new MyFractal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            fractal.TurtleDrawMyFractal(this.getH(),this.getN());
            this.Close();
        }

        public int getN()
        {
            return (int)this.NView.Value;
        }

        public String getH()
        {
            try
            {
                int i = (int)this.HView.Value;
                return i.ToString();
            }
            catch
            { return "10"; }
        }

        private void NView_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
