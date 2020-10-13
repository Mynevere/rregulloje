import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { ServiceViewModel } from '../_ViewModels/ServiceViewModel';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {
  baseUrl = environment.apiEndpoint + 'api/Services/';

  constructor(private http: HttpClient) { }

  getServices(): Observable<ServiceViewModel[]>{
    return this.http.get<ServiceViewModel[]>(this.baseUrl + "getServices/");
  }
}
