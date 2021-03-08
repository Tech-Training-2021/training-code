import { Component } from "@angular/core";
import { HeroService } from "./hero.service";

@Component({
    /*
    <courses> "courses" 
    <div class="foo"></div> ".foo"
    <div id="courses"></div> "#courses"
    */
    selector:'hero',
    template:`
        <h2>{{getTitle()}}</h2>
        <img [src]="imageUrl" width="200" height="100"/>
        <ul>
            <li *ngFor="let hero of heroes">{{hero}}</li>
        </ul>
        <table>
            <tr>
                <td [attr.colspan]="colSpan"></td>
            </tr>
        </table>
        <button class="btn btn-primary" [class.active]="isActive" [style.backgroundColor]="isActive?'green':'red'">Save</button>
    `
})
export class HeroComponent {
   //data for the Hero Component
   title="List of Heroes";
   imageUrl="https://www.dailydot.com/wp-content/uploads/2018/05/best-superheroes-for-kids-superman.jpg";
   colSpan=1;
   isActive=true;
   getTitle(){return this.title};
   heroes;
   constructor(service:HeroService){
      // let service=new HeroService();//tight-coupled
       this.heroes=service.getHeroes();
   }
}