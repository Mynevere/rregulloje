import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { SettingsService } from '../_Services/settings.service';
import { ContactUsViewModel } from '../_ViewModels/ContactUsViewModel';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.scss']
})
export class ContactUsComponent implements OnInit {
  contactForm: FormGroup;
  successMsg: string;
  contactUsError: string;

  constructor(private settingsService: SettingsService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.createForm();

    this.contactForm["submitted"] = false;
  }

  createForm() {
    this.contactForm = this.formBuilder.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators
        .pattern('^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$')]],
      subject: ['', Validators.required],
      message: ['', Validators.required]
    });
  }

  onSubmit() {
    debugger
    this.contactForm["submitted"] = true;

    if (this.contactForm.valid) {
      var contactUsViewModel = this.contactForm.value as ContactUsViewModel;

      this.settingsService.sendMessage(contactUsViewModel).subscribe(
        (response) => {
          if (response != null) {
            this.successMsg = "Fjalëkalimi juaj është ndryshuar!";
          }
        },
        (error) => {
          this.contactUsError = error;
        });
    }
  }
}
