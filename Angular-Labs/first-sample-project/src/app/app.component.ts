import { Component } from '@angular/core';
import { Customer } from './app.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
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
