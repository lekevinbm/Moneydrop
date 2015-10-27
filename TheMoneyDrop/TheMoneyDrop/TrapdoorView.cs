using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMoneyDrop
{
  public partial class TrapdoorView : UserControl
  {
    private TrapdoorController _controller;
    
    
    public TrapdoorView(TrapdoorController controller)
    {
     

      _controller = controller;
            InitializeComponent();
        }

    private void label1_Click(object sender, EventArgs e)
    {
            _controller.model.Inzet = Convert.ToSingle(txtInzet.Text);
        }

    private void txtInzet_TextChanged(object sender, EventArgs e)
    {
           
           
    }

    public void UpdateUI()
    {
      lblIngezet.Text = _controller.model.Inzet.ToString();
;
    }

        private void TrapdoorView_Load(object sender, EventArgs e)
        {

        }

        private void btnInzetten_Click(object sender, EventArgs e)
        {
            _controller.model.Inzet = Convert.ToSingle(txtInzet.Text);
            UpdateUI();

        }
    }
}
