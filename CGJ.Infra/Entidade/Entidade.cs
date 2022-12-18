namespace CGJ.Infra.Entidade
{
    public abstract class Entidade<T>
    {
        public virtual T Codigo { get; set; }
    }
}