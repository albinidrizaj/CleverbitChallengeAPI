import { Base } from "./base.model";

export class User extends Base {
    firstName: string;
    lastName: string;
    email: string;
    username: string;
    password: string;
}