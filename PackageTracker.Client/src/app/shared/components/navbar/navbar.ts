import { Component } from '@angular/core';
import { RouterModule, Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { ThemeService } from '../../../core/services/theme';
import { AuthService } from '../../../core/services/auth.service';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './navbar.html',
  styleUrl: './navbar.scss'
})
export class Navbar {
  constructor(
    private themeService: ThemeService,
    private authService: AuthService,
    private router: Router
  ) {}

  isDark() { return this.themeService.isDark(); }
  toggleTheme() { this.themeService.toggle(); }
  isStaff() { return this.authService.isStaff(); }

  logout() {
    this.authService.logout();
    this.router.navigate(['/customer/login']);
  }
}