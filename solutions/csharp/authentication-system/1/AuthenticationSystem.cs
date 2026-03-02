using System.Collections.ObjectModel;
using System.Linq; 
public class Authenticator
{
    // 1. Константы для цветов глаз (лучше вынести в отдельный класс или Enum)
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    // 2. Поля делаем readonly, чтобы их нельзя было подменить целиком
    private readonly Identity admin;
    private readonly IDictionary<string, Identity> developers;

    public Authenticator(Identity admin)
    {
        this.admin = admin;
        
        // 3. Инициализируем словарь здесь
        developers = new Dictionary<string, Identity>
        {
            ["Bertrand"] = new Identity { Email = "bert@ex.ism", EyeColor = EyeColor.Blue },
            ["Anders"] = new Identity { Email = "anders@ex.ism", EyeColor = EyeColor.Brown }
        };
    }

    // 4. Свойство Admin (только для чтения)
    public Identity Admin => admin;

    // 5. ГЛАВНОЕ: Возвращаем зазищенную копию словаря
   public IDictionary<string, Identity>  GetDevelopers() 
    => developers.AsReadOnly(); 
}
public struct Identity // Если это структура
{
    
    public string Email { get; set ;}
    public string EyeColor { get; init ;}
}
