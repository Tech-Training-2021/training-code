import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-comment',
  templateUrl: './comment.component.html',
  styleUrls: ['./comment.component.css']
})
export class CommentComponent {
  constructor() { }
  comments : string[]=["comment 1", "comment 2", "comment 3", "comment 4" ];
  AddComments(){
    this.comments.push('comment 5');
  }
  onRemove(comment){
    let index=this.comments.indexOf(comment);
    this.comments.splice(index,1);
  }
}
