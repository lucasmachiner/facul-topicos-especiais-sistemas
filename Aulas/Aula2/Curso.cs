public class Curso
{
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public string Area { get; set; }
    //TODO -> Alterar turma para classe de Turmas quando existir 
    // a classe
    public List<string> Turmas { get; set; }
    public string exibirInformacoes()
    {
        return "";
    }
    public void adicioinarTurma()
    {

    }
}