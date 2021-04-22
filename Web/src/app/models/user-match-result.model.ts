import { Base } from "./base.model";

export class UserMatchResult extends Base{
    userId: number;
    username: string;
    matchId: number;
    result: number;
}