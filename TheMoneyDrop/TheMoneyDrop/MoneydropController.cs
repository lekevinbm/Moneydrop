using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyDrop
{
    public class MoneydropController
    {
        private GameController controller;

        private MoneydropModel model;
        private MoneydropView view;

        public MoneydropController(GameController co)
        {
            controller = co;
            view = new MoneydropView(this);
            model = new MoneydropModel();
        }

        public void initialize ()
        {
            maakTrapdoors();
        }



        private void maakTrapdoors()
        {
            /* for (int trapdoorNr = 0; trapdoorNr < model.AantalTrapdoors; ++trapdoorNr)
             {
                 TrapdoorController trapdoor = new TrapdoorController();

                // model.voegTrapdoorToe(trapdoor);
             }
         }

         public int AantalTrapdoors
         {
            get { return AantalTrapdoors; }
            set { AantalTrapdoors = model.AantalTrapdoors;  }
            */
        }

        public List<TrapdoorView> getTrapdoorsView()
        {
            List<TrapdoorView> trapdoorsView = new List<TrapdoorView>();

          /*  foreach (TrapdoorController teerling in model.Trapdoors)
            {
                TrapdoorView teerlingView = teerling.getView();

                trapdoorsView.Add(teerlingView);
            }*/

            return trapdoorsView;
        }

        public MoneydropView getView()
        {
            return view;
        }
    }
}
