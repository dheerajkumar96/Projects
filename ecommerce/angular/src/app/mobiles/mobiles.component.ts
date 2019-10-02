import { Component, OnInit } from '@angular/core';
import { Mobiles } from '../shared/mobiles.model';
import { MobilesService } from '../shared/mobiles.service';

@Component({
  selector: 'app-mobiles',
  templateUrl: './mobiles.component.html',
  styleUrls: ['./mobiles.component.css']
})
export class MobilesComponent implements OnInit {
  mobiles: Mobiles[];

  constructor(private mobileservice: MobilesService) { }

  ngOnInit() {
    this.mobileservice.getmobiles().then(res => this.mobiles = res as Mobiles[]);
  }

}
