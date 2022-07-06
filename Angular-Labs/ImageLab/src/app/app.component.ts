import { Component } from '@angular/core';
import { Image } from './models/Image';
import { ImageService } from './services/image.services';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  
})
export class AppComponent {
  title = 'ImageLab';
  constructor(private _imageservice: ImageService, public httpc: HttpClient,private _router: Router){} 

}
