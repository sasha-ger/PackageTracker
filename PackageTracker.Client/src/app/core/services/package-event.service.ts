// ─────────────────────────────────────────────
// src/app/core/services/package-event.service.ts
// ─────────────────────────────────────────────

// import { Injectable } from '@angular/core';
// import { Observable, of } from 'rxjs';
// import { DeliveryEvent } from '../../models';

// @Injectable({
//   providedIn: 'root'
// })
// export class PackageEventService {

//   constructor() {}

//   getPackageStatus(packageId: number): Observable<DeliveryEvent> {
//     return of({
//       packageId,
//       status: 'IN_TRANSIT',
//       lastUpdated: new Date(),
//       location: 'Lincoln - O & 27th'
//     });
//   }
// }
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { API_BASE } from '../api.config';

@Injectable({
  providedIn: 'root'
})
export class PackageEventService {

  private apiUrl = `${API_BASE}/PackageEvents`;

  constructor(private http: HttpClient) {}

  getPackageStatus(id: number): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/status/${id}`);
  }
}
