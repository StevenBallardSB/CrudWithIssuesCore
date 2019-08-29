using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class AreaPerimeter : Form
    {
        public AreaPerimeter()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(LengthInput.Text);
            int width = Convert.ToInt32(WidthInput.Text);

            AreaOutput.Text = Convert.ToString(width * length);
            PerimeterOutput.Text = Convert.ToString(2 * width + 2 * length);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
