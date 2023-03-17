namespace ListaTareas.Models.Tareas
{
    public interface IRepositorioTareas
    {
        List<TareaViewModel> ObtenerTareas();
    }
}