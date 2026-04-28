import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { SUAS } from '../../models';
import { API_BASE } from '../api.config';

@Injectable({ providedIn: 'root' })
export class SuasService {
  private staffUrl = `${API_BASE}/staff`;

  constructor(private http: HttpClient) {}

  getAllSuas(): Observable<SUAS[]> {
    return this.http.get<SUAS[]>(`${this.staffUrl}/drones`);
  }

  getSuasByPackage(packageId: number): Observable<SUAS> {
    return this.http.get<SUAS>(`${this.staffUrl}/drones/by-package/${packageId}`);
  }

  manualDispatch(suasId: number, fromDepotId: number, toDepotId: number): Observable<void> {
    return this.http.post<void>(
      `${this.staffUrl}/drones/dispatch?droneId=${suasId}&fromDepotId=${fromDepotId}&toDepotId=${toDepotId}`,
      {}
    );
  }
}