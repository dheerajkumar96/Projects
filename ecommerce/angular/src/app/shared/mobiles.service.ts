import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MobilesService {

  constructor(private http: HttpClient) { }

  getmobiles() {
    return this.http.get('http://localhost:56488/api' + '/mobiles').toPromise();
  }
}
