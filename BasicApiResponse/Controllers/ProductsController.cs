using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using BasicApiResponse.Models.Responses;
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
            var validateUser = _userService.ValidateUser(userid);
            if (validateUser != null)
            {
                return Content(System.Net.HttpStatusCode.BadRequest, validateUser);
            }

            UserProductsResponse userProduct = _userProductBankAccountService.GetProductsByUserId(userid);

            return Ok(userProduct);
        }

        [Route("{productid:int:range(100,999)}", Name = "GetBankAccountsByProductId")]
        public IHttpActionResult GetBankAccountsByProductId(string userid, int productid)
        {
            var validateUser = _userService.ValidateUser(userid);
            if (validateUser != null)
            {
                return Content(System.Net.HttpStatusCode.BadRequest, validateUser);
            }

            var validateProduct = _productService.ValidateProduct(productid);
            if (validateProduct != null)
            {
                return Content(System.Net.HttpStatusCode.BadRequest, validateProduct);
            }

            ProductBankAccountsResponse productBankAccount = _userProductBankAccountService.GetBankAccountsByProductId(userid, productid);

            var link = new LinkHelper<ProductBankAccountsResponse>(productBankAccount);
            link.Links.Add(new HyperMediaLink(Url.Link("GetProductsByUserId", null), "SELF", Request.Method.ToString()));
            return Ok(link);
        }
    }
}