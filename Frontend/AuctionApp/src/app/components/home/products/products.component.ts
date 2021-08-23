import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

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
