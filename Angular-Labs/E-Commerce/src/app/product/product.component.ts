import { Component, OnInit } from '@angular/core';
import { Product } from "../models/Product";
import { ProductService } from "../services/product.services";
import { Category } from '../models/Category';
import { HttpClient } from '@angular/common/http';
import { CartService } from '../services/cart.service';
import { addcart } from '../models/AddCart';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
 
})
export class ProductComponent implements OnInit {
  constructor(private _productservice: ProductService,public httpc:HttpClient,private cartService : CartService) { }
  product: Product = new Product();
  products: Array<Product> = new Array<Product>();
  ngOnInit(): void {
    this._productservice.getProducts().subscribe(res => this.products = res, err => console.log(err))
    
  }
  AddCart(product:any){
    console.log(this.product);
    this.cartService.AddCart(product);
   
  }
  
 
}