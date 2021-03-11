import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-favorite',
  templateUrl: './favorite.component.html',
  styleUrls: ['./favorite.component.css']
})
export class FavoriteComponent implements OnInit {

  @Input() isFavorite:boolean;
  @Output() change=new EventEmitter();
  onClick(){
    this.isFavorite=!this.isFavorite;
    this.change.emit();
    
  }
  constructor() { }

  ngOnInit(): void {
  }

}
