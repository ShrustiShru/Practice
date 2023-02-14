import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TouristPlaces } from '../Models/tourist-places';

@Injectable({
  providedIn: 'root'
})
export class PlaceServiceService {

  constructor(private httpClient:HttpClient) { }
  url:string="http://localhost:49597/api/Places"

  public GetAllPlaces():Observable<TouristPlaces[]>{
    return this.httpClient.get<TouristPlaces[]>(this.url)
  }
}
