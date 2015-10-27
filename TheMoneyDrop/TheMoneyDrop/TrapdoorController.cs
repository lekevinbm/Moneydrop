using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyDrop
{
  public class TrapdoorController
  {
        private TrapdoorView view;
        public TrapdoorModel model;
        

        public TrapdoorController()
        {
            // Maak een instantie van de view
            // Geef een de huidige instantie (= controller = this) mee als argument
            view = new TrapdoorView(this);

            // Maak een nieuwe instantie van het model aan
            model = new TrapdoorModel();
        }



        

        public TrapdoorView getView()
        {
            return view;
        }



    }
}
