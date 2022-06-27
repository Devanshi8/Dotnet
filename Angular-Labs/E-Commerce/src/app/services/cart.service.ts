import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";
import { Router } from "@angular/router";

import { HttpClient } from "@angular/common/http";
@Injectable({
    providedIn:'root'
})
export class CartService{
    private cartUrl = "https://localhost:44306/api/Cart";
    public cartItemList : any=[]
    public productList=new BehaviorSubject<any>([]);
    
    constructor(private http: HttpClient,private _router:Router){}
    additem(item: any) {
        return this.http.post<any>(this.cartUrl, item);
      }
    getProducts(){
        return this.productList.asObservable();
    }
    setProduct(product:any){
        this.cartItemList.push(...product);
        this.productList.next(product);
    }
    AddCart(product:any){
        this.cartItemList.push(product);
        this.productList.next(this.cartItemList);
        this.getTotalPrice();
    }
    getTotalPrice() : number{
        let grandTotal = 0;
        this.cartItemList.map((a:any)=>{
          grandTotal += a.total;
        })
        return grandTotal;
      }
      removeCartItem(product: any){
        this.cartItemList.map((a:any, index:any)=>{
          if(product.id=== a.id){
            this.cartItemList.splice(index,1);
          }
        })
        this.productList.next(this.cartItemList);
      }
      removeAllCart(){
        this.cartItemList = []
        this.productList.next(this.cartItemList);
      }
}