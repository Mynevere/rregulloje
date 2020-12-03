import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ServiceService } from '../_Services/service.service';
import { SettingsService } from '../_Services/settings.service';
import { IssueViewModel } from '../_ViewModels/IssueViewModel';
import { ServiceViewModel } from '../_ViewModels/ServiceViewModel';

@Component({
  selector: 'app-report-issue',
  templateUrl: './report-issue.component.html',
  styleUrls: ['./report-issue.component.scss']
})
export class ReportIssueComponent implements OnInit {
  reportForm: FormGroup;
  successMsg: string;
  reportError: string;
  companyServices: any[];

  constructor(private settingsService: SettingsService, private formBuilder: FormBuilder, private router: Router, private serviceService: ServiceService) { }

  ngOnInit(): void {
    this.getServices();
    this.createForm();
    this.reportForm["submitted"] = false;
  }

  createForm() {
    this.reportForm = this.formBuilder.group({
      name: ['', Validators.required],
      lastname: ['', Validators.required],
      phonenumber: ['', Validators.required],
      email: ['', [Validators.required, Validators
        .pattern('^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$')]],
      city: ['', Validators.required],
      livingobject: ['', Validators.required],
      floor: ['', Validators.required],
      livingentrynumber: ['', Validators.required],
      apartmentnumber: ['', Validators.required],
      message: ['', Validators.required],
      serviceId: [null, Validators.required],
    });
  }


  getServices() {
    this.serviceService.getServices().subscribe(response => {
      this.companyServices = response;
      console.log(this.companyServices);
    })
  }

  onSubmit() {
    this.reportForm["submitted"] = true;
    if (this.reportForm.valid) {
      var issueViewModel = this.reportForm.value as IssueViewModel;

      this.settingsService.sendIssueEmail(issueViewModel).subscribe(
        (response) => {
          this.router.navigateByUrl("home");

          this.reportForm.reset();
          Object.keys(this.reportForm.controls).forEach(field => {
            const control = this.reportForm.get(field);
            control.markAsUntouched();
            control.markAsPristine();
          });
          this.successMsg = "Raporti u dërgua!"

        });
    }
  }
}
