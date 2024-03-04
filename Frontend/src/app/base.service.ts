import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BaseService {
  private url = 'https://localhost:7267/api/';
  private employeeSub = new BehaviorSubject(null);

  constructor(private http: HttpClient) {
  }

  loadEmployees() {
    this.http.get(this.url + 'Employees').subscribe((res: any) => {
      console.log(res);

      this.employeeSub.next(res);
    });
  }

  getEmployees() {
    return this.employeeSub;
  }

  addTipp(body: any) {
    return this.http.post(this.url + 'Tipps', body).forEach(this.loadEmployees);
  }
}
