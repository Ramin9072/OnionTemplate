using Microsoft.AspNetCore.Mvc;
using Onion.Application.Contract.AtricaleCategory;
using Onion.Domain.ExceptionAgg;
using System.Web.Http;

namespace OnionWebApi.Controllers
{
    [ApiController]
    [System.Web.Http.Route("controller")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            IArticleCategoryApplication articleCategoryApplication)
        {
            _logger = logger;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public IHttpActionResult GetArticleCategory()
        {
            List<ArticleCategoryViewModel> categories = new List<ArticleCategoryViewModel>();
            try
            {
                categories = _articleCategoryApplication.List();
            }
            catch (OnionException)
            {
                throw new OnionException("DONE","200");
            }
            return (IHttpActionResult)Ok(categories);
        }

    }
}