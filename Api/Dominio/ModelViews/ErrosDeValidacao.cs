namespace MinimalApi.Dominio.ModelViews;

public struct ErrosDeValidacao
{
    public List<string> Mensagens { get; set; }
    public string Doc { get => "/swagger/index.html"; }
}