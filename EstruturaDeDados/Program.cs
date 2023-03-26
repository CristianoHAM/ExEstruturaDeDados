

namespace EstruturaDeDados;
class Program
{
    static void Main(string[] args)
    {
        // Declaração de vetores 
        int[] VetorA = new int[2];
        int[] VetorB = new int[] { 3, 2, 1 };
        int[] VetorC = { 4, 5, 6 };

        // Utilizando Vetor atravez de acesso direto 
        Console.WriteLine(VetorA[1]);
        VetorA[1] = 1;
        Console.WriteLine(VetorA[1]);

        // Metodos de vetores
        Console.WriteLine(VetorA.GetValue(1));
        VetorA.SetValue(3, 1);
        Console.WriteLine(VetorA.GetValue(1));



        //------ Chamando metodos ------

        //Chamando metodo que percorre vetor e exibe os valores  
        Console.WriteLine(" Exibindo vetor:");
        EscrverVetor(ref VetorB);
        //EscrverVetor(ref VetorC);
        //EscrverVetor(ref VetorA);


        // Chamando metodo que busca sequencialmente um valor em tevor e retorna o indice
        Console.WriteLine("Busca sequencial");
        int[] VetorX = { 32, 23, 444, 67};
        int valor = 4;
        int posicao = BuscaSequencial(ref VetorX, valor);
        if (posicao >= 0)
        {
            Console.WriteLine("Ao busca o valor "+ valor +" foi encontrado no indice"+ posicao );
        }
        else
        {
            Console.WriteLine("O valor " + valor + " não foi encontrado no vetor");
        }

        // Chamando metodo de remoção em um vetor i
        int[] VetorY = { 4, 3, 2, 1 };
        int indici = 1;
        EscrverVetor(ref VetorY);
        Console.WriteLine("Apagando posição com o índici"+ indici);
        RemoverItem(ref VetorY, indici);
        EscrverVetor(ref VetorY);
        Console.WriteLine("Removido !!!");


        // 
        EscrverVetor(ref VetorY);
        Console.WriteLine("Ordenando !!!");
        OrdenaBubble(ref VetorY);
        EscrverVetor(ref VetorY);

        //dsad
        VetorY =new int[] { 4, 3, 2, 1 };
        Console.WriteLine("section");
        EscrverVetor(ref VetorY);
        Console.WriteLine("Ordenando !!!");
        OrdenaSelect(ref VetorY);
        EscrverVetor(ref VetorY);


    }

    // Percorendo vetor para exibir os valores 
    static void EscrverVetor(ref int[] vetor)
    {
        for (int contadora = 0; contadora < vetor.Length; contadora++)
        {
            Console.WriteLine(vetor[contadora]);
        }

    }

    // Busca sequencial de valores em um vetor
    static int BuscaSequencial(ref int[] vetor, int valor)
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

    // Remoção em um vetor
    static void RemoverItem(ref int[] Vetor, int index)
    {
        for (int i = index; i < Vetor.Length - 1; i++)
        {
            Vetor[i] = Vetor[i + 1];
        }
        Array.Resize(ref Vetor, Vetor.Length - 1);
    }


    static void OrdenaBubble(ref int[] vetor)
    {
        //int contaPer=0;
        //int contaTroca=0;
        int temp;
        for (int ii = vetor.Length; ii >= 1; ii--)
        {

            for (int i = 0; i < ii - 1; i++)
            {
                //contaPer++;
                if (vetor[i] > vetor[i + 1])
                {
                    //contaTroca++;
                    temp = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = temp;
                }
            }
        }
        //Console.WriteLine(contaPer);
        //Console.WriteLine(contaTroca);
    }
    static void OrdenaSelect(ref int[] vetor)
    {
        //int contaPer=0;
        //int contaTroca=0;
        int aux;
        int min;
        for (int ii = 0; ii < vetor.Length-1; ii++)
        {
            min = ii;
            for (int i = ii+1; i < vetor.Length; i++)
                //contaPer++;
                if (vetor[i] < vetor[min])
                    min=i;
            //contaTroca++;
            aux = vetor[ii];
            vetor[ii] = vetor[min];
            vetor[min] = aux;
        }
        //Console.WriteLine(contaPer);
        //Console.WriteLine(contaTroca);
    }

}
