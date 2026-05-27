export interface ConceptCard {
  title: string;
  simpleExplanation: string;
  practicalExample: string;
  seniorFocus: string;
  keySkills: string[];
}

export interface CatalogSection {
  id: string;
  title: string;
  summary: string;
  concepts: ConceptCard[];
}

export interface CatalogResponse {
  title: string;
  subtitle: string;
  sections: CatalogSection[];
  suggestedProjects: string[];
}
