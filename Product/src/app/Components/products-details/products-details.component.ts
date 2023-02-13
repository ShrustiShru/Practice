import { Component, Input } from '@angular/core';
import { Product } from 'src/app/Models/product';

@Component({
  selector: 'app-products-details',
  templateUrl: './products-details.component.html',
  styleUrls: ['./products-details.component.css']
})
export class ProductsDetailsComponent {
@Input() selected: Product={} as Product
}
