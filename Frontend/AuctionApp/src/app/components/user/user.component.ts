import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  param: any;
  items: any;

  constructor(private activatedRoute: ActivatedRoute, private http: HttpClient) { }

  ngOnInit() {
    this.activatedRoute.params.subscribe(p => {
      this.param = p["id"];
      this.http.get("http://localhost:58426/api/users/"+this.param)
      .subscribe(response=> {
        this.items = response;
        console.log(response);
      })
    });
  }

}
