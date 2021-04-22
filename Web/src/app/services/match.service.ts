import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MatchService {

  constructor(private http: HttpClient) { }

  path = "localhost:44310/api/match";

  saveUserMatchResult(matchResult){
    return this.http.post('', matchResult);
  }

  getAll() {
    return this.http.get(`${this.path}/match/getAll`);
  }
}
