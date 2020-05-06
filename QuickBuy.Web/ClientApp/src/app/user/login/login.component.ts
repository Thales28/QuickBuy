import { Component } from '@angular/core';
import { log } from 'util';
import { User } from '../../model/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls:['./login.component.css']
})
export class LoginComponent {
  public user;
  public userAuthentication = false;

  constructor() {
    this.user = new User();
  }

  signIn(): void {
    //alert('Button "Sign in" has been clicked');
    log(this.user.email + " - " + this.user.password);
  }

  onKeyPress(): void {
    //alert('Keypressed on inputEmail');
    log(this.user.email);
  }
}
