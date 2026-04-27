import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DeliveryService } from '../../core/services/delivery.service';
import { Package } from '../../models';

@Component({
  selector: 'app-all-packages',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './all-packages.html',
  styleUrl: './all-packages.scss'
})
export class AllPackages implements OnInit {
  packages: Package[] = [];
  filtered: Package[] = [];
  searchTerm = '';
  selectedStatus = 'ALL';

  statuses = ['ALL', 'Pending', 'InTransit', 'Delivered', 'Failed'];

  constructor(private deliveryService: DeliveryService) {}

  ngOnInit() {
    this.deliveryService.getAllDeliveries().subscribe(data => {
      this.packages = data;
      this.filtered = data;
    });
  }

  applyFilter() {
    const term = this.searchTerm.toLowerCase();
    this.filtered = this.packages.filter(p => {
      const matchesSearch =
        (p.originLocation.address ?? '').toLowerCase().includes(term) ||
        (p.destinationLocation.address ?? '').toLowerCase().includes(term) ||
        p.id.toString().includes(this.searchTerm) ||
        p.trackingNumber.toLowerCase().includes(term);
      const matchesStatus =
        this.selectedStatus === 'ALL' || p.status === this.selectedStatus;
      return matchesSearch && matchesStatus;
    });
  }

  get totalCount() { return this.packages.length; }
  get inTransitCount() { return this.packages.filter(p => p.status === 'InTransit').length; }
  get deliveredCount() { return this.packages.filter(p => p.status === 'Delivered').length; }
  get pendingCount() { return this.packages.filter(p => p.status === 'Pending').length; }
}
