import { Component, OnInit } from '@angular/core';
import { Product } from "../models/Product";
import { ProductService } from "../services/product.services";
import { HttpClient } from '@angular/common/http';
import { Category } from '../models/Category';
import { ProductComponent } from '../product/product.component';
import { UserData } from '../models/UserData';
import { addcart } from '../models/AddCart';


@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',

})
export class AccountComponent implements OnInit {

  constructor(private _productservice: ProductService, public httpc: HttpClient) { }
  user: UserData = new UserData();

  ngOnInit(): void {
    this._productservice.getProducts().subscribe(res => this.user = res, err => console.log(err))
  }

  order: addcart = new addcart();
  orders: Array<addcart> = new Array<addcart>();
  Ordered() {
    // console.log(this.order);
    // var customerdto={
    //   productName:this.productName,
    //   customerName:this.CustomerModel.customerName,
    //   customerAmount:Number(this.CustomerModel.customerAmount),                
  }

  //     this.httpc.post("https://localhost:44315/api/Customer",customerdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
  //     this.CustomerModel = new Customer();
  // }
  // PostSuccess(res:any){
  //   console.log(res);
  // }
  // PostError(res:any){
  //   console.log(res);
  // }





}






