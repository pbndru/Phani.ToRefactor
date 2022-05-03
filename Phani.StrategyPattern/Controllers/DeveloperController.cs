using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phani.StrategyPattern.Enums;
using Phani.StrategyPattern.Models;
using Phani.StrategyPattern.Repository;
using Phani.StrategyPattern.Services;

namespace Phani.StrategyPattern.Controllers
{
    [ApiController]
    [Route("[developers]")]
    public class DeveloperController : ControllerBase
    {
        private readonly ILogger<DeveloperController> _logger;
        private readonly IDeveloperRepository _developerRepository;
        private readonly ICSharpService _csharpService;
        private readonly ISqlService _sqlService;

        public DeveloperController(ILogger<DeveloperController> logger,
                                    IDeveloperRepository developerRepository,
                                    ICSharpService csharpService,
                                    ISqlService sqlService)
        {
            _logger = logger;
            _developerRepository = developerRepository;
            _csharpService = csharpService;
            _sqlService = sqlService;
        }

        [HttpGet("{id}/developers")]
        public ActionResult<Language> GetPromotionToken(string id)
        {
            var details = _developerRepository.GetDeveloperDetails(id);
            var response = new Language();
            switch (details.LanguageType)
            {
                case LanguageType.CSharp:
                    response.Result = _csharpService.GetLanguage();
                    break;
                case LanguageType.Sql:
                    response.Result = _sqlService.GetLanguage();
                    break;
            }

            return response;
        }
    }
}
