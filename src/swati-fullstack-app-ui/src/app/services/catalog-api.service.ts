import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';

import { CatalogResponse } from '../models/catalog.models';

@Injectable({ providedIn: 'root' })
export class CatalogApiService {
  private readonly http = inject(HttpClient);
  private readonly baseUrl = '/api/catalog';

  getLearningCatalog(): Observable<CatalogResponse> {
    return this.http.get<CatalogResponse>(`${this.baseUrl}/learning`);
  }

  getAzureCatalog(): Observable<CatalogResponse> {
    return this.http.get<CatalogResponse>(`${this.baseUrl}/azure`);
  }

  getDesignPatternsCatalog(): Observable<CatalogResponse> {
    return this.http.get<CatalogResponse>(`${this.baseUrl}/design-patterns`);
  }
}
