import { Component } from '@angular/core';
import { Customer } from './customer.model';

@Component({
  
  templateUrl: './customer.component.html'
  
})
export class CustomerComponent {
  title = 'first-sample-project';
  myname = 'Devanshi'
  CustomerModel: Customer = new Customer();
  CustomerModels: Array<Customer> = new Array<Customer>();
  AddCustomer() 
  {
    this.CustomerModels.push(this.CustomerModel);
    this.CustomerModel=new Customer();
  }
  EditCustomer(input: Customer) {
    this.CustomerModel = input;
  }
  DeleteCustomer(input: Customer) {
    var del = this.CustomerModels.indexOf(input);
    this.CustomerModels.splice(del,1);
  }
}
