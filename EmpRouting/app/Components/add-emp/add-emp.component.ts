import { Component, OnInit, ɵisObservable } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-add-emp',
  templateUrl: './add-emp.component.html',
  styleUrls: ['./add-emp.component.css']
})

export class AddEmpComponent implements OnInit  {

  newEmployee:Employee={} as Employee;
  imageUrl:string|null="";

  constructor(private service:EmployeeService, private router:Router){
  
  }

  ngOnInit(): void {
    this.newEmployee.id=0;
    let observable=this.service.getAllEmployee()
    observable.subscribe((data:Employee[])=>{
      for(const item of data){
        if(item.id>this.newEmployee.id){
          this.newEmployee.id=item.id;
        }
        else{
          this.newEmployee.id++;
        }
      }
    })
    
  }

    OnFileChange(event:any){
      let reader= new FileReader();
      reader.readAsDataURL(event.target.files[0]);
      reader.onload=(_ev)=>{
        this.imageUrl = String(reader.result);
        this.newEmployee.empPic=this.imageUrl;
      }
    }

    OnAddEmployee() {
      let observable = this.service.postEmployee(this.newEmployee)
      observable.subscribe((data: Employee) => {
    this.newEmployee = data;
      alert("Employee Added Succesfully")
      this.router.navigate(['/']);
    })
  }
}
