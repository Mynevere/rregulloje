import { Component, OnInit, ViewChild } from '@angular/core';
import { NavbarComponent } from 'angular-bootstrap-md/lib/free/navbars/navbar.component';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {
  isCollapsed: boolean;
  @ViewChild('navbar') navbar: NavbarComponent;

  constructor() {
    this.isCollapsed = true;
  }

  ngOnInit(): void {
  }

  hideNavbar() {
    if (this.navbar.shown) {
      this.navbar.hide();
    }
  }

}
