import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-csv',
  templateUrl: './csv.component.html'
})
export class CSVComponent {
  http = undefined
  baseUrl = undefined
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }
  export() {
    this.http.get(this.baseUrl + 'csv').subscribe(result => {
      console.log(result)
      console.log("Test");
    }, error => location.reload());
  }
}
