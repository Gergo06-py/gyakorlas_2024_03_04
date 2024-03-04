import { Component } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.css',
})
export class ListComponent {
  employees: any;
  constructor(private base: BaseService) {
    this.base.getEmployees().subscribe((res) => {
      this.employees = res;
    });
  }
}
