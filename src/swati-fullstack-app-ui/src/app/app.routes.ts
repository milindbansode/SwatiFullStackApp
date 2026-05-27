import { Routes } from '@angular/router';

import { CatalogPageComponent } from './pages/catalog-page.component';

export const routes: Routes = [
  {
    path: '',
    component: CatalogPageComponent,
    data: { catalogType: 'learning' }
  },
  {
    path: 'azure',
    component: CatalogPageComponent,
    data: { catalogType: 'azure' }
  },
  {
    path: 'design-patterns',
    component: CatalogPageComponent,
    data: { catalogType: 'design-patterns' }
  },
  {
    path: '**',
    redirectTo: ''
  }
];
