using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdManager.Controlls
{
    public partial class Relatory : Form
    {
        public string value
        {
            get { return null; }
            set { this.lblValue.Text = value; }
        }
        public string max_visualization_without_share
        {
            get { return null; }
            set { this.lblMaxvisualization.Text = value; }
        }
        public string max_visualization_with_share
        {
            get { return null; }
            set { this.lblVisualizationshared.Text = value; }
        }
        public string max_clicks
        {
            get { return null; }
            set { this.maxClicks.Text = value; }
        }
        public Relatory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
