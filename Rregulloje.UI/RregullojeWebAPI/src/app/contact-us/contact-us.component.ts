import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SettingsService } from '../_Services/settings.service';
import { UserMessageEmailViewModel } from '../_ViewModels/UserMessageEmailViewModel';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.scss']
})
export class ContactUsComponent implements OnInit {
  contactForm: FormGroup;
  successMsg: string;
  contactUsError: string;

  constructor(private settingsService: SettingsService, private formBuilder: FormBuilder, private router: Router) { }

  ngOnInit(): void {
    this.createForm();

    this.contactForm["submitted"] = false;
  }

  createForm() {
    this.contactForm = this.formBuilder.group({
      name: ['', Validators.required],
      fromEmail: ['', [Validators.required, Validators
        .pattern('^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$')]],
      subject: ['', Validators.required],
      message: ['', Validators.required]
    });
  }

  onSubmit() {
    this.contactForm["submitted"] = true;
    if (this.contactForm.valid) {
      var userMessageViewModel = this.contactForm.value as UserMessageEmailViewModel;

      this.settingsService.sendUserMessageEmail(userMessageViewModel).subscribe(
        (response) => {
          this.router.navigateByUrl("home");

          this.contactForm.reset();
          Object.keys(this.contactForm.controls).forEach(field => {
            const control = this.contactForm.get(field);
            control.markAsUntouched();
            control.markAsPristine();
          });
          this.successMsg = "Mesazhi u dërgua!"

        });
    }
  }
}
  //  debugger
  //  this.contactForm["submitted"] = true;

  //  if (this.contactForm.valid) {
  //    var contactUsViewModel = this.contactForm.value as ContactUsViewModel;

  //    this.settingsService.sendMessage(contactUsViewModel).subscribe(
  //      (response) => {
  //        if (response != null) {
  //          this.successMsg = "Fjalëkalimi juaj është ndryshuar!";
  //        }
  //      },
  //      (error) => {
  //        this.contactUsError = error;
  //      });
  //  }
  //}
