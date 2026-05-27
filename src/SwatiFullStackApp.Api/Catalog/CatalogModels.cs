namespace SwatiFullStackApp.Api.Catalog;

public sealed record ConceptCard(
    string Title,
    string SimpleExplanation,
    string PracticalExample,
    string SeniorFocus,
    IReadOnlyList<string> KeySkills);

public sealed record CatalogSection(
    string Id,
    string Title,
    string Summary,
    IReadOnlyList<ConceptCard> Concepts);

public sealed record CatalogResponse(
    string Title,
    string Subtitle,
    IReadOnlyList<CatalogSection> Sections,
    IReadOnlyList<string> SuggestedProjects);
