using System;

public class cliente
{
    public string cpf { set; get; }
    public string nomeCompleto { set; get; }
    public int idade { set; get; }
    public void salvar()
    {
        if (idade >= 18)
        {
            Console.WriteLine("Salvando...");
        }
        else
        {
            Console.WriteLine("não rola...");
        }


    }
}