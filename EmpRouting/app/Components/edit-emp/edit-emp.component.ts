import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-edit-emp',
  templateUrl: './edit-emp.component.html',
  styleUrls: ['./edit-emp.component.css']
})
export class EditEmpComponent implements OnInit {

  employee:Employee={} as Employee;
  imageUrl:string|null="";

  constructor(private service:EmployeeService){

  }
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
 
  OnFileChange(event:any){
    let reader= new FileReader();
    reader.readAsDataURL(event.target.files[0]);
    reader.onload=(_ev)=>{
      this.imageUrl = String(reader.result);
      this.employee.empPic=this.imageUrl;
    }
  }

  OnUpdateEmployee(){
    this.service.putEmployee(this.employee).subscribe((data:Employee)=>{
    this.employee=data;
    })
  }

}
