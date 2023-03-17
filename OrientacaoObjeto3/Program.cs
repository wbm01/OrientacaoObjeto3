using OrientacaoObjeto3;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Willian", "(16) 9999", "Av.40, 391");
        Professor professor = new Professor("José", "(16) 0000", "Av.41, 392", 1234.56);
        Professor professor2 = new Professor(pessoa, 1222.56);
        Estudante estudante = new Estudante("João", "(16) 1111", "Av. José da Silva, 391",
            028030);

        Console.WriteLine(pessoa.ToString());
        Console.WriteLine(professor2.ToString());
        Console.WriteLine(estudante.ToString() + " - " + "Nota: " + estudante.CalcularMedia(5,9));
        Console.WriteLine(estudante.ToString() + " - " + "Nota: " + "Média ponderada: " + estudante.CalcularMediaPeso(5,9,3,2));
    }
}