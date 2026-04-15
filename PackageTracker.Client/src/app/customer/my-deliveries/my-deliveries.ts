import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DeliveryService } from '../../core/services/delivery.service';
import { AuthService } from '../../core/services/auth.service';
import { DEPOT_MAP } from '../../models/depot.model';

@Component({
  selector: 'app-my-deliveries',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './my-deliveries.html',
  styleUrl: './my-deliveries.scss',
})
export class MyDeliveriesComponent implements OnInit {
  deliveries: any[] = [];
  error = '';

  depotMap = DEPOT_MAP;

  constructor(
    private deliveryService: DeliveryService,
    private auth: AuthService
  ) {}

  ngOnInit() {
    const userId = this.auth.getUserIdFromToken();
    if (!userId) {
      this.error = 'You must be logged in to view deliveries.';
      return;
    }

    this.deliveryService.getPackagesByCustomer(userId).subscribe({
      next: (pkgs) => (this.deliveries = pkgs),
      error: () => (this.error = 'Failed to load deliveries.')
    });
  }

  getDepotName(id: number | undefined) {
    return id ? this.depotMap[id] ?? 'Unknown depot' : '—';
  }

  track(id: number) {
    window.location.href = `/customer/tracking/${id}`;
  }

  goToRequest() {
    window.location.href = '/customer/delivery-request';
  }
}
