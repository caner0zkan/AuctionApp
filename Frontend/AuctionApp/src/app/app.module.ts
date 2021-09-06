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
import { AdminComponent } from './components/admin/admin.component';
import { UserComponent } from './components/user/user.component';
import { NewproductComponent } from './components/admin/newproduct/newproduct.component';
import { StatusproductsComponent } from './components/admin/statusproducts/statusproducts.component';
import { UpdateproductComponent } from './components/admin/updateproduct/updateproduct.component';
import { ProductComponent } from './components/product/product.component';


const appRoutes: Routes= [
  {path: "", component: HomeComponent}, //localhost:4200
  {path: "home", component: HomeComponent}, //localhost:4200/home
  {path: "home/products", component: HomeComponent}, //localhost:4200/home/products
  {path: "product/:id", component: ProductComponent}, //localhost:4200/home/product/id
  {path: "signup", component: SignupComponent}, //localhost:4200/signup
  {path: "login", component: LoginComponent}, //localhost:4200/login
  {path: "admin", component: AdminComponent}, //localhost:4200/admin
  //{path: "admin/:id", component: AdminComponent}, //localhost:4200/admin
  {path: "user/:id", component: UserComponent}, //localhost:4200/user/id
  {path: "admin/newproduct", component: NewproductComponent}, //localhost:4200/admin/newproduct
  {path: "admin/statusproducts", component: StatusproductsComponent}, //localhost:4200/admin/statusproduct
  {path: "admin/updateproduct/:id", component: UpdateproductComponent}, //localhost:4200/admin/updateproduct/id
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
    LoginComponent,
    AdminComponent,
    UserComponent,
    NewproductComponent,
    StatusproductsComponent,
    UpdateproductComponent,
    ProductComponent
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
