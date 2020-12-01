import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SettingsService } from '../_Services/settings.service';
import { IssueViewModel } from '../_ViewModels/IssueViewModel';

@Component({
  selector: 'app-report-issue',
  templateUrl: './report-issue.component.html',
  styleUrls: ['./report-issue.component.scss']
})
export class ReportIssueComponent implements OnInit {
  reportForm: FormGroup;
  successMsg: string;
  reportError: string;

  constructor(private settingsService: SettingsService, private formBuilder: FormBuilder, private router: Router) { }

  ngOnInit(): void {
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
      issuesubject: ['', Validators.required],
      message: ['', Validators.required]
    });
  }


  onSubmit() {
    debugger
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
