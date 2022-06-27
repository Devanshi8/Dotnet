import { Component, OnInit } from '@angular/core';
import { Product } from "../models/Product";
import { ProductService } from "../services/product.services";
import { UserData } from '../models/UserData';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
 
})
export class DashboardComponent implements OnInit {

  constructor(private _productservice: ProductService) { }

  user: Array<UserData> = new Array<UserData>();
  users:Array<UserData> = new Array<UserData>();
  ngOnInit(): void {
    this._productservice.getProducts().subscribe(res => this.users = res, err => console.log(err))
  }
  
}
