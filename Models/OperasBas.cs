using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public int res { get; set; }

        public void Suma()
        {
            this.res = this.Num1 + this.Num2;
        }

        public void Resta()
        {
            this.res = this.Num1 - this.Num2;
        }

    }
}