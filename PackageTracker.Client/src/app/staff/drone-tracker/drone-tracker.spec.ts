import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DroneTracker } from './drone-tracker';

describe('DroneTracker', () => {
  let component: DroneTracker;
  let fixture: ComponentFixture<DroneTracker>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DroneTracker],
    }).compileComponents();

    fixture = TestBed.createComponent(DroneTracker);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
