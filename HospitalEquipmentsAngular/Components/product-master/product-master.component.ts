import { Component } from '@angular/core';
import { Product } from 'src/app/Models/product';

@Component({
  selector: 'app-product-master',
  templateUrl: './product-master.component.html',
  styleUrls: ['./product-master.component.css']
})
export class ProductMasterComponent {
  products: Product[] = []
  selectedproduct:Product={} as Product
  ngOnInit(): void {
    [
      this.products.push({ id: 100, name: "Thermometer", price: 2000, image: "./assets/Images/thermometer.jfif" }),
      this.products.push({ id: 101, name: "Blood Pressure", price: 10000, image: "./assets/Images/bp.jfif" }),
      this.products.push({ id: 102, name: "CT Scan", price: 750000, image: "./assets/Images/ct.jfif" }),
      this.products.push({ id: 103, name: "Dental Chair", price: 500000, image: "./assets/Images/dentist.jfif" }),
      this.products.push({ id: 104, name: "MRI Scan", price: 100000, image: "./assets/Images/mri.jfif" }),
      this.products.push({ id: 105, name: "Oximeter", price: 3000, image: "./assets/Images/oximeter.jfif" }),
      this.products.push({ id: 106, name: "Stehthoscope", price: 7000, image: "./assets/Images/stethoscope.jfif" }),
      this.products.push({ id: 107, name: "Sugar Tester", price: 6000, image: "./assets/Images/sugar.jfif" }),
    ]
  };
  
  OnView_CLick(prod:Product){
    this.selectedproduct=prod;
  }
}
