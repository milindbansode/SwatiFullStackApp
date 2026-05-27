using SwatiFullStackApp.Api.Catalog;

namespace SwatiFullStackApp.Api.Tests;

public sealed class CatalogServiceTests
{
    private readonly CatalogService _service = new();

    [Fact]
    public void LearningCatalog_ShouldContainSeniorTopicsAcrossMultipleSections()
    {
        var catalog = _service.GetLearningCatalog();

        Assert.Equal("11+ Year Full-Stack Developer Roadmap", catalog.Title);
        Assert.True(catalog.Sections.Count >= 4);
        Assert.True(catalog.Sections.Sum(section => section.Concepts.Count) >= 12);
        Assert.Contains(catalog.Sections.SelectMany(section => section.Concepts), concept => concept.Title.Contains("Authentication", StringComparison.OrdinalIgnoreCase));
    }

    [Fact]
    public void AzureCatalog_ShouldContainCloudPlatformTopics()
    {
        var catalog = _service.GetAzureCatalog();

        Assert.Contains(catalog.Sections.SelectMany(section => section.Concepts), concept => concept.Title.Contains("Key Vault", StringComparison.OrdinalIgnoreCase));
        Assert.Contains(catalog.Sections.SelectMany(section => section.Concepts), concept => concept.Title.Contains("Service Bus", StringComparison.OrdinalIgnoreCase));
    }

    [Fact]
    public void DesignPatternsCatalog_ShouldContainFoundationalPatterns()
    {
        var catalog = _service.GetDesignPatternsCatalog();

        Assert.Contains(catalog.Sections.SelectMany(section => section.Concepts), concept => concept.Title == "Factory");
        Assert.Contains(catalog.Sections.SelectMany(section => section.Concepts), concept => concept.Title == "Decorator");
        Assert.Contains(catalog.Sections.SelectMany(section => section.Concepts), concept => concept.Title == "CQRS");
    }
}
