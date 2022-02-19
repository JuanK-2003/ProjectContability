using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContability.Class
{
    internal class Balancedesaldos
    {

        public List<DataToGeneralBalance> GenerateBalanceSaldos(List<Data> cuentas)
        {
            // recibe una lista de cuentas con sus saldos e identificacion requeridas

            string[] type1Heading = { "Activo", "Pasivo", "Capital" };
            string[] type2Heading = { "Corriente", "No corriente", "Diferido" };
            double[] APCsum = { 0, 0, 0 };

            List<DataToGeneralBalance> dataToDisplay = new List<DataToGeneralBalance>();

            for (int type1idx = 0; type1idx <= 2; type1idx++) // recorre activo, pasivo y capital
            {
                double sum = 0;

                for (int type2idx = 0; type2idx <= 2; type2idx++) // recorre corriente, no corriente, diferido
                {
                    List<string> AcountNames = new List<string>();
                    List<double> AcountBalance = new List<double>();

                    for (int cidx = 0; cidx < cuentas.Count; cidx++)
                    {
                        if ((cuentas[cidx].Type1 == type1idx && cuentas[cidx].Type2 == type2idx) || (type1idx == 2 && cuentas[cidx].Type1 == 2))
                        {
                            int zidx = AcountNames.IndexOf(cuentas[cidx].NameCuenta);

                            if (zidx < 0) // no esta incluida
                            {
                                AcountNames.Add(cuentas[cidx].NameCuenta);
                                AcountBalance.Add(cuentas[cidx].Credit - cuentas[cidx].Debit);
                            }
                            else AcountBalance[zidx] = AcountBalance[zidx] + cuentas[cidx].Credit - cuentas[cidx].Debit;
                        }
                    }

                    if (AcountNames.Count > 0)
                    {
                        for (int kidx = 0; kidx < AcountNames.Count; kidx++)
                        {
                            if (AcountBalance[kidx] < 0)
                            {
                                dataToDisplay.Add(new DataToGeneralBalance(AcountNames[kidx], Math.Abs(AcountBalance[kidx]) + "", ""));
                            }
                            else dataToDisplay.Add(new DataToGeneralBalance(AcountNames[kidx], "", Math.Abs(AcountBalance[kidx]) + ""));
                        }

                        sum += AcountBalance.Sum();

                    }

                    if (type1idx == 2) break;
                }
            }

            double debe = 0;
            double haber = 0;

            for (int kidx = 0; kidx < dataToDisplay.Count; kidx++)
            {
                if (dataToDisplay[kidx].Columna2.StartsWith("Q"))
                {
                    debe += Convert.ToDouble(dataToDisplay[kidx].Columna2.Split(' ')[1]);
                }

                if (dataToDisplay[kidx].Columna3.StartsWith("Q"))
                {
                    haber += Convert.ToDouble(dataToDisplay[kidx].Columna3.Split(' ')[1]);
                }
            }
            dataToDisplay.Add(new DataToGeneralBalance("SUMAS IGUALES", debe.ToString(), haber.ToString()));

            return dataToDisplay;
        }

        public string BalanceSaldosToText(List<DataToGeneralBalance> balanceSaldos)
        {
            string ret = "\tBALANCE DE SALDOS\t\n";

            for (int idx = 0; idx < balanceSaldos.Count; idx++)
            {
                ret += balanceSaldos[idx].ToString() + "\n";
            }

            return ret;
        }
    }
}
