import { Component, OnInit } from '@angular/core';
import { VegetablesService } from '../shared/vegetables.service';
import { Vegetables } from '../shared/vegetables.model';
import { CartService } from '../shared/cart.service';

@Component({
  selector: 'app-vegetables',
  templateUrl: './vegetables.component.html',
  styleUrls: ['./vegetables.component.css']
})
export class VegetablesComponent implements OnInit {
  vegetables: Vegetables[];
  public final = 0;
  public totalp: number;

  constructor(private vegetableservice: VegetablesService ,
              private cartservice: CartService) {
   }

  ngOnInit() {
    this.vegetableservice.getvegetables().then(res => this.vegetables = res as Vegetables[]);
   }

   addtocart(vegetables) {
    window.alert('Your product has been added to the cart!');
    this.cartservice.addToCart(vegetables);
   }

   increase() {
     this.final += 1;
   }

   decrease() {
     this.final -= 1;
   }

   totalprice(i) {
    this.totalp = (this.vegetables[i].priceperkg * this.final);
   }
  }
