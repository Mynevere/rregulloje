export class ServiceViewModel {
  id: number;
  name: string;
  description: string;

  constructor(id: number = null, name: string = null, description: string = null, pictureUrl: string = null) {
    this.id = id;
    this.name = name;
    this.description = description;
  }
}
