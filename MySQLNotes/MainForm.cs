using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLNotes
{
    public partial class MainForm : Form
    {
        IOCBootstrapper bootstrapper = new IOCBootstrapper();

        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            bootstrapper.BindViewsAndPresenters(this);
        }
    }
}
