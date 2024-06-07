using System.ComponentModel;
using System.Windows.Input;

namespace SumaMVVM.ViewModel
{
	public class CalculatorViewModel : INotifyPropertyChanged
	{
		private CalculatorModel _model;
		public CalculatorViewModel()
		{
			_model = new CalculatorModel();
		}

		public double Value1
		{
			get { return _model.Value1; }
			set { _model.Value1 = value; OnPropertyChanged(nameof(Value1)); }
		}

		public double Value2
		{
			get { return _model.Value2; }
			set { _model.Value2 = value; OnPropertyChanged(nameof(Value2)); }
		}

		public double Result
		{
			get { return _model.Result; }
			set { _model.Result = value; OnPropertyChanged(nameof(Result)); }
		}

		public ICommand AddCommand => new Command(AddValues);
		public ICommand ClearCommand => new Command(ClearValues);

		private void AddValues()
		{
			if (Value1 == 0 && Value2 == 0)
			{
				DisplayAlert("Error", "Por favor, ingrese valores válidos");
				return;
			}
			_model.AddValues();
			OnPropertyChanged(nameof(Result));
		}

		private void DisplayAlert(string v1, string v2)
		{
			DisplayAlert("Error", "Por favor, ingrese valores válidos");
		}

		private void ClearValues()
		{
			Value1 = 0;
			Value2 = 0;
			Result = 0;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}


	}
}
