using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGK_DigiTools
{
    public partial class messagedebugger : Form
    {
        public messagedebugger()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get
            {
                return this.BClose.Text;
            }
            set
            {
                this.BClose.Text = value;
            }
        }

    }
}
