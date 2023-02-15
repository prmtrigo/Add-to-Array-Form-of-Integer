namespace Add_to_Array_Form_of_Integer;
class Program
{
    public IList<int> AdicionarNumero(int[] array, int numero){

        int tamanho = array.Length -1;

        var resultado = new List<int>();

        while(tamanho >=0 || numero > 0){

            numero += (tamanho >= 0 ? array[tamanho--] : 0);

            resultado.Add((numero % 10));

            numero /= 10;

        }

        resultado.Reverse();

        return resultado;
    }

    static void Main(string[] args)
    {
        Program p = new Program();

        int[] array = {1,2,0,0};

        int numero = 34;

        Console.WriteLine(p.AdicionarNumero(array,numero));

    }
}
