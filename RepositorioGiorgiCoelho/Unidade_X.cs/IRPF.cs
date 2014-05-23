using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_X.cs
{
    class IRPF
    {
        public static void Maini(string[] args)
        {
            int quant_pessoas;
            double pensao_alimenticia;
            double salario_bruto;
            double valor_ser_pago;
            double aliquota = 0;
            double INSS = 0;
            double parcela_reduzir=0;

            Console.WriteLine("Salário Bruto: ");            
            salario_bruto = double.Parse(Console.ReadLine());
            
            if (salario_bruto <= 1317.07)
            {
                INSS = 8;
            }
            else if (salario_bruto <= 2195.12)
            {
                INSS = 9;
            }
            else if (salario_bruto <= 4390.24)
            {
                INSS = 11;
            }
            else if (salario_bruto > 4390.24)
            {
                INSS = 9.66;
            }
            Console.WriteLine("Pensão Alimentícia: ");
            pensao_alimenticia = double.Parse(Console.ReadLine());
            Console.WriteLine("Dependentes: ");
            quant_pessoas = int.Parse(Console.ReadLine());

            valor_ser_pago = salario_bruto - (((salario_bruto * INSS)/100) + pensao_alimenticia + (quant_pessoas*179.71));
            CalculaIRPF(valor_ser_pago, aliquota, parcela_reduzir);
            
            Console.ReadKey();

            
        }

        private static void CalculaIRPF(double valor_ser_pago,  double aliquota=0,  double parcela_reduzir=0)
        {
            if (valor_ser_pago <= 1787.77)
            {
                Console.WriteLine("Não há aliquota!");
            }
            else if (valor_ser_pago <= 2679.29)
            {
                aliquota = 7.5;
                parcela_reduzir = 134.08;
                valor_ser_pago = ((valor_ser_pago * aliquota) / 100) - parcela_reduzir;
                Console.WriteLine(valor_ser_pago + " R$ é o valor do imposto a ser retido na fonte.");
            }
            else if (valor_ser_pago <= 3572.43)
            {
                aliquota = 15;
                parcela_reduzir = 335.03;
                valor_ser_pago = ((valor_ser_pago * aliquota) / 100) - parcela_reduzir;
                Console.WriteLine(valor_ser_pago + " R$ é o valor do imposto a ser retido na fonte.");
            }
            else if (valor_ser_pago <= 4463.81)
            {
                aliquota = 22.5;
                parcela_reduzir = 602.96;
                valor_ser_pago = (valor_ser_pago * (aliquota / 100)) - parcela_reduzir;
                Console.WriteLine(valor_ser_pago + " R$ é o valor do imposto a ser retido na fonte.");
            }
            else if (valor_ser_pago > 4463.81)
            {
                aliquota = 27.5;
                parcela_reduzir = 826.15;
                valor_ser_pago = ((valor_ser_pago * aliquota) / 100) - parcela_reduzir;
                Console.WriteLine(valor_ser_pago + " R$ é o valor do imposto a ser retido na fonte.");
            }
            
        }
    }
}
