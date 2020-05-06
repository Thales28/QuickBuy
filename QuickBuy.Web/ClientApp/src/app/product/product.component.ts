import { Component } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  public name: string;
  public enabledToSell: boolean;

  public getName(): string {
    //return this.name;
    return 'Product';
  }
}
