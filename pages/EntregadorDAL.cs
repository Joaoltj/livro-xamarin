using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
namespace CadastroContatos.pages
{
    class EntregadorDAL
    {
        private ObservableCollection<Entregador> Entregadores = new ObservableCollection<>();
        private static EntregadorDAL EntregadorInstance = new EntregadorDAL();

        private EntregadorDAL()
        {
            Entregadores.Add(new Entregador() {
                Id=1,Nome="Yuri",Telefone="87579511"
            });

            Entregadores.add(new Entregador() {
                Id=2,Nome="Thyago",Telefone="9090909090"
            });

            Entregadores.add(new Entregador() {
                Id=3,Nome="Douglas",Telefone="808088464"
            });
            Entregadores.add(new Entregador() {
                Id=4,Nome="Hudson",Telefone="77777777"
            });

            Entregadores.add(new Entragador() {
                Id=5,Nome="Bielzinho",Telefone="457235258"
            });
        }

        public static EntregadorDAL GetInstance()
        {
            return EntregadorDAL;
        }
        public ObservableCollection<Entregador> GetAll()
        {
            return Entregadores;
        }
        public void add(Entregador entregador)
        {
            this.Entregadores.add(entregador);
        }
    }
}
