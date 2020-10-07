import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { CompanyViewModel } from '../_ViewModels/CompanyViewModel';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
  baseUrl = environment.apiEndpoint + 'api/Company/';

  constructor(private http: HttpClient) { }

  getCompany(id: number): Observable<CompanyViewModel>{
    debugger
    return this.http.get<CompanyViewModel>(this.baseUrl + "getCompany/" + id);
  }
}
