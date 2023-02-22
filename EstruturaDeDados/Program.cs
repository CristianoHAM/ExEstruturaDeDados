

namespace EstruturaDeDados;
class Program
{
    static void Main(string[] args)
    {
        // Atividade 2
        int[] VetorA = new int[2];
        int[] VetorB = new int[] { 3, 2, 1 };
        int[] VetorC = { 4, 5, 6 };


        VetorA[0] = 1;
        //Console.WriteLine(VetorA[1]);


        VetorA.SetValue(3, 1);
        // Console.WriteLine(VetorA.GetValue(1));

        // Atividade 3
        //EscrverVetor(ref VetorB);
        //EscrverVetor(ref VetorC);
        //EscrverVetor(ref VetorA);


        // Atividade 4
        //int[] VetorX = { 32, 23, 444, 67};
        //Console.WriteLine(BuscarNoVetor(ref  VetorX, 4));

        // Atividade 5
        int[] VetorY = { 4, 3, 2, 1 };
        //   EscrverVetor(ref VetorY);
        //Console.WriteLine("Apagando !!!");
        //RemoverItem(ref VetorY, 1);
        //EscrverVetor(ref VetorY);


        //ativida 6
        EscrverVetor(ref VetorY);
        Console.WriteLine("Ordenando !!!");
        Ordena(ref VetorY);
        EscrverVetor(ref VetorY);
        for ( int contodora = 0; contodora < 10 ; contodora++ ){
            Console.WriteLine(contodora);

        }

    }
    //Atividade 3
    static void EscrverVetor(ref int[] vetor)
    {
        for (int contadora = 0; contadora < vetor.Length; contadora++)
        {
            Console.WriteLine(vetor[contadora]);

        }

    }

    //Atividade 4
    static int BuscarNoVetor(ref int[] vetor, int valor)
    {
        for (int contadora = 0; contadora < vetor.Length; contadora++)
        {

            if (valor == vetor[contadora])
            {
                Console.WriteLine("achei");
                return contadora;
            }
        }
        return -1;

    }

    // Atividade 5

    static void RemoverItem(ref int[] Vetor, int index)
    {
        for (int i = index; i < Vetor.Length - 1; i++)
        {
            Vetor[i] = Vetor[i + 1];
        }
        Array.Resize(ref Vetor, Vetor.Length - 1);

    }

    static void Ordena(ref int[] vetor)
    {
        int temp;
        for (int ii = vetor.Length; ii >= 1; ii--)
        {

            for (int i = 0; i < ii - 1; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    temp = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = temp;
                }
            }
        }
    }

}
