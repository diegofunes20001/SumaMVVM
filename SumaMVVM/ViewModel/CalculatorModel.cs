using System.ComponentModel;

namespace SumaMVVM.ViewModel
{

	public partial class CalculatorModel
	{
		public double Value1 { get; set; }
		public double Value2 { get; set; }
		public double Result { get; set; }

		public void AddValues()
		{
			Result = Value1 + Value2;
		}
	}
}
 
