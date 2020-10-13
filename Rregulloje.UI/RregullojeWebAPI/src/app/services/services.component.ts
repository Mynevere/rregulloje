import { Component, OnInit } from '@angular/core';
import { ServiceService } from '../_Services/service.service';
import { ServiceViewModel } from '../_ViewModels/ServiceViewModel';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.scss']
})
export class ServicesComponent implements OnInit {
  companyServices: ServiceViewModel[];

  constructor(private serviceService: ServiceService) { }

  ngOnInit(): void {
    this.getServices();
  }

  getServices() {
    this.serviceService.getServices().subscribe(response => {
      this.companyServices = response;
      console.log(this.companyServices);
    })
  }
}
