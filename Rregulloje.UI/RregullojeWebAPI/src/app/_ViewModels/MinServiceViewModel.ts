export class MinServiceViewModel {
  id: number;
  name: string;
  description: string;
  serviceId: number;
  service: string;
  serviceTypeId: number;
  serviceType: string;

  constructor(id: number = null, name: string = null, description: string = null, serviceId: number = null,
    service: string = null, serviceTypeId: number = null, serviceType: string = null) {
    this.id = id;
    this.name = name;
    this.description = description;
    this.serviceId = serviceId;
    this.service = service;
    this.serviceTypeId = serviceTypeId;
    this.serviceType = serviceType;
  }
}
