using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheDotFactory
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();

            Init();
        }

        public void Init()
        {
//            progressBar1.Sytle = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
        }

        public void SetProgress( int iVal )
        {
            progressBar1.Value = iVal;
        }
    }
}
