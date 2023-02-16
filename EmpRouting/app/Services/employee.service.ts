import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../Models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  url:string="http://localhost:3000/employees"
  constructor(private httpClient: HttpClient) { }

  public getAllEmployee(): Observable<Employee[]>{
    return this.httpClient.get<Employee[]>(this.url);
  }

  public getEmployee(id:number):Observable<Employee>{
    const temp:string=this.url+"/"+id;
    return this.httpClient.get<Employee>(temp);
  }

  public postEmployee(emp:Employee):Observable<Employee>{
    return this.httpClient.post<Employee>(this.url, emp);
  }

  public deleteEmployee(id:string):Observable<string>{
    const temp:string=this.url+"/"+id;
    return this.httpClient.delete<string>(temp);
  }

  public putEmployee(emp:Employee):Observable<Employee>{
    const temp:string=this.url+"/"+emp.id;
    return this.httpClient.put<Employee>(temp, emp);
  }
}

export class UserService{
  private url='https://conversionprocessorfuncapp-qc.azurewebsites.net/api/xmltojson/transform';

  constructor(private http:HttpClient){}

  getData(){
    return this.http.get(this.url);
  }
}
