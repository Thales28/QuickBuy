import { Component, OnInit } from '@angular/core';
import { User } from '../../model/user';
import { UserService } from '../../services/user.service';

@Component({
  selector: "user-signup",
  templateUrl: "./user.signup.component.html",
  styleUrls: ["./user.signup.component.css"]
})
export class UserSignupComponent implements OnInit{
  public user: User;

  constructor(private userService: UserService) {

  }

  ngOnInit(): void {
    this.user = new User();
  }

  public signUp() {
   /* this.userService.userSignUp(
      this.user
    ).subscribe(
      userJson => { },
      e => { }
    );
    */
  }
}
