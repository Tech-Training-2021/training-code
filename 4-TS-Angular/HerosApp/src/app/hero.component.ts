import { Component } from "@angular/core";

@Component({
    /*
    <courses> "courses" 
    <div class="foo"></div> ".foo"
    <div id="courses"></div> "#courses"
    */
    selector:'hero',
    template:`
        <h2>{{getTitle()}}</h2>
        <ul>
            <li *ngFor="let hero of heroes">{{hero}}</li>
        </ul>
    `
})
export class HeroComponent {
   //data for the Hero Component
   title="List of Heroes";
   getTitle(){return this.title};
   heroes=["Batman","Spiderman","Harry Potter"];
}