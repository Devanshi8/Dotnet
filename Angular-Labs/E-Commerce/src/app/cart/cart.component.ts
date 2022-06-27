import { Component, OnInit } from '@angular/core';
import { Product } from "../models/Product";
import { ProductService } from "../services/product.services";
import { HttpClient } from '@angular/common/http';
import { Category } from '../models/Category';
import { CartService } from '../services/cart.service';
import { addcart } from '../models/AddCart';



@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
  
  
})
export class CartComponent implements OnInit {
  public products : any = [];
  public grandTotal !: number;
  constructor(private cartService : CartService) { }
  item: addcart = new addcart();
  items: Array<addcart> = new Array<addcart>();

  ngOnInit(): void {
    this.cartService.getProducts()
    .subscribe(res=>{
      this.products = res;
      this.grandTotal = this.cartService.getTotalPrice();
    })
  }
  removeItem(item: any){
    this.cartService.removeCartItem(item);
  }
  emptycart(){
    this.cartService.removeAllCart();
  }
  addcart(){
    var tbdata={
      productName:this.item.productName,
      productFinal:this.item.productFinal,
      productImage:this.item.productImage,
      productDescription:this.item.productDescription,
      productQuantity:this.item.productQuantity,
    }
  }
}
// AddCart() 
  // {
  //   console.log(this.product);
  //   var productdto={
  //     // productImage:this.product.productImage,
  //     productName:this.product.productName,
  //     productFinal:this.product.productFinal,
  //     productImage:this.product.productImage,
  //     productDescription:this.product.productDescription,
  //     productQuantity:this.product.productQuantity,
  //     productDiscount:this.product.productDiscount,
      
      
                
  //   }
  
  //     this.httpc.post("https://localhost:44306/api/Product",productdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
  //     this.product = new Product();
  // }
  // PostSuccess(res:any){
  //   console.log(res);
  // }
  // PostError(res:any){
  //   console.log(res);
  // }

// var getdata={
//   console.log(this.item);
  
      // productImage:this.product.productImage,
      // productName:this.product.productName,
      // productFinal:this.product.productFinal,
      // productImage:this.product.productImage,
      // productDescription:this.product.productDescription,
      // productQuantity:this.product.productQuantity,
    
// }