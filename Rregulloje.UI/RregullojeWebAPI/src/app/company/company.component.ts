import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../_Services/company.service';
import { CompanyViewModel } from '../_ViewModels/CompanyViewModel';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.scss']
})
export class CompanyComponent implements OnInit {

  constructor(private companyService: CompanyService) { }
  id = 1;
  company: CompanyViewModel;

  ngOnInit(): void {
    this.getCompany(this.id);
  }


  getCompany(id: number) {
    debugger
    this.companyService.getCompany(id).subscribe(response => {
      this.company = response;
    });
  }
}
