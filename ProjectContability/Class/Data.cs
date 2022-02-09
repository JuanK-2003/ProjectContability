using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContability.Class
{
    internal class Data
    {
        private string nameCuenta;
        private double credit;
        private double debit;

        public Data()
        {

        }

        public Data(string nameCuenta, double credit, double debit)
        {
            this.NameCuenta = nameCuenta;
            this.Credit = credit;
            this.Debit = debit;
        }

        public string NameCuenta { get => nameCuenta; set => nameCuenta = value; }
        public double Credit { get => credit; set => credit = value; }
        public double Debit { get => debit; set => debit = value; }
    }
}
