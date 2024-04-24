public class Universidade
{
    public string Nome { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
    //TODO -> alterar tipo do curso para a classe de curso 
    // quando existir a classe de curso
    // public List<Curso> Cursos { get; set; }
    public List<Curso> Cursos = new List<Curso>();
    public string exibirInformacoes()
    {
        return "";
    }

    //Metodo que recebe curso e adiciona na lista de cursos
    public void adicionarCurso(Curso curso)
    {
        this.Cursos.Add(curso);
    }

    public List<Curso> getCursos()
    {
        return this.Cursos;
    }
}