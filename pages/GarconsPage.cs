using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
namespace CadastroContatos.pages
{
	public class GarconsPage : TabbedPage
    {
		public GarconsPage()
		{

            Children.Add(new GarconsListaPage()
            {
                Title = "Listagem",
                Icon="list.png"
           
            });



            Children.Add(new GarconsNewPage()
            {
                Title = "Inserir Novo",
                Icon="add.png"
            });
        }
	}
}