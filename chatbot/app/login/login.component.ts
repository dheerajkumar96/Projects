import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Form, Validators } from '@angular/forms';
import { RegisterdetailsService } from '../registerdetails.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
login: FormGroup;
submitted = false;
test: any;
message: string;
  constructor(private formbuilder: FormBuilder, private logmsg: RegisterdetailsService, private r: Router) { }

  ngOnInit() {
    this.login = this.formbuilder.group({
      username : ['', Validators.required],
      password : ['', Validators.required]
    });
  }
  get f() { return this.login.controls; }
checkdet() {
  this.submitted = true;
  if (this.login.invalid) {
    return;
}
  this.message = this.logmsg.logincheck();
  if (this.message === 'a') {
        this.r.navigate(['/chatbot']);
      } else {
        this.r.navigate(['/register']);
      }
  this.test = this.login.value;
    }
}
