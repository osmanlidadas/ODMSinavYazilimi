﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMSinavYazilimi.Models
{
  public  class OgrDogruYanlisSayilariModel
    {
        //public string BransAdi { get; set; }
        public int BransId { get; set; }
        public int Dogru { get; set; }
        public int Yanlis { get; set; }
        public int Bos { get; set; }
        //public decimal Net { get; set; }
        public decimal KatSayi { get; set; }
    }
}
