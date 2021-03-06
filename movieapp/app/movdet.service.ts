import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MovdetService {

  constructor(private http: HttpClient) { }

  getmoviedet(): Observable<any> {
    return this.http.get<any>('assets/movies.json');
  }
}
