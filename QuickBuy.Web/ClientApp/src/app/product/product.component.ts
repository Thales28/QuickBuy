import { Component } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html'
})
export class ProductComponent {
  public name: string;
  public enabledToSell: boolean;

  public getName(): string {
    //return this.name;
    return 'Samsung';
  }
}
