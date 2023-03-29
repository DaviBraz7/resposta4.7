using System;

class Program {
    static void Main(string[] args) {

        double[] faturamentoDiario = { 1500.0, 1800.0, 1200.0, 2000.0, 0.0, 2500.0, 1700.0};


        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0.0;
        int numDiasComFaturamentoSuperiorMedia = 0;

        foreach (double faturamento in faturamentoDiario) {
            if (faturamento > 0.0) {
                if (faturamento < menorFaturamento) {
                    menorFaturamento = faturamento;
                }
                if (faturamento > maiorFaturamento) {
                    maiorFaturamento = faturamento;
                }
                somaFaturamento += faturamento;
            }
        }

        double mediaAnual = somaFaturamento / numDiasComFaturamentoSuperiorMedia;

        foreach (double faturamento in faturamentoDiario) {
            if (faturamento > mediaAnual) {
                numDiasComFaturamentoSuperiorMedia++;
            }
        }


        Console.WriteLine("Menor faturamento diário: " + menorFaturamento);
        Console.WriteLine("Maior faturamento diário: " + maiorFaturamento);
        Console.WriteLine("Dias com faturamento superior à média anual: " + numDiasComFaturamentoSuperiorMedia);
        Console.ReadKey();
    }
}
