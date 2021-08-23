import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {RouterModule, Routes} from '@angular/router';
import {HttpClientModule} from '@angular/common/http';


import { AppComponent } from './app.component';
import { NavComponent } from './components/nav/nav.component';
import { FooterComponent } from './components/footer/footer.component';
import { HomeComponent } from './components/home/home.component';
import { CategoriesComponent } from './components/categories/categories.component';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { ProductsComponent } from './components/home/products/products.component';
import { SignupComponent } from './components/signup/signup.component';
import { LoginComponent } from './components/login/login.component';


const appRoutes: Routes= [
  {path: "", component: HomeComponent}, //localhost:4200
  {path: "home", component: HomeComponent}, //localhost:4200/home
  {path: "signup", component: SignupComponent}, //localhost:4200/signup
  {path: "login", component: LoginComponent}, //localhost:4200/login
  {path: "**", component: NotfoundComponent} //notfound page
];


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    FooterComponent,
    HomeComponent,
    CategoriesComponent,
    NotfoundComponent,
    ProductsComponent,
    SignupComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
