import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { SUAS } from '../../models';

@Injectable({ providedIn: 'root' })
export class SuasService {
  private staffUrl = 'http://localhost:5064/api/staff';

  constructor(private http: HttpClient) {}

  getAllSuas(): Observable<SUAS[]> {
    return this.http.get<SUAS[]>(`${this.staffUrl}/drones`);
  }

  getSuasByPackage(packageId: number): Observable<SUAS> {
    return this.http.get<SUAS>(`${this.staffUrl}/drones/by-package/${packageId}`);
  }

  manualDispatch(suasId: number, fromDepotId: number, toDepotId: number): Observable<void> {
    // No dispatch endpoint yet — keep mock for now
    return of(void 0);
  }
}