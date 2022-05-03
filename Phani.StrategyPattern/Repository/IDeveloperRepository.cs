namespace Phani.StrategyPattern.Repository
{
    public interface IDeveloperRepository
    {
        public LanguageEntity GetDeveloperDetails(string id);
    }
}