namespace GitHubFiles.Exercises;

class E1175ArrayChange01
{
    public static void Run()
    {
        int[] numbers = new int[20];
        int aux, tailPosition;
        // Esse codigo foi escrito considerando que o array tenha um comprimento par
        const int arraySize = 20;
        
        // Preenchendo o array
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        // Invertendo as posicoes
        for (int i = 0; i < (arraySize / 2); i++)
        {
            tailPosition = (arraySize-1) - i;
            aux = numbers[i];
        
            numbers[i] = numbers[tailPosition];
            numbers[tailPosition] = aux;
        }
        
        // Imprimindo o resultado
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine($"N[{i}] = {numbers[i]}");
        }

    }
}