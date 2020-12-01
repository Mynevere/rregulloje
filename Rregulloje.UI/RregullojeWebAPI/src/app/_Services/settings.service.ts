import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
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
    return this.http.post(this.baseUrl + 'sendIssueEmail', issueViewModel);
  }
}

