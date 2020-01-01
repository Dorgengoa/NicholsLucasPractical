import { Component, OnInit, NgModule, Directive } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
})

export class FormComponent {
  http = undefined;
  template = {
    SubmittingAUN: null,
    SchoolYearDate: null,
    PASecureID: null,
    ReportingDate: null,
    ACT16FundCategory: null
  };

  constructor(http: HttpClient) {
    this.http = http;
  }
  onSubmit() {
    if (this.validate()) {
      console.log("There was an issue with validation")
      //tell user submission was unseccessful
    }
    else {
      //tell user submission was successful

      //send to server
      this.http.post('')
    }
    
  }

  validate() {
    let temp = this.template.SubmittingAUN
    if (!temp || temp.toString().length != 9) return true

    temp = this.template.SchoolYearDate
    if (!temp) return true
    
    temp = this.template.PASecureID
    if (!temp || temp.toString().length != 10) return true

    temp = this.template.ReportingDate
    if (!temp) return true

    temp = this.template.ACT16FundCategory
    if(!temp || temp >= 1 || temp <= 4) return true

    return false
  }
}
