using System;
namespace CircleObjects
{
	public class Circle
	{
		//properties
		public double Radius { get; set; }
		
		//constructor
		public Circle (double radius)
        {
			Radius = radius;
        }

        //--------Methods-----------
        public double CalculateCircumference()
        {
            double circumference = (2 * Math.PI) * Radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()//takes circ and formats to 2 decimals
        {
			string formatCircumference = FormatNumber(CalculateCircumference());
			return formatCircumference;
        }

		public double CalculateArea()
		{
			double area = Math.PI * (Radius * Radius);
			return area;
		}

		public string CalculateFormattedArea()//takes area and formats to 2 decimals
		{
			string formatArea = FormatNumber(CalculateArea());
			return formatArea;
		}

		private string FormatNumber(double x)//round number to two decimal points
        {
			string newString = Math.Round(x ,2).ToString();
			return newString;
        }
	}
}

