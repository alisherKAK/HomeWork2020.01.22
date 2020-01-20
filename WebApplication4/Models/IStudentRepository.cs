namespace WebApplication4.Models
{
    public interface IStudentRepository<T> : IRepository<T> where T : class, IStudent
    {

    }
}
