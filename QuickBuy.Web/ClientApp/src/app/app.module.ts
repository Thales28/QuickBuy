import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
//import { CounterComponent } from './counter/counter.component';
//import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ProductComponent } from './product/product.component';
import { LoginComponent } from './user/login/login.component'; 
import { RouterGuard } from './authorization/router.guard';
import { UserService } from './services/user.service';
import { UserSignupComponent } from './user/sign-up/user.signup.component';
import { ProductService } from './services/product.service';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
  //CounterComponent,
  //FetchDataComponent,
    ProductComponent,
    LoginComponent,
    UserSignupComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      /*
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      */
      { path: 'product', component: ProductComponent /*, canActivate: [RouterGuard] */},
      { path: 'login', component: LoginComponent },
      { path: 'user-signup', component: UserSignupComponent }
    ])
  ],
  providers: [UserService, ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
