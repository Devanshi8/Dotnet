import {HttpClient} from '@angular/common/http';
import { Component } from '@angular/core';
import { Product } from './product.model';

@Component({
  
  templateUrl: './product.component.html'
  
})
export class ProductComponent {

  constructor (public httpc:HttpClient){}

  title = 'ECommerceWebsite';
  myname = 'Devanshi'
  ProductModel: Product = new Product();
  ProductModels: Array<Product> = new Array<Product>();
  AddProduct() 
  {
    
    console.log(this.ProductModel);
    var productdto={
      id:Number(this.ProductModel.id),
      productID:this.ProductModel.productID,
      productName:this.ProductModel.productName,  
      category:this.ProductModel.category,             
    }
  
      this.httpc.post("https://localhost:44306/api/Product",productdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
      this.ProductModel = new Product();
  }
  PostSuccess(res:any){
    console.log(res);
  }
  PostError(res:any){
    console.log(res);
  }

    
  EditProduct(input: Product) {
    this.ProductModel = input;
  }
  DeleteProduct(input: Product) {
    var del = this.ProductModels.indexOf(input);
    this.ProductModels.splice(del,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("hhttps://localhost:44306/api/Product").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.ProductModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
  
}


