using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Classes_Objects_01
{

    // members of class = properties or methods
    // our class will have 4 properties : make, model, year and color (attributes of the class)
    // properties = attributes  methods = functions/behavior

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double determineMarketValue()
        {
            double carValue;
            if (this.Year > 1990) carValue = 10000.0;
            else carValue = 2000.0;
            return carValue;
        }

    }
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supremee";
            myNewCar.Year = 1996;
            myNewCar.Color = "Silver";

            double marketValue = myNewCar.determineMarketValue();

            resultLbl.Text = String.Format("{0} - {1} - {2} - {3} - {4:C}", 
                myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Color, marketValue);
        }

       
    }

    
}