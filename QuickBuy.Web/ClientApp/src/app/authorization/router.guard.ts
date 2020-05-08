import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Route } from '@angular/router';
import { Observable } from 'rxjs';
import { UserService } from '../services/user.service';

@Injectable({
  providedIn:'root'
})
export class RouterGuard implements CanActivate {

  constructor(private router: Router, private userService: UserService) {
 
  }

  canActivate(route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): boolean /* | Observable<boolean> | Promise<boolean> */{

    if (this.userService.user_authenticated()) {
      return true;
    }
    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
    return false;
  }
}
