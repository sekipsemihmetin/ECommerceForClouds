using AutoMapper;
using BLL.Abstract_Services;
using BLL.AllDtos;
using ECommerceForClouds.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceForClouds.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IUserBasketService _userBasketService;

        public ProductController(IProductService productService,IMapper mapper,IUserBasketService userBasketService)
        {
            _productService = productService;
            _mapper = mapper;
           _userBasketService = userBasketService;
        }
        public async Task<IActionResult> Index()
        {
            var allProducts = _mapper.Map<List<ProductViewModel>>(await _productService.GelAllProductsAsync());
            return View(allProducts);
        }
        [HttpPost]
        public async Task<IActionResult> AddToBasket(int productId,int userId)
        {
            var userBasket = new UserBasketViewModel()
            {
                UserId = userId,
                ProductId=productId,
            };
          await  _userBasketService.AddUserBasketAsync(_mapper.Map<UserBasketDto>(userBasket));
            
           return RedirectToAction("Index",userBasket);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                string? photUrl = null;
                if (productViewModel.Photo!=null)
                {
                    var filePath = Path.Combine("wwwroot/images", productViewModel.Photo.FileName);
                    using (var stream=new FileStream(filePath,FileMode.Create))
                    {
                        await productViewModel.Photo.CopyToAsync(stream);
                    }
                    productViewModel.PhotoUrl = $"images/{productViewModel.Photo.FileName}";

                }
                await _productService.AddProductAsync(_mapper.Map<ProductDto>(productViewModel));

                return RedirectToAction("Index");
            }
            return View(productViewModel);
        }

    }
}
