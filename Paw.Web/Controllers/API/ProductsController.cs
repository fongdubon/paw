namespace Paw.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Paw.Web.Data;

    [Route("api/[Controller]")]
    public class ProductsController:Controller
    {
        private readonly DataContext dataContext;

        public ProductsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            //TODO
            return Ok(this.dataContext.Products);
        }
    }
}
