import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  form;
  constructor(private fb: FormBuilder) {
    this.form = fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', Validators.required],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required]
    }, {
      validator: matchingFields('password', 'confirmPassword')
    })
  }

  onSubmit() {
    console.log(this.form.errors);
  }

  isValid(control){
    return this.form.controls[control].invalid && this.form.controls[control].touched;
  }

  ngOnInit() {
  }
}

function matchingFields(field1, field2){
  return form => {
    if(form.controls[field1].value !== form.controls[field2].value)
      return { mismatchedFields: true}
  }
}