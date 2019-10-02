import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductspageComponent } from './productspage/productspage.component';
import { VegetablesComponent } from './vegetables/vegetables.component';
import { CarsComponent } from './cars/cars.component';
import { TshirtsComponent } from './tshirts/tshirts.component';
import { MobilesComponent } from './mobiles/mobiles.component';
import { CartComponent } from './cart/cart.component';
import { TopbarComponent } from './topbar/topbar.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    ProductspageComponent,
    VegetablesComponent,
    CarsComponent,
    TshirtsComponent,
    MobilesComponent,
    CartComponent,
    TopbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
