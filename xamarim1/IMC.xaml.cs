using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarim1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IMC : ContentPage
    {
        public IMC()
        {
            InitializeComponent();
            btIMC.Clicked += BtIMC_Clicked;
        }

        private void BtIMC_Clicked(object sender, EventArgs e)
        {
            double peso = int.Parse(etPeso.Text);
            double altura = int.Parse(etAltura.Text);
            double resp = peso / (altura * altura);
            lblResp.Text = resp.ToString();
        }
    }
}