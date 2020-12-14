import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { MinServiceViewModel } from '../_ViewModels/MinServiceViewModel';
import { ServiceTypesViewModel } from '../_ViewModels/ServiceTypesViewModel';
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

  getServiceById(id: number): any {
    return this.http.get<any>(this.baseUrl + "getService/" + id);
  }

  getMinServicesByServiceId(serviceId: number): Observable<MinServiceViewModel[]>{
    return this.http.get<MinServiceViewModel[]>(this.baseUrl + "getMinServices/" + serviceId);
  }

  getServiceTypes(): Observable<ServiceTypesViewModel[]> {
    return this.http.get<ServiceTypesViewModel[]>(this.baseUrl + "getServiceTypes/"); 
  }
}
