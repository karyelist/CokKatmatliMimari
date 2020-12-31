using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SarkilarSozler.NetCore.Models;

namespace SarkilarSozler.NetCore.Models
{
    public class Sarkilar
    {
        /*
        public Sarkilar()
        {
             Sanatcilar = new Collection<Sanatci>();
        }*/

        public int Id { get; set; }
        public string Ad { get; set; }
        public int SanatciId { get; set; }
//        public ICollection<Sanatci> Sanatcilar { get; set; }
        public Sanatci Sanatcilar { get; set; }

    }
}