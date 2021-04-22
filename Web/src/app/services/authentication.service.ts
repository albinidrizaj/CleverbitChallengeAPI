import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Result } from '../models/result.model';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  path = "localhost:44310/api/authentication";

  login(loginDto){
    return this.http.post(`${this.path}/login`, loginDto);
  }


  register(user){
    return this.http.post(`${this.path}/register`, user);
  }
}
