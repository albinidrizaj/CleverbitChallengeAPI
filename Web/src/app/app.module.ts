import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatchListComponent } from './components/match-list/match-list.component';
import { MatchListItemComponent } from './components/match-list/match-list-item/match-list-item.component';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import { HttpClientModule } from '@angular/common/http';

import { CurrentMatchComponent } from './components/current-match/current-match.component';
import { LogInComponent } from './components/authentication/log-in/log-in.component';
import { RegisterComponent } from './components/authentication/register/register.component';
import {MatInputModule} from '@angular/material/input';
import { AuthenticationGuard } from './guard/authentication.guard';
import { MatchService } from './services/match.service';

const routes: Routes = [
  
  //Auth
  { path: 'login', component: LogInComponent },
  { path: 'register', component: RegisterComponent },


  { path: '', component: MatchListComponent },
  { path: 'match-list', component: MatchListComponent },
];

const materialComponenets = [
  MatCardModule,
  MatButtonModule,
  MatInputModule
]

@NgModule({
  declarations: [
    AppComponent,
    MatchListComponent,
    MatchListItemComponent,
    CurrentMatchComponent,
    LogInComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    BrowserAnimationsModule,
    FormsModule,
    CommonModule,
    HttpClientModule,
    ...materialComponenets
  ],
  providers: [
    AuthenticationGuard,
    MatchService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
