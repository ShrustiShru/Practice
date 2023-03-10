import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { EmpManagerComponent } from './Components/emp-manager/emp-manager.component';
import { ViewEmpComponent } from './Components/view-emp/view-emp.component';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';
import { EditEmpComponent } from './Components/edit-emp/edit-emp.component';
import { ErrorComponent } from './Components/error/error.component';
import { RouterModule, Routes } from '@angular/router';
import {  HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';


const routes:Routes=[
{path:'', redirectTo:'employees/admin',pathMatch:'full'},
{path:'employees/admin',component:EmpManagerComponent},
{path:'employees/view/:id',component:ViewEmpComponent},
{path:'employees/edit/:id',component:EditEmpComponent},
{path:'employees/add',component:AddEmpComponent},
{path:'**',component:ErrorComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    EmpManagerComponent,
    ViewEmpComponent,
    AddEmpComponent,
    EditEmpComponent,
    ErrorComponent,

  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
