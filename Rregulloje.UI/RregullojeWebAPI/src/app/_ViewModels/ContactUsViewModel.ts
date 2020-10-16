export class ContactUsViewModel {
  id: number;
  name: string;
  email: string;
  subject: string;
  message: string;

  constructor(id: number = null, name: string = null, email: string = null, subject: string = null, message: string = null) {
    this.id = id;
    this.name = name;
    this.email = email;
    this.subject = subject;
    this.message = message;
  }
}
