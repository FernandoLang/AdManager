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
    public partial class adsModel : UserControl
    {
        public string name
        {
            get { return this.adsName.Text; }
            set { this.adsName.Text = value; }
        }
        public string client
        {
            get { return this.adsClient.Text; }
            set { this.adsClient.Text = value; }
        }
        public string datestart
        {
            get { return this.adsDateStart.Text; }
            set { this.adsDateStart.Text = value; }
        }
        public string dateend
        {
            get { return this.adsDateEnd.Text; }
            set { this.adsDateEnd.Text = value; }
        }
        public string id
        {
            get { return this.lblid.Text; }
            set { this.lblid.Text = value; }
        }
        public string value
        {
            get { return this.lblValue.Text; }
            set { this.lblValue.Text = value; }
        }
        public adsModel()
        {
            InitializeComponent();
        }
    }
}
