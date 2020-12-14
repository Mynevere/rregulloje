import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ServiceService } from '../_Services/service.service';
import { MinServiceViewModel } from '../_ViewModels/MinServiceViewModel';
import { ServiceTypesViewModel } from '../_ViewModels/ServiceTypesViewModel';
import { ServiceViewModel } from '../_ViewModels/ServiceViewModel';

@Component({
  selector: 'app-view-service',
  templateUrl: './view-service.component.html',
  styleUrls: ['./view-service.component.scss']
})
export class ViewServiceComponent implements OnInit {
  companyService: ServiceViewModel;
  minService: MinServiceViewModel[];
  serviceTypes: ServiceTypesViewModel[];
  serviceId: number;
  minServiceId: any[] = [];
  serviceTypesMinService: ServiceTypesViewModel[] = [];

  constructor(private serviceService: ServiceService,
              private route: ActivatedRoute) { }

  async ngOnInit() {
    await this.getServiceTypes();
   await this.getServiceById();
    this.getMinServicesByServiceId();
  }

  async getServiceById() {
    let id: number = parseInt(this.route.snapshot.paramMap.get('id'));
    this.serviceService.getServiceById(id).subscribe(response => {
      this.companyService = response;
    })
  }


  getMinServicesByServiceId() {
    let serviceId: number = parseInt(this.route.snapshot.paramMap.get('id'));
    this.serviceService.getMinServicesByServiceId(serviceId).subscribe(response => {
      this.minService = response;
      for (var i = 0; i < this.serviceTypes.length; i++) {
        for (var j = 0; j < this.minService.length; j++) {
          if (this.minService[j].id == this.serviceTypes[i].minServiceId) {
            this.serviceTypesMinService.push(this.serviceTypes[i]);
          }
        }
      }
    })
  }

  async getServiceTypes() {
    this.serviceService.getServiceTypes().subscribe(response => {
      this.serviceTypes = response;
    })
  }
}
