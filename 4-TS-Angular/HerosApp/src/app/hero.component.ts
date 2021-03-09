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
        <!--input [value]='heroName' (keyup.enter)="heroName=$event.target.value; onKeyUp()"/-->
        <input [(ngModel)]="heroName" (keyup.enter)="onKeyUp()"/>
        <div (click)='onParagraphClick()'>
            <div (click)="onDivClick()">
                <button (click)="onSave($event)" class="btn btn-primary" [class.active]="isActive" [style.backgroundColor]="isActive?'green':'red'">Save</button>
            </div>
        </div>
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
   onSave($event){
       $event.stopPropagation();
       console.log("Values are saved",$event);
   }
   onDivClick(){
        console.log("div was clicked");
   }
   onParagraphClick(){
        console.log("paragraph was clicked");
   }
   heroName="Deadpool";
   onKeyUp(){
        console.log(this.heroName);
   }

}