using Microsoft.AspNetCore.Mvc;
using SwatiFullStackApp.Api.Catalog;

namespace SwatiFullStackApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class CatalogController(ICatalogService catalogService) : ControllerBase
{
    [HttpGet("learning")]
    public ActionResult<CatalogResponse> GetLearningCatalog() => Ok(catalogService.GetLearningCatalog());

    [HttpGet("azure")]
    public ActionResult<CatalogResponse> GetAzureCatalog() => Ok(catalogService.GetAzureCatalog());

    [HttpGet("design-patterns")]
    public ActionResult<CatalogResponse> GetDesignPatternsCatalog() => Ok(catalogService.GetDesignPatternsCatalog());
}
