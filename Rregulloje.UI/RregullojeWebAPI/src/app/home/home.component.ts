import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CompanyService } from '../_Services/company.service';
import { CompanyViewModel } from '../_ViewModels/CompanyViewModel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  constructor(private companyService: CompanyService, private route: Router) { }
  id = 1;
  company: CompanyViewModel;

  ngOnInit(): void {
    this.getCompany(this.id);
  }


  getCompany(id: number) {
    this.companyService.getCompany(id).subscribe(response => {
      this.company = response;
    });
  }
}
