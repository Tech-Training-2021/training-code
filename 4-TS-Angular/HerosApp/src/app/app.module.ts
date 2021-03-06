import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClient, HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { HeroComponent } from './hero.component';
import { HeroService } from './hero.service';
import { HerosComponent } from './heros/heros.component';
import { SummaryPipe } from './summary.pipe';
import { FavoriteComponent } from './favorite/favorite.component';
import { CommentComponent } from './comment/comment.component';
import { InputFormatDirective } from './input-format.directive';
import { SignupFormComponent } from './signup-form/signup-form.component';

@NgModule({
  declarations: [
    AppComponent,
    HeroComponent,
    HerosComponent,
    SummaryPipe,
    FavoriteComponent,
    CommentComponent,
    SignupFormComponent,
    InputFormatDirective
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [HeroService],//Ng provides single instance of the Service listed here
  bootstrap: [AppComponent]
})
export class AppModule { }
