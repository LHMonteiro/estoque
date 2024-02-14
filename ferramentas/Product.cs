 using System;
 using System.Collections.Generic;

 namespace jogaOnline.Prodduct{
    abstract class ProductGeneric : IEquatable<ProductGeneric>{

        public double Valor { get; set; }
        public int DataFabric { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public double Imposto { get; set; }
        public string codigo {get; set;}

    }
 }