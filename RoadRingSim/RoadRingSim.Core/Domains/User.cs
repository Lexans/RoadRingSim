
namespace RoadRingSim.Core.Domains
{

    /// <summary>
    /// модель пользователя
    /// </summary>
    public class User:DomainObject
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
