import { FilmeDetalhePageModule } from './../filme-detalhe/filme-detalhe.module';
import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { HomePage } from './home.page';

const routes: Routes = [
  {
    path: 'home',
    loadChildren: () => import('./home/home.module').then(m => m.HomePage)
  },
  {
    path: 'filme-detalhe/:id',
    loadChildren: () => import ('./filme-detalhe/filme-detalhe.module').then( m => m.FilmeDetalhePageModule)

  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomePageRoutingModule {}
