import {HttpClient} from '@angular/common/http';
import { Component } from '@angular/core';
import { VirtualTimeScheduler } from 'rxjs';
import { UserDetails } from './user.model';

@Component({
  
  templateUrl: './user.component.html'
  
})
export class UserComponent {

  constructor (public httpc:HttpClient){}

  title = 'ECommerceWebsite';
  myname = 'Devanshi'
  UserModel: UserDetails = new UserDetails();
  UserModels: Array<UserDetails> = new Array<UserDetails>();
  AddUser() 
  {
    
    console.log(this.UserModel);
    var userdto={
      id:Number(this.UserModel.id),
      userId:this.UserModel. userId,
      userName:this.UserModel.userName,  
      userAddress:this.UserModel.userAddress
              
    }
  
      this.httpc.post("https://localhost:44306/api/User",userdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
      this.UserModel = new UserDetails();
  }
  PostSuccess(res:any){
    console.log(res);
  }
  PostError(res:any){
    console.log(res);
  }

    
  EditUser(input: UserDetails) {
    this.UserModel = input;
  }
  DeleteUser(input: UserDetails) {
    var del = this.UserModels.indexOf(input);
    this.UserModels.splice(del,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44306/api/User").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.UserModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
  
}


