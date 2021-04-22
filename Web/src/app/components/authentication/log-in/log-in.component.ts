import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Result } from 'src/app/models/result.model';
import { AuthenticationService } from 'src/app/services/authentication.service';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.scss']
})
export class LogInComponent implements OnInit {

  loginDto = {
    username: '',
    password: ''
  }

  constructor(
    private authenticationService: AuthenticationService,
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  login() {
    console.log(this.loginDto)
    this.authenticationService.login(this.loginDto).subscribe((res: Result) => {
      if (!res.sucess)
        alert('fail');

      localStorage.setItem('token', res.data);
      this.router.navigateByUrl('')
    })
  }

}
