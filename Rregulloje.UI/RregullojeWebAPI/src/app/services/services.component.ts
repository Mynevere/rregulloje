import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { ServiceService } from '../_Services/service.service';
import { ServiceViewModel } from '../_ViewModels/ServiceViewModel';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.scss'],
  animations: [
    trigger('flipState', [
      state('active', style({
        transform: 'rotateY(179.9deg)'
      })),
      state('inactive', style({
        transform: 'rotateY(0)'
      })),
      transition('active => inactive', animate('500ms ease-out')),
      transition('inactive => active', animate('500ms ease-in'))
    ])
  ]
})
export class ServicesComponent implements OnInit {
  companyServices: ServiceViewModel[];
  flip: string = 'inactive';
  flipped: number;

  constructor(private serviceService: ServiceService) { }

  ngOnInit(): void {
    this.getServices();
  }

  getServices() {
    this.serviceService.getServices().subscribe(response => {
      this.companyServices = response
    })
  }

  toggleFlip(i: number) {

    if (i === this.flipped) {
      this.flipped = null;
    } else {
      this.flipped = i;
    }
  }

  isFlipped(i: number) {
    console.log(this.flipped)
    return this.flipped === i ? 'active' : 'inactive';
  }
}
