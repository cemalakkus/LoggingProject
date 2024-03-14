using CQRSProject.Application.Feature.Product.Commands.CreateProduct;
using CQRSProject.Application.Feature.Product.Commands.DeleteProduct;
using CQRSProject.Application.Feature.Product.Commands.UpdateProduct;
using CQRSProject.Application.Feature.Product.Queries.GetAllProducts;
using CQRSProject.Application.Feature.Product.Queries.GetPagedAllProducts;
using CQRSProject.Application.Feature.Product.Queries.GetProductById;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : BaseApiController
{

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        return Ok(await Mediator.Send(new GetProductByIdQuery() { Id = id }));
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await Mediator.Send(new GetAllProductsQuery()));
    }

    [HttpGet("GetPagedAll")]
    public async Task<IActionResult> GetPagedAll([FromQuery] GetPagedAllProductsQuery query)
    {
        return Ok(await Mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromHeader]string user,CreateProductCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, UpdateProductCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        return Ok(await Mediator.Send(command));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await Mediator.Send(new DeleteProductCommand { Id = id }));
    }
}
