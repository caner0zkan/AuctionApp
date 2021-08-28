import { HttpClient } from '@angular/common/http';
import { ThisReceiver } from '@angular/compiler';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-newproduct',
  templateUrl: './newproduct.component.html',
  styleUrls: ['./newproduct.component.css']
})
export class NewproductComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  selectedCategory=1;
  x=0;
  selectChangeHandler(event:any){
    this.selectedCategory = event.target.value;
    this.x = +this.selectedCategory;
  }

  createPost(inputTitle:HTMLInputElement,inputComment:HTMLInputElement,
    inputStartingDate:HTMLInputElement,inputEndingDate:HTMLInputElement,
    inputStartingPrice:HTMLInputElement){
      let y=0;
      y = +inputStartingPrice.value;

    const post = {
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
    console.log(post);

    this.http.post("http://localhost:58426/api/auctions",post)
      .subscribe(response => {
        console.log(response);
      })

  }
}
