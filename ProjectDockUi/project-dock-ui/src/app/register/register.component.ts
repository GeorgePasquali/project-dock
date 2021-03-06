import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { AuthService } from "../auth.service";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {

  /**
   * The form to submit on the frontend side.
   */
  protected form;


  /**
   * Create a form and validate with various rules (non-empty and matching passwords)
   * @param fb form builder
   */
  constructor(private fb: FormBuilder, private auth: AuthService) {
    this.form = fb.group({

      // Validator that requires controls to have a non-empty value. (Validators.required)

      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, emailValid()]],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required]
    }, { // validate our matching password
      validator: matchingFields('password', 'confirmPassword')
    })
  }

  /**
   * This action triggers on submit
   */
  onSubmit() {
    console.log(this.form.errors);
    this.auth.register(this.form.value)
  }

  /**
   * See if the field is filled.
   * @param control the field control
   */
  isValid(control){
    return this.form.controls[control].invalid && this.form.controls[control].touched;
  }

  ngOnInit() {
  }
}

/**
 * This function checks if the two parameters are matching
 * @param field1 Field one
 * @param field2 field two
 */
function matchingFields(field1, field2){
  return form => {
    if(form.controls[field1].value !== form.controls[field2].value)
      return { mismatchedFields: true}
  }
}

/**
 * Test the email against the REGEX
 */
function emailValid(){
  return control => {
    let regex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    
    // If mismatch return an error object
    return regex.test(control.value) ? null : { invalidEmail: true}
  }
}