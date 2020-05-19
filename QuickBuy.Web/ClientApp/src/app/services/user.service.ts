import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../model/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private baseUrl: string;
  private _user: User;

  get user(): User {
    let user_json = sessionStorage.getItem("user-authenticated");
    this._user = JSON.parse(user_json);
    return this._user;
  }

  set user(user: User) {
    sessionStorage.setItem("user-authenticated", JSON.stringify(user));
    this._user = user;
  }

  public user_authenticated(): boolean {
    return this._user != null && this._user.email != "" && this._user.password != "";
  }

  public clean_session() {
    sessionStorage.setItem("user-authenticated", "");
    this._user = null;
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public UserVerify(user: User): Observable<User> {

    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: user.email,
      password: user.password
    }

    return this.http.post<User>(this.baseUrl + "api/User/userverify", body, { headers });
  }

  public userSignUp(user: User): Observable<User> {
    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: user.email,
      password: user.password,
      name: user.name,
      surName: user.surname
    }

    return this.http.post<User>(this.baseUrl + "api/user", body, { headers });
  }

}
