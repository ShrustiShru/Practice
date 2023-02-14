import { Component, OnInit } from '@angular/core';
import { TouristPlaces } from 'src/app/Models/tourist-places';
import { PlaceServiceService } from 'src/app/Services/place-service.service';

@Component({
  selector: 'app-places-list',
  templateUrl: './places-list.component.html',
  styleUrls: ['./places-list.component.css']
})
export class PlacesListComponent implements OnInit{
  
data:TouristPlaces[]=[];
  constructor(private services:PlaceServiceService){

  }
  ngOnInit(): void {
    this.services.GetAllPlaces().subscribe((data)=>this.data=data,
    (err)=>console.log(err))
  }
}

