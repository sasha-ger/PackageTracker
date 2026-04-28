import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../../core/services/auth.service';
import { API_BASE } from '../../core/api.config';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule],
  templateUrl: './login.html',
  styleUrl: './login.scss',
})
export class LoginComponent implements OnInit {
  email = '';
  password = '';
  error = '';
  isStaff = false;

  depotCount: number | null = null;
  droneCount: number | null = null;
  packageCount: number | null = null;

  constructor(private auth: AuthService, private http: HttpClient) {}

  ngOnInit() {
    this.http.get<{ depotCount: number; droneCount: number; packageCount: number }>(`${API_BASE}/depots/stats`)
      .subscribe(stats => {
        this.depotCount = stats.depotCount;
        this.droneCount = stats.droneCount;
        this.packageCount = stats.packageCount;
      });
  }

  login() {
    this.auth.login(this.email, this.password, this.isStaff).subscribe({
      next: () => {
        if (this.isStaff) {
          window.location.href = '/staff/dashboard';
        } else {
          window.location.href = '/customer/my-deliveries';
        }
      },
      error: () => {
        this.error = 'Invalid email or password';
      }
    });
  }
}