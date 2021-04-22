import { Base } from "./base.model";
import { User } from "./user.model";
import { UserMatchResult } from "./user-match-result.model"

export class Match extends Base {
    startDateTime: Date;
    //In seconds
    matchLength: number;
    //Winner
    userId: number;
    user: User;
    userMatchResults: UserMatchResult[];
    hasPlayed: Boolean;

    
  getTimeLeft(){
    return this.matchLength/60;
  }
}