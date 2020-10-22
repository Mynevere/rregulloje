export class UserMessageEmailViewModel {
  id: number;
  name: string;
  fromEmail: string;
  toEmail: string;
  subject: string;
  message: string;

  constructor(id: number = null, name: string = null, fromEmail: string = null, toEmail: string = null, subject: string = null, message: string = null) {
    this.id = id;
    this.name = name;
    this.fromEmail = fromEmail;
    this.toEmail = toEmail;
    this.subject = subject;
    this.message = message;
  }
}
