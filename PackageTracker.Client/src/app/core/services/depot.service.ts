import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Depot } from '../../models';
import { API_BASE } from '../api.config';

@Injectable({ providedIn: 'root' })
export class DepotService {

  private apiUrl = `${API_BASE}/depots`;

  constructor(private http: HttpClient) {}

  getAllDepots(): Observable<Depot[]> {
    return this.http.get<Depot[]>(this.apiUrl);
  }
}
