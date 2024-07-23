using BusinessObjecs.DTOs;
using BusinessObjecs.Models.FileUpload;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IService;
using System.Net.Mime;
using Firebase.Auth;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {      
        private readonly IFirebaseService _firebaseService;
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _environment;
        IProductService _ProductService;

        public ProductController(IProductService ProductService
            , IFirebaseService firebaseService
            , IWebHostEnvironment environment
            , IConfiguration config)
        {
            _ProductService = ProductService;
            _firebaseService = firebaseService;
            _environment = environment;
            _config = config;
        }

        [HttpPost]
        public async Task<IActionResult> Index(FileUploadModel fileUploadModel)
        {
            if (fileUploadModel.File == null || fileUploadModel.File.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }
            string imgUrl = "";
            try
            {
                var folderName = "productImg";
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "images", folderName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var filePath = Path.Combine(folderPath, fileUploadModel.File.FileName);

                // Save the file temporarily to the server
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await fileUploadModel.File.CopyToAsync(fileStream);
                }

                using (var fileStream = new FileStream(filePath, FileMode.Open))
                {
                   imgUrl = await _firebaseService.Push(fileUploadModel.File, fileStream);
                }

                // Optionally, delete the temporary file after upload
                System.IO.File.Delete(filePath);
                Console.WriteLine("File uploaded successfully.");
                return Ok(imgUrl);
            }
            catch (Exception ex)
            {
                // Log exception details
                Console.WriteLine($"Error uploading file: {ex.Message}");
                return StatusCode(500, "Internal server error.");
            }
        }

        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetById(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.GetById(id, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("getall")]
        public async Task<ActionResult<List<ProductDTO>>> GetAll(CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.GetAll(cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("search-by-name/{name}")]
        public async Task<ActionResult<List<ProductDTO>>> Searchbyname(string name,CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.SearchByName(name,cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("search-by-Category/{id}")]
        public async Task<ActionResult<List<ProductDTO>>> Searchbyname(int id, CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.SearchbyCategory(id, cancellationToken));
        }
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPost("create")]
        public async Task<ActionResult> Create([FromForm] ProductDTO ProductDTO, CancellationToken cancellationToken = default)
        {
            var result = await Index(new FileUploadModel { File = ProductDTO.File });
            if (result is OkObjectResult okResult)
            {
                ProductDTO.ImgUrl = okResult.Value as string;
                return Ok(await _ProductService.Add(ProductDTO, cancellationToken));
            }
            else
            {
                return BadRequest("Error in pushing image"); // Return the error from Index method
            }
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPatch("update/{id}")]
        public async Task<ActionResult<ProductDTO>> Update(string id, [FromForm] ProductDTO ProductDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.Update(id, ProductDTO, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<ProductDTO>> Delete(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.Delete(id, cancellationToken, HttpContext.User));
        }
    }
}
