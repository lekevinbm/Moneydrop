using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheMoneyDrop
{
  public partial class GameView : Form
  {
        private GameController controller;

        public GameView(GameController c)
        {
            controller = c;
            InitializeComponent();
        }

        private void GameView_Load(object sender, EventArgs e)
        {
            // Aantal teerlingen dat getoond moet worden
            int aantalTrapdoors = 5;

            // Maak een lijst aan waarin de teerlingen worden opgevangen
            List<TrapdoorController> trapdoor = new List<TrapdoorController>();

            // Maak instanties van de teerlingen aan en voeg deze toe aan de list
            for (int trapdoorNummer = 0; trapdoorNummer < aantalTrapdoors; ++trapdoorNummer)
            {
                // maak nieuwe instantie van teerling controller;
                TrapdoorController nieuweTrapdoor = new TrapdoorController();

                // Voeg controller toe aan teerlingen lijst
                trapdoor.Add(nieuweTrapdoor);
            }

            // Maak instanties van de teerlingen aan en voeg deze toe aan de list
            for (int trapdoorNummer = 0; trapdoorNummer < aantalTrapdoors; ++trapdoorNummer)
            {
                // Haal de teerling op basis van de key uit de teerlingen list 
                TrapdoorController huidigeTeerling = trapdoor[trapdoorNummer];

                // Haal de teerling view uit de teerling controller
                TrapdoorView huidigeTrapdoorview = huidigeTeerling.getView();

                // Bepaald de huidige x positie (horizontaal) van de teerling
                int xPos = huidigeTrapdoorview.Width * trapdoorNummer;

                // Zet de locatie van de teerling op basis van de x pos
                huidigeTrapdoorview.Location = new Point(xPos, 0);

                // Voeg de view toe aan de huidige view
                Controls.Add(huidigeTrapdoorview);
            }
        }
    }
    }

