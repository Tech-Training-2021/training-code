import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-favorite',
  templateUrl: './favorite.component.html',
  styleUrls: ['./favorite.component.css']
})
export class FavoriteComponent implements OnInit {

  @Input() isFavorite:boolean;
  onClick(){
    this.isFavorite=!this.isFavorite;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
