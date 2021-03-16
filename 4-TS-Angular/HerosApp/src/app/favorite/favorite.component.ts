import { Component, Input, OnInit, Output, EventEmitter, ViewEncapsulation } from '@angular/core';


@Component({
  selector: 'app-favorite',
  templateUrl: './favorite.component.html',
  styleUrls: ['./favorite.component.css'],
  // styles:[
  //   `
  //   h1{color:green}
  //   `
  // ],  
  encapsulation:ViewEncapsulation.Emulated
})
export class FavoriteComponent implements OnInit {

  @Input() isFavorite:boolean;
  @Output('change') click =new EventEmitter();
  onClick(){
    this.isFavorite=!this.isFavorite;
    this.click.emit(this.isFavorite);    
  }
  constructor() { }

  ngOnInit(): void {
  }

}
