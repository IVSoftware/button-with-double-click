using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace double_click
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonTryDoubleClick.Click += ButtonTryDoubleClick_Click;
            buttonTryDoubleClick.DoubleClick += ButtonTryDoubleClick_DoubleClick;
        }

        private async void ButtonTryDoubleClick_Click(object sender, EventArgs e)
        {
            _isDoubleClick = false;
            // Allow some time to get the second click if it's coming.
            await Task.Delay(100);
            if(!_isDoubleClick)
            {
                MessageBox.Show("Clicked");
            }
        }

        bool _isDoubleClick = false;
        private void ButtonTryDoubleClick_DoubleClick(object sender, EventArgs e)
        {
            _isDoubleClick = true;
            BeginInvoke((MethodInvoker)delegate 
            {
                MessageBox.Show("Double Clicked");
            }); 
        }
    }
    class ButtonWithDoubleClick : Button
    {
        const int WM_LBUTTONDBLCLK = 0x203;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_LBUTTONDBLCLK:
                    OnDoubleClick(EventArgs.Empty);
                    break;
            }
        }
    }
}
