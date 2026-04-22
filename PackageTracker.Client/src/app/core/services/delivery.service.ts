import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Package } from '../../models/package.model';

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

  // ⭐ GET all deliveries (for staff dashboard)
  getAllDeliveries(): Observable<Package[]> {
    return this.http.get<Package[]>(this.apiUrl);
  }

  // ⭐ GET a single delivery by ID
  getDeliveryById(id: number): Observable<Package> {
    return this.http.get<Package>(`${this.apiUrl}/${id}`);
  }

  // ⭐ POST a new delivery request (for customers)
  createDelivery(request: {
    senderId: number;
    recipient: string;
    originLocationId: number;
    destinationLocationId: number;
  }): Observable<any> {
    return this.http.post<any>(this.apiUrl, request);
  }
}
