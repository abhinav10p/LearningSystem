using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSystem.UXCustom
{
    public partial class CustomListItem : UserControl
    {
        public CustomListItem()
        {
            InitializeComponent();

        }
        public string DisplayMember { get; internal set; }

        private string _title;
        [Category("Custom Props")]
        public String Title
        {
            get { return _title; }
            set
            {
                _title = value;
                label1.Text = value;
                this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void CustomListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void CustomListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
        }

    }
}
