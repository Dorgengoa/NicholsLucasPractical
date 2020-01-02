import { Component, OnInit, NgModule, Directive, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
})

export class FormComponent {
  http = undefined;
  baseUrl = undefined;
  success: boolean = false;
  failure: boolean = false;
  template = {
    SubmittingAUN: null,
    SchoolYearDate: null,
    PASecureID: null,
    ReportingDate: null,
    Collection: "ACT16",
    MeasureType: "COUNT",
    ACT16FundCategory: null
  };

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }
  onSubmit() {
    if (this.validate()) {
      //tell user submission was unsuccessful
      this.failure = true
      this.success = false
    }
    else {
      //tell user submission was successful
      this.failure = false
      this.success = true;
      setTimeout(() => {
        this.success = false
      }, 3000)

      //send to server
      this.http.post(this.baseUrl + 'form', this.template).subscribe(result => {
        
      }, error => console.error(error));
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
    if (!temp || temp < 1 || temp > 4) {
      console.log("test");
      return true
    }
    return false
  }

  selectAllContent($event) {
    $event.target.select();
  }
}
