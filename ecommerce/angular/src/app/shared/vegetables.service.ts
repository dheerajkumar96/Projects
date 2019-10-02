import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class VegetablesService {

  constructor(private http: HttpClient) { }

  getvegetables() {
    return this.http.get('http://localhost:56488/api' + '/vegetables').toPromise();
  }
}
