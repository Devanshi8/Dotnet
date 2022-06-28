import { Component, OnInit } from '@angular/core';
import { Product } from "../models/Product";
import { ProductService } from "../services/product.services";
import { UserData } from '../models/UserData';
import { HttpClient } from '@angular/common/http';
import { CartService } from '../services/cart.service';
import { Category } from '../models/Category';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',

})
export class DashboardComponent implements OnInit {

  constructor(private _productservice: ProductService, public httpc: HttpClient, private cartService: CartService) { }

  product: Product = new Product();
  products: Array<Product> = new Array<Product>();
  AddProduct() {
    console.log(this.product);
    var item = {
      productName: this.product.productName,
      productDescription: this.product.productDescription,
      catId: Number(this.product.catId),
      productImage: this.product.productImage,
      productMrp: Number(this.product.productMrp),
      productDiscount: Number(this.product.productDiscount),
      productFinal: Number(this.product.productFinal),
      productQuantity: Number(this.product.productQuantity),



    }

    this.httpc.post("https://localhost:44306/api/Product", item).subscribe(res => this.PostSuccess(res), res => this.PostError(res));
    this.product = new Product();
  }
  PostSuccess(res: any) {
    console.log(res);
  }
  PostError(res: any) {
    console.log(res);
  }


  EditProduct(input: Product) {
    this.product = input;
  }
  DeleteProduct(input: Product) {
    var del = this.products.indexOf(input);
    this.products.splice(del, 1);
  }
  getData() {
    console.log("Hi");
    this.httpc.get("https://localhost:44306/api/Product").subscribe(res => this.GetSuccess(res), res => this.GetError(res));
  }
  GetSuccess(input: any) {
    this.products = input;
  }
  GetError(input: any) {
    console.log(input);
  }

  ngOnInit(): void {
    this._productservice.getProducts().subscribe(res => this.product = res, err => console.log(err))
  }
  // category
  cat: Category = new Category();
  cats: Array<Category> = new Array<Category>();
  AddCategory() {
    console.log(this.cat);
    var catg = {
      catName: this.cat.catName,
    }
    this.httpc.post("https://localhost:44306/api/Category", catg).subscribe(res => this.PostSuccess(res), res => this.PostError(res));
    this.product = new Product();
  }

  user: UserData = new UserData();
  users: Array<UserData> = new Array<UserData>();
  getUserData() {
    console.log(this.user);
    var usdata = {
      userName: this.user.userName,
      address: this.user.address,
      phoneNo: Number(this.user.phoneNo),
      city: this.user.city,
    }
    this.httpc.post("https://localhost:44306/api/Login", this.user).subscribe(res => this.PostSuccess(res), res => this.PostError(res));
    this.product = new Product();
  }

}