import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Supplier } from './supplier.model';

@Component({
  
  templateUrl: './supplier.component.html'
})
export class SupplierComponent {

  constructor (public httpc:HttpClient){}
  
  title = 'first-sample-project';
  myname = 'Devanshi'
  SupplierModel: Supplier = new Supplier();
  SupplierModels: Array<Supplier> = new Array<Supplier>();
  AddSupplier() {
    console.log(this.SupplierModel);
    var supplierdto={
      customerCode:this.SupplierModel.supplierCode,
      cutomerName:this.SupplierModel.supplierName,
      customerAmount:Number(this.SupplierModel.supplierAmount)                
    }
  
      this.httpc.post("https://localhost:44315/api/Supplier",supplierdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
      this.SupplierModel = new Supplier();
  }
  PostSuccess(res:any){
    console.log(res);
  }
  PostError(res:any){
    console.log(res);
  }

  EditSupplier(input: Supplier) {
    this.SupplierModel = input;
  }
  DeleteSupplier(input: Supplier) {
    var del = this.SupplierModels.indexOf(input);
    this.SupplierModels.splice(del, 1);
  }

  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44315/api/Supplier").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.SupplierModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
  

}
