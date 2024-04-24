public class ave : animal
{
    public string tipo_plumage;
    override
    public string somEmitido()
    {
        string retorno = base.somEmitido() + "gorjeia";
        return retorno;
    }

}