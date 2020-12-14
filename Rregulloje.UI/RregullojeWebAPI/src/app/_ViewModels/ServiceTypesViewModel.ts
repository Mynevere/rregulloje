export class ServiceTypesViewModel {
  id: number;
  name: string;
  price: number;
  minServiceId: number;
  minService: string;

  constructor(id: number = null, name: string = null, price: number = null, minServiceId: number = null, minService: string = null) {
    this.id = id;
    this.name = name;
    this.price = price;
    this.minServiceId = minServiceId;
    this.minService = minService;
  }
}
