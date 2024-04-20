namespace DesadioDioCalculadora
{
    public class Calculadora
    {
        List<int> listaHistorico = [];
        public int Somar(int num1, int num2)
        {
            var resultado = num1 + num2;
            listaHistorico.Insert(0, resultado);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            var resultado = num1 - num2;
            listaHistorico.Insert(0, resultado);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            var resultado = num1 * num2;
            listaHistorico.Insert(0, resultado);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            var resultado = num1 / num2;
            listaHistorico.Insert(0, resultado);
            return resultado;
        }

        public List<int> ExibirHistorico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }


    }
}
