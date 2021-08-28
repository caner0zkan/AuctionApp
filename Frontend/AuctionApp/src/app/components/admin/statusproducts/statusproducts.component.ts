import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-statusproducts',
  templateUrl: './statusproducts.component.html',
  styleUrls: ['./statusproducts.component.css']
})
export class StatusproductsComponent implements OnInit {

  items: any;
  constructor(private http: HttpClient) {
    http.get("http://localhost:58426/api/auctions")
      .subscribe(response=> {
        this.items = response;
        console.log(response);
      })
  }

  ngOnInit(): void {
  }

}
