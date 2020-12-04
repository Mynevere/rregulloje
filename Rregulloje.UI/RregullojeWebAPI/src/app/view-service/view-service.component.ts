import { Component, OnInit } from '@angular/core';
import { ServiceService } from '../_Services/service.service';
import { ServiceViewModel } from '../_ViewModels/ServiceViewModel';

@Component({
  selector: 'app-view-service',
  templateUrl: './view-service.component.html',
  styleUrls: ['./view-service.component.scss']
})
export class ViewServiceComponent implements OnInit {
  //companyServices: ServiceViewModel[];

  constructor(private serviceService: ServiceService) { }

  ngOnInit(): void {
    //this.getServices();
  }

  //getServices() {
  //  this.serviceService.getServices().subscribe(response => {
  //    this.companyServices = response
  //  })
  //}
}
