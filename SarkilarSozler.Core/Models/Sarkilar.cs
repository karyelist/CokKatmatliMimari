using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SarkilarSozler.Core.Models
{
    public class Sarkilar
    {
        public Sarkilar()
        {
            var Sanatcilar = new Collection<Sanatci>();
        }

        public int Id { get; set; }
        public string SarkiAd { get; set; }
        public ICollection<Sanatci> Musics { get; set; }

    }
}