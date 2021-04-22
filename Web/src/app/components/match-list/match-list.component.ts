import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Match } from 'src/app/models/match.model';
import { UserMatchResult } from 'src/app/models/user-match-result.model';
import { MatchService } from 'src/app/services/match.service';

@Component({
  selector: 'app-match-list',
  templateUrl: './match-list.component.html',
  styleUrls: ['./match-list.component.scss']
})
export class MatchListComponent implements OnInit {

  currentMatch: Match;
  matches: Array<Match>

  constructor(
    private matchService: MatchService
  ) { }


  ngOnInit(): void {
    this.getAllMatches();
  }

  play(matchId) {
    let randomNum = Math.floor(Math.random() * 10000);
    
    return this.matchService.saveUserMatchResult({matchId: matchId, result: randomNum}).subscribe(
      res => {
        this.currentMatch.hasPlayed = true;
      }
    );
  }

  getAllMatches(){
    this.matchService.getAll().subscribe(
      (res : Array<Match>) => {
        this.matches = res ?? [];
      }
    )
  }

}
