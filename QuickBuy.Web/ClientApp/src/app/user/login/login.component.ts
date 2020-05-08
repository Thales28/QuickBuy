import { Component, OnInit } from '@angular/core';
import { log } from 'util';
import { User } from '../../model/user';
import { Router, ActivatedRoute } from '@angular/router';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls:['./login.component.css']
})
export class LoginComponent implements OnInit {
  public user;
  public returnUrl: string;
  public message: string;
  private activeSpinner: boolean;

  constructor(
    private router: Router,
    private activatedRouter: ActivatedRoute,
    private userService: UserService
  ) {

    
  }
  ngOnInit(): void {
      this.user = new User();
      this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  signIn(): void {
    //alert('Button "Sign in" has been clicked');
    //log(this.user.email + " - " + this.user.password);
    //sessionStorage.setItem("user-authenticated", "1");
    //this.router.navigate([this.returnURL]);
    this.activeSpinner = true;
    this.userService.UserVerify(this.user).
      subscribe(
        user_json => {
          console.log(user_json);

          this.userService.user = user_json;

          var userReturn: User;
          userReturn = user_json;

          sessionStorage.setItem("user-authenticated", "1");
          sessionStorage.setItem("email", userReturn.email);

          if (this.returnUrl == null) {
            this.router.navigate(['/']);
          }
          else {
            this.router.navigate([this.returnUrl]);
          }
        },
        err => {
          console.log(err.error);
          this.message = err.error;
          this.activeSpinner = false;
        }
      );
  }

  onKeyPress(): void {
    //alert('Keypressed on inputEmail');
    log(this.user.email);
  }
}
