export class CompanyViewModel {
  id: number;
  name: string;
  description: string;

  constructor(id: number = null, name: string = null, description: string = null) {
    this.id = id;
    this.name = name;
    this.description = description;
  }
}
