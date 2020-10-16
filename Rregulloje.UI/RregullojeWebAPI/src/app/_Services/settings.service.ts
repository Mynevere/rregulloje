import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { ContactUsViewModel } from '../_ViewModels/ContactUsViewModel';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {
  baseUrl = environment.apiEndpoint + "api/Settings/";

  constructor(private http: HttpClient) { }

  sendMessage(sendMessage: ContactUsViewModel) {
    debugger
    return this.http.post(this.baseUrl + 'sendMessage', sendMessage)
      .pipe(
        catchError((err: HttpErrorResponse) => {
          return throwError('Ndodhi një problem, mesazhi nuk mund te dergohet!');
        })
      );
  }
}
