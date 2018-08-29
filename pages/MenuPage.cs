using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CadastroContatos.pages
{
	public class MenuPage : ContentPage
	{
		public MenuPage ()
		{
            Title = "Menu";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Button()
                    {
                        Image = "waiter.png",
                        Text="Garços",
                        Command = new Command(()=>Navigation.PushAsync(new GarconsPage()))
                    }
                }

            };
            
		}
	}
}