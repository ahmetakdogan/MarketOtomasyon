using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace market
{
    public partial class baseForm : Form
    {
        public static baseForm anaForm = null;
        public static baseForm childForm = null;

        public virtual void Kaydet() {}
        
        public virtual void Sil() {}

        public virtual void Cikis() {}

        public virtual void Listele() { }

        public baseForm()
        {
            InitializeComponent();
        }
    }
}
