import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { IssueViewModel } from '../_ViewModels/IssueViewModel';
import { UserMessageEmailViewModel } from '../_ViewModels/UserMessageEmailViewModel';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {
  baseUrl = environment.apiEndpoint + "api/Settings/";

  constructor(private http: HttpClient) { }

  sendUserMessageEmail(userMessageViewModel: UserMessageEmailViewModel) {
    return this.http.post(this.baseUrl + 'sendUserMessageEmail', userMessageViewModel);
  }

  sendIssueEmail(issueViewModel: IssueViewModel) {
    debugger
    return this.http.post(this.baseUrl + 'sendIssueEmail', issueViewModel);
  }
}

