using System;
using System.Collections.Generic;
using System.Text;

namespace SarkilarSozler.Core.Models
{

    public class Sanatci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int SanatciId { get; set; }

        public Sarkilar Sarkilar { get; set; }
    }
}