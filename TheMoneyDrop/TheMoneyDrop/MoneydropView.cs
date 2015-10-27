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
  public partial class MoneydropView : UserControl
  {
        private MoneydropController controller;

    public MoneydropView(MoneydropController moneydropController)
    {
      controller = moneydropController;
      InitializeComponent();
    }

    private void MoneydropView_Load(object sender, EventArgs e)
    {
        List<TrapdoorView> trapdoors = controller.getTrapdoorsView();

        int teerlingWidth = trapdoors.First().Width;

        int teerlingHeight = trapdoors.First().Height;
        
        foreach (TrapdoorView trapdoor in trapdoors)
        {
                TrapdoorView huidigeTrapdoor = trapdoor;
                int xPos = trapdoors.IndexOf(trapdoor) * teerlingWidth;
                huidigeTrapdoor.Location = new Point(xPos, 0);
                Controls.Add(huidigeTrapdoor);
            }
    }
  }
}
