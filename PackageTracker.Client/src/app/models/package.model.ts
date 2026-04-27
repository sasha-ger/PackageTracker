export interface Location {
  id: number;
  address: string | null;
  latitude: number;
  longitude: number;
}

export interface Package {
  id: number;
  trackingNumber: string;
  senderId: number;
  recipient: string;
  originLocationId: number;
  originLocation: Location;
  destinationLocationId: number;
  destinationLocation: Location;
  status: PackageStatus;
  createdAt: string;
  updatedAt: string | null;
}

export type PackageStatus =
  | 'Pending'
  | 'InTransit'
  | 'Delivered'
  | 'Failed';
