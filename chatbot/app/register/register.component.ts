import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { RegisterdetailsService } from '../registerdetails.service';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
registerform: FormGroup;
a: any;
submitted = false;
error: string;
msg: string;
  constructor(private reg: RegisterdetailsService, private router: Router, private formBuilder: FormBuilder, private http: HttpClient) { }

  ngOnInit() {
    this.registerform = this.formBuilder.group({
      firstname : ['', Validators.required],
      lastname : ['', Validators.required],
      email : ['', Validators.required],
      username : ['', Validators.required],
      password : ['', [Validators.required, Validators.minLength(6)]]
    });
}
get f() { return this.registerform.controls; }

onsubmit() {
this.submitted = true;
if (this.registerform.invalid) {
    return;
}
this.http.put('https://jelvtz47mk.execute-api.us-east-2.amazonaws.com/insert/', this.registerform.value).subscribe(
  data => {
    if (data.toString() === 'success') {
    console.log(data);
    this.router.navigate(['/login']);
  } else {
  this.router.navigate(['/']);
  }},
  error => { this.msg = error; }


);

// this.a = this.reg.registerdetails(this.registerform);
  }
}
