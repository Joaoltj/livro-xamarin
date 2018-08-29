using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CadastroContatos.pages
{
	public class GarconsListaPage : ContentPage
	{
		public GarconsListaPage ()
		{
            Content = GetGarcons();
		}

        public ListView GetGarcons()
        {
            var garcons = new ListView();
        
            garcons.ItemsSource = new String[]
            {
                "João","Alan","Ronald","Marcus","Elton","Tiago","Pedro","Rodrigo"
            };

            return garcons;
        }
	}
}