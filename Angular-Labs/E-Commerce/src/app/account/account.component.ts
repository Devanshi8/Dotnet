import { Component, OnInit } from '@angular/core';
import { Product } from "../models/Product";
import { ProductService } from "../services/product.services";
import { HttpClient } from '@angular/common/http';
import { Category } from '../models/Category';
import { ProductComponent } from '../product/product.component';
import { UserData } from '../models/UserData';


@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {

  constructor(private _productservice: ProductService, public httpc: HttpClient) { }
  user: UserData = new UserData();
  
  ngOnInit(): void {
    this._productservice.getProducts().subscribe(res => this.user = res, err => console.log(err))
  }
  
   
     
     
    
  }
  
 




