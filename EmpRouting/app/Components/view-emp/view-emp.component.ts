import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-view-emp',
  templateUrl: './view-emp.component.html',
  styleUrls: ['./view-emp.component.css']
})
export class ViewEmpComponent implements OnInit{
  empId:string|null="";
  employees:Employee={} as Employee //for one object

  constructor(private service:EmployeeService, private activeRoute:ActivatedRoute){

  }

  ngOnInit(): void { 
   this.activeRoute.paramMap.subscribe((params:ParamMap)=>{this.empId=params.get("id");
  })

  if(this.empId!=null){
    let observable=this.service.getEmployee(parseInt(this.empId))
    observable.subscribe((data:Employee)=>
    this.employees=data
    )}
  }
}
