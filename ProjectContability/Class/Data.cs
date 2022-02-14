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
        private double credit = 0;
        private double debit = 0;
        private int type1; // activo (type1=0), pasivo (type1=1), capital (type1=2)
        private int type2; // corriente (type2=0), no corriente (type2=1), diferido (type2=2)

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
        public int Type1 { get => type1; set => type1 = value; }
        public int Type2 { get => type2; set => type2 = value; }
    }
}
