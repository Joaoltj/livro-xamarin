using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadastroContatos.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPageXAML : ContentPage
	{
		public MenuPageXAML()
		{
			InitializeComponent();
		}

        public async void GarconsOnClicked(Object sender,EventArgs args)
        {
            await Navigation.PushAsync(new GarconsPage());
        }
        public async EntregadorOnClicked(Object sender,EventArgs args)
        {
         await Navigation.PushAsync();
        }
	}
}