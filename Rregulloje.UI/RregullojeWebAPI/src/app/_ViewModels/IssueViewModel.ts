export class IssueViewModel {
  id: number;
  name: string;
  lastName: string;
  phoneNumber: string;
  email: string;
  city: string;
  livingObject: string;
  floor: string;
  livingEntryNumber: string;
  apartmentNumber: string;
  issueSubject: string;
  message: string;

  constructor(id: number = null,
    name: string = null,
    lastName: string = null,
    phoneNumber: string = null,
    email: string = null,
    city: string = null,
    livingObject: string = null,
    floor: string = null,
    livingEntryNumber: string = null,
    apartmentNumber: string = null,
    issueSubject: string = null,
    message: string = null) {
    this.id = id;
    this.name = name;
    this.lastName = lastName;
    this.phoneNumber = this.phoneNumber;
    this.email = email;
    this.city = city;
    this.livingObject = livingObject;
    this.floor = floor;
    this.livingEntryNumber = livingEntryNumber;
    this.apartmentNumber = apartmentNumber;
    this.issueSubject = issueSubject;
    this.message = message;
  }
}
