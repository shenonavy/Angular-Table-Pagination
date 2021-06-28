import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee';
import { EmployeeService } from '../services/employee.service';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  employeeList: Employee[] = [];
  currentPage = 4;
  total!: number;
  page = 1;
  itemsPerPage = 5;
  itemsPerPages = [{ value: '5', display: '5' }, { value: '10', display: '10' }];

  constructor(private employeeService: EmployeeService) { }

  ngOnInit(): void {
    this.load();
    this.getTotal();
  }

  load(){
    this.employeeService.getAll(this.itemsPerPage, this.page).subscribe(result => {
      this.employeeList = result;
    })
  }

  getTotal(){
    this.employeeService.getTotalCount().subscribe(result => {
      this.total = result;
    })
  }

  pageChanged(event: PageChangedEvent): void {
    this.page = event.page;
    this.load();
  }

  itemPageChange(event: any){
    this.itemsPerPage = +event.target.value;
    this.load();
  }

}
