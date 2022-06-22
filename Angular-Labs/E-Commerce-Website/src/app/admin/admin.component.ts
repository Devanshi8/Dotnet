import {HttpClient} from '@angular/common/http';
import { Component } from '@angular/core';
import { Admin } from './admin.model';

@Component({
  
  templateUrl: './admin.component.html'
  
})
export class AdminComponent{

  constructor (public httpc:HttpClient){}

  title = 'ECommerceWebsite';
  myname = 'Devanshi'
  AdminModel: Admin = new Admin();
  AdminModels: Array<Admin> = new Array<Admin>();
  AddProduct(){}
  AddCategory(){}
  AddAdmin() 
  {
    
    console.log(this.AdminModel);
    var admindto={
      id:Number(this.AdminModel.id),
      adminID:this.AdminModel.adminID,
      adminName:this.AdminModel.adminName,         
    }
  
      this.httpc.post("https://localhost:44306/api/Admin",admindto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
      this.AdminModel = new Admin();
  }
  PostSuccess(res:any){
    console.log(res);
  }
  PostError(res:any){
    console.log(res);
  }

    
  EditAdmin(input: Admin) {
    this.AdminModel = input;
  }
  DeleteAdmin(input: Admin) {
    var del = this.AdminModels.indexOf(input);
    this.AdminModels.splice(del,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44306/api/Admin").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.AdminModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
  
}


