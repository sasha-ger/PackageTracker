// import { Injectable } from '@angular/core';
// import { HttpClient } from '@angular/common/http';
// import { Observable } from 'rxjs';
// import { Package } from '../../models';
// import { AuthService } from './auth.service';

// @Injectable({ providedIn: 'root' })
// export class DeliveryService {
//   private customerUrl = 'http://localhost:5064/api/customer';
//   private staffUrl = 'http://localhost:5064/api/staff';

//   constructor(private http: HttpClient, private auth: AuthService) {}

//   // Customer — get their own packages
//   getPackagesByCustomer(customerId: number): Observable<Package[]> {
//     return this.http.get<Package[]>(`${this.customerUrl}/${customerId}/packages`);
//   }

//   // Customer — get single package status
//   getPackageStatus(packageId: number): Observable<any> {
//     return this.http.get<any>(`${this.customerUrl}/package/${packageId}/status`);
//   }

//   // Customer — create delivery request
//   createDeliveryRequest(request: any): Observable<any> {
//     return this.http.post(`${this.customerUrl}/request`, request);
//   }

//   // Staff — get all active packages
//   getAllDeliveries(): Observable<Package[]> {
//     return this.http.get<Package[]>(`${this.staffUrl}/packages/active`);
//   }
// }
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Package } from '../../models/package.model';
import { CreateDeliveryRequest } from '../../models/create-delivery-request.model';

@Injectable({
  providedIn: 'root'
})
export class DeliveryService {

  private apiUrl = 'https://localhost:7083/api/Deliveries';

  constructor(private http: HttpClient) {}

  // ⭐ GET all deliveries for a specific customer
  getDeliveriesForCustomer(customerId: number): Observable<Package[]> {
    return this.http.get<Package[]>(`${this.apiUrl}/customer/${customerId}`);
  }

  // ⭐ GET a single delivery by ID
  getDeliveryById(id: number): Observable<Package> {
    return this.http.get<Package>(`${this.apiUrl}/${id}`);
  }

  // ⭐ POST a new delivery request
  createDelivery(request: CreateDeliveryRequest): Observable<any> {
    return this.http.post<any>(this.apiUrl, request);
  }
}
