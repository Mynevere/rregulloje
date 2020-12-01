export class IssueViewModel {
  id: number;
  name: string;
  lastName: string;
  phonenumber: string;
  email: string;
  city: string;
  livingobject: string;
  floor: string;
  livingentrynumber: string;
  apartmentnumber: string;
  issuesubject: string;
  message: string;

  constructor(id: number = null,
    name: string = null,
    lastName: string = null,
    phonenumber: string = null,
    email: string = null,
    city: string = null,
    livingobject: string = null,
    floor: string = null,
    livingentrynumber: string = null,
    apartmentnumber: string = null,
    issuesubject: string = null,
    message: string = null) {
    this.id = id;
    this.name = name;
    this.lastName = lastName;
    this.phonenumber = phonenumber;
    this.email = email;
    this.city = city;
    this.livingobject = livingobject;
    this.floor = floor;
    this.livingentrynumber = livingentrynumber;
    this.apartmentnumber = apartmentnumber;
    this.issuesubject = issuesubject;
    this.message = message;
  }
}
