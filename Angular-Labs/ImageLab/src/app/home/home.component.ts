import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ImageService } from '../services/image.services';
import { Image } from '../models/Image';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private _imageservice: ImageService, public httpc: HttpClient,private _router: Router){} 
  image: Image = new Image();
  images: Array<Image> = new Array<Image>();
  AddImage(){
    console.log(this.image);
    var img={
     
      imageName:this.image.imageName,
      image:this.image.image
    }
    this.httpc.post("https://localhost:44362/api/Image", img).subscribe(res => this.PostSuccess(res), res => this.PostError(res));
    this.image = new Image();
  }
  PostSuccess(res: any) {
    console.log(res);
  }
  PostError(res: any) {
    console.log(res);
  }
  getData() {
    console.log("Hi");
    this.httpc.get("https://localhost:44362/api/Image").subscribe(res => this.GetSuccess(res), res => this.GetError(res));
  }
  GetSuccess(input: any) {
    this.images = input;
  }
  GetError(input: any) {
    console.log(input);
  }



  ngOnInit(): void {
  }

}
