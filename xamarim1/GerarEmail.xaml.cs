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
    public partial class GerarEmail : ContentPage
    {
        public GerarEmail()
        {
            InitializeComponent();
            btExecutar.Clicked += btExecutar_Clicked;

        }

        private void btExecutar_Clicked(object sender, EventArgs e)
        {
            string nome = etNome.Text;
            String[] tempResp = nome.Split(' ');
            string resp = tempResp[1] + tempResp[0] + "@ufn.edu.br";
            lblResp.Text = resp;
        }
    }
}