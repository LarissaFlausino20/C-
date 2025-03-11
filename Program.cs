class Program
{
    static void Main()
    {
        int idade;

        // Exibe mensagem informativa para o usuário
        Console.WriteLine("Programa para tirar CNH");

        // Solicita que o usuário informe a idade
        Console.WriteLine("Informe a sua idade");
        
        // Lê a idade informada pelo usuário
        idade = Convert.ToInt32(Console.ReadLine());

        // Verifica se a idade é 18 ou maior
        if (idade >= 18)
        {
            Console.WriteLine("Parabéns, você pode tirar a sua habilitação");
        }
        else
        {
            Console.WriteLine("Desculpe, você não pode tirar sua habilitação");
        }

        // Aguarda o usuário pressionar uma tecla antes de fechar o console
        Console.ReadKey();
    }
}
