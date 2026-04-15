import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DeliveryService } from '../../core/services/delivery.service';
import { AuthService } from '../../core/services/auth.service';
import { DEPOT_MAP } from '../../models/depot.model';
imports: [CommonModule, FormsModule];


@Component({
  selector: 'app-delivery-request',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './delivery-request.html',
  styleUrl: './delivery-request.scss',
})
export class DeliveryRequestComponent {
  depotMap = DEPOT_MAP;
  depotIds = Object.keys(DEPOT_MAP).map(Number);

  pickupDepotId: number | null = null;
  destinationAddress = '';

  error = '';
  success = '';

  constructor(
    private deliveryService: DeliveryService,
    private auth: AuthService
  ) {}

  submitRequest() {
    const userId = this.auth.getUserIdFromToken();

    if (!userId) {
      this.error = 'You must be logged in to submit a delivery request.';
      return;
    }

    if (!this.pickupDepotId || !this.destinationAddress.trim()) {
      this.error = 'Please select a pickup depot and enter a destination address.';
      return;
    }

    this.error = '';
    this.success = '';

    this.deliveryService.createDeliveryRequest({
      customerId: userId,
      pickupDepotId: this.pickupDepotId,
      destinationAddress: this.destinationAddress
    }).subscribe({
      next: (pkg) => {
        this.success = `Delivery request submitted! New package ID: ${pkg.packageId}`;
        this.pickupDepotId = null;
        this.destinationAddress = '';
      },
      error: () => {
        this.error = 'Failed to submit delivery request.';
      }
    });
  }
}
