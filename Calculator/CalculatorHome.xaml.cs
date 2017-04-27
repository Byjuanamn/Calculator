using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
	public partial class CalculatorHome : ContentPage
	{
		public CalculatorHome()
		{
			InitializeComponent();
		}

		async void OnAddOperation(object sender, EventArgs e)
		{
			var operando1 = Convert.ToInt32(numberText1.Text);
			var operando2 = Convert.ToInt32(numberText2.Text);

			var result = operando1 + operando2;

			resultLbl.Text = Convert.ToString(result);
			System.Diagnostics.Debug.WriteLine(String.Format("El resultado es --> {0}", result));

			await Task.WhenAny<bool>(
			 resultLbl.ScaleTo(2, 250)
			);

			await resultLbl.ScaleTo(1, 500);


		}

		void OnProductOperation(object sender, EventArgs e)
		{
			// metemos un displayAlert
			this.DisplayAlert("Aviso", "Esta funcionalidad no está implemetada aún", "Ok");
		}

		void OnMinusOperation(object sender, EventArgs e)
		{
			var operando1 = Convert.ToInt32(numberText1.Text);
			var operando2 = Convert.ToInt32(numberText2.Text);

			var result = operando1 * operando2;

			resultLbl.Text = Convert.ToString(result);
			System.Diagnostics.Debug.WriteLine(String.Format("El resultado es --> {0}", result));

		}
	}
}
