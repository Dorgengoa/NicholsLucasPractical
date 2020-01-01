import { Component, OnInit, NgModule, Directive } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
})

export class FormComponent {
  http = undefined;
  template = { };

  constructor(http: HttpClient) {
    this.http = http;
  }
  onSubmit() {
    console.log(this.template);
  }
}
