import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ImageService {
  private _imageUrl = "https://localhost:44362/api/Image";
  constructor(private http: HttpClient, private _router: Router) { }


  getImages() {
    return this.http.get<any>(this._imageUrl);
  }
}