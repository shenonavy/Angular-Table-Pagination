import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  baseUrl = 'https://localhost:5001/api/employee/';

  constructor(private http: HttpClient) { }

  getAll(perPage: number, page: number){
    return this.http.get<Employee[]>(this.baseUrl + 'getEmployee?perPage=' + perPage + '&page=' + page).pipe(
      map(response => {
        return response;
      })
    )
  }

  getTotalCount(){
    return this.http.get<number>(this.baseUrl + 'getTotalRecord').pipe(
      map(response => {
        return response;
      })
    )
  }
}
