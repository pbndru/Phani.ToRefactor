namespace Phani.StrategyPattern.Services
{
    public class CSharpService: ISqlService
    {
        public string GetLanguage()
        {
            return "Sql Server Database language";
        }
    }
}
