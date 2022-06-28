import { Component, OnInit } from '@angular/core';
import { Product } from "../models/Product";
import { ProductService } from "../services/product.services";
import { CartService } from '../services/cart.service';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  searchKey: string = "";
  constructor(private _productservice: ProductService, public httpc: HttpClient, private cartService: CartService, private _router: Router) { }
  product: Product = new Product();
  products: Array<Product> = new Array<Product>();
  ngOnInit(): void {
    //this._productservice.getProducts().subscribe(res => this.products = res, err => console.log(err))
    this._productservice.getProducts().subscribe(res => this.products = res, err => console.log(err))
    this.cartService.search.subscribe((val: any) => {
      this.searchKey = val;
    })
  }

}


