import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeroComponent } from './hero.component';
import { HeroService } from './hero.service';
import { HerosComponent } from './heros/heros.component';

@NgModule({
  declarations: [
    AppComponent,
    HeroComponent,
    HerosComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [HeroService],//Ng provides single instance of the Service listed here
  bootstrap: [AppComponent]
})
export class AppModule { }
