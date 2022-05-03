using Phani.StrategyPattern.Enums;

namespace Phani.StrategyPattern.Repository
{
    public class DeveloperRepository: IDeveloperRepository
    {
        public LanguageEntity GetDeveloperDetails(string id)
        {
            return new LanguageEntity
            {
                Id = "170a0a76-1219-443e-a369-6e7811bc2118",
                LanguageType = LanguageType.CSharp
            };
        }
    }
}
