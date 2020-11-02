import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CompanyComponent } from './company/company.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './home/home.component';
import { ReportIssueComponent } from './report-issue/report-issue.component';
import { ServicesComponent } from './services/services.component';

const routes: Routes = [
  { path: "home", component: HomeComponent },
  { path: "contact-us", component: ContactUsComponent },
  { path: "services", component: ServicesComponent },
  { path: "company", component: CompanyComponent },
  { path: "report-issue", component: ReportIssueComponent },

  { path: "", redirectTo: "home", pathMatch: "full" },
  { path: '**', component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
