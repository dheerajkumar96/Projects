import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CarsComponent } from './cars/cars.component';
import { MobilesComponent } from './mobiles/mobiles.component';
import { TshirtsComponent } from './tshirts/tshirts.component';
import { VegetablesComponent } from './vegetables/vegetables.component';
import { ProductspageComponent } from './productspage/productspage.component';
import { CartComponent } from './cart/cart.component';


const routes: Routes = [
  { path: '', redirectTo: 'productspage', pathMatch: 'full'},
  {path: 'cars', component: CarsComponent},
  {path: 'mobiles', component: MobilesComponent},
  {path: 'tshirts', component: TshirtsComponent},
  {path: 'vegetables', component: VegetablesComponent},
  {path: 'productspage', component: ProductspageComponent},
  {path: 'cart', component: CartComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingcomponents = [CarsComponent, MobilesComponent, TshirtsComponent, VegetablesComponent, ProductspageComponent];
