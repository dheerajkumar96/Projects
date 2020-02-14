import { Component, OnInit } from '@angular/core';
import { MovdetService } from '../movdet.service';

@Component({
  selector: 'app-moviedis',
  templateUrl: './moviedis.component.html',
  styleUrls: ['./moviedis.component.css']
})
export class MoviedisComponent implements OnInit {
searchtext;
public details: any = [];

  constructor(private srv: MovdetService) { }

  ngOnInit() {
  this.srv.getmoviedet().subscribe(data => {
    this.details = data;
  });
  }
}
