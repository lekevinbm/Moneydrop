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
    private TrapdoorController controller;
    private TrapdoorModel model;
    
    public TrapdoorView()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void txtInzet_TextChanged(object sender, EventArgs e)
    {
      model.Inzet = Convert.ToSingle(txtInzet.Text);

    }

    public void UpdateUI()
    {
      lblIngezet.Text = model.Inzet.ToString();
;
    }
  }
}
