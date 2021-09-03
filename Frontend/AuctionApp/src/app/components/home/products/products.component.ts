import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { analyzeNgModules } from '@angular/compiler';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  items: any;
  selectedItem: any;

  constructor(private http: HttpClient) {
    http.get("http://localhost:58426/api/auctions")
      .subscribe(response=> {
        this.items = response;
        console.log(response);
      })
  }

  detailItem(item: JSON){
    this.selectedItem = item;
  }

  ngOnInit(): void {
  }

}
