using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie= new List<Serie>();
        public void Atualiza(int id, Serie objecto)
        {
            listaSerie[id]=objecto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objecto)
        {
            listaSerie.Add(objecto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
           return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
           return listaSerie[id];
        }
        
    }
}