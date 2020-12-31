using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SarkilarSozler.NetCore.Models
{

    public class Sanatci
    {
        public Sanatci()
        {
            Sarkilar = new Collection<Sarkilar>();

        }


        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<Sarkilar> Sarkilar { get; set; }

         
    }
}