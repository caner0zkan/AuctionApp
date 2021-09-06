import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-updateproduct',
  templateUrl: './updateproduct.component.html',
  styleUrls: ['./updateproduct.component.css']
})
export class UpdateproductComponent implements OnInit {

  constructor(private activatedRoute: ActivatedRoute, private http: HttpClient) { }

  param: any;
  items: any;
  ngOnInit() {
    this.activatedRoute.params.subscribe(p => {
      this.param = p["id"];
      this.http.get("http://localhost:58426/api/auctions/"+this.param)
      .subscribe(response=> {
        this.items = response;
        console.log(response);
      })
    });
  }

  selectedCategory=1;
  x=0;
  selectChangeHandler(event:any){
    this.selectedCategory = event.target.value;
    this.x = +this.selectedCategory;
  }

  updateItem(inputTitle:HTMLInputElement,inputComment:HTMLInputElement,
    inputStartingDate:HTMLInputElement,inputEndingDate:HTMLInputElement,
    inputStartingPrice:HTMLInputElement){
      let y=0;
      y = +inputStartingPrice.value;

    const put = {
      Title: inputTitle.value,
      Comment: inputComment.value,
      StartingPrice: y,
      Winner:1,
      StartingDate: inputStartingDate.value,
      EndingTime: inputEndingDate.value,
      AdminID:1,
      CategoryID: this.x,
      AuctionStatusID: 1
    }
    console.log(put);

    this.http.put("http://localhost:58426/api/auctions/"+this.param,put)
    .subscribe(response => {
      console.log(response);
    })

  }

}
