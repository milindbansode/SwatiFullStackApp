import { AsyncPipe, NgClass } from '@angular/common';
import { Component, inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

import { CatalogResponse } from '../models/catalog.models';
import { CatalogApiService } from '../services/catalog-api.service';

type CatalogKind = 'learning' | 'azure' | 'design-patterns';

interface CatalogViewModel {
  catalog: CatalogResponse | null;
  error: string | null;
}

@Component({
  selector: 'app-catalog-page',
  imports: [AsyncPipe, NgClass],
  templateUrl: './catalog-page.component.html',
  styleUrl: './catalog-page.component.css'
})
export class CatalogPageComponent {
  private readonly route = inject(ActivatedRoute);
  private readonly catalogApi = inject(CatalogApiService);

  protected readonly viewModel$: Observable<CatalogViewModel> = this.loadCatalog();

  private loadCatalog(): Observable<CatalogViewModel> {
    const catalogType = (this.route.snapshot.data['catalogType'] as CatalogKind | undefined) ?? 'learning';

    const request =
      catalogType === 'azure'
        ? this.catalogApi.getAzureCatalog()
        : catalogType === 'design-patterns'
          ? this.catalogApi.getDesignPatternsCatalog()
          : this.catalogApi.getLearningCatalog();

    return request.pipe(
      map((catalog) => ({ catalog, error: null })),
      catchError(() =>
        of({
          catalog: null,
          error: 'Unable to load the catalog right now. Start the ASP.NET Core API and refresh the page.'
        })
      )
    );
  }
}
