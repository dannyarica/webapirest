using BasicApiResponse.Services;
using System.Web.Http;

namespace BasicApiResponse.Controllers
{
    [RoutePrefix("api/v1/users/{userid:length(10)}/products")]
    public class ProductsController : ApiController
    {
        private IUserService _userService;
        private IProductService _productService;
        private IUserProductBankAccountService _userProductBankAccountService;

        public ProductsController(IUserService userService,
                                  IProductService productService,
                                  IUserProductBankAccountService userProductBankAccountService)
        {
            _userService = userService;
            _productService = productService;
            _userProductBankAccountService = userProductBankAccountService;
        }

        [Route("", Name = "GetProductsByUserId")]
        public IHttpActionResult GetProductsByUserId(string userid)
        {
            var userProduct = _userProductBankAccountService.GetProductsByUserId(userid);

            return Ok(userProduct);
        }

        [Route("{productid:int:range(100,999)}", Name = "GetBankAccountsByProductId")]
        public IHttpActionResult GetBankAccountsByProductId(string userid, int productid)
        {
            var productBankAccount = _userProductBankAccountService.GetBankAccountsByProductId(userid, productid);
            return Ok(productBankAccount);
        }
    }
}