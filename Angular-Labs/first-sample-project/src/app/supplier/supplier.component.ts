import { Component, OnInit } from '@angular/core';
import { Supplier } from './supplier.model';

@Component({
  
  templateUrl: './supplier.component.html'
})
export class SupplierComponent {

  title = 'first-sample-project';
  myname = 'Devanshi'
  SupplierModel: Supplier = new Supplier();
  SupplierModels: Array<Supplier> = new Array<Supplier>();
  AddSupplier() {
    this.SupplierModels.push(this.SupplierModel);
    this.SupplierModel = new Supplier();
  }
  EditSupplier(input: Supplier) {
    this.SupplierModel = input;
  }
  DeleteSupplier(input: Supplier) {
    var del = this.SupplierModels.indexOf(input);
    this.SupplierModels.splice(del, 1);
  }

}
