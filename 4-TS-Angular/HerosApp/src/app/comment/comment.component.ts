import { Component, OnInit } from '@angular/core';
import {Comment} from '../comment/Model/Comment';
import {CommentConfigService} from '../comment-config.service';

@Component({
  selector: 'app-comment',
  templateUrl: './comment.component.html',
  styleUrls: ['./comment.component.css']
})
export class CommentComponent {
  comments:Comment[]=null;
  constructor(private commentConfig:CommentConfigService) { }
  /*comments : string[]=["comment 1", "comment 2", "comment 3", "comment 4" ];
  AddComments(){
    this.comments.push('comment 5');
  }
  onRemove(comment){
    let index=this.comments.indexOf(comment);
    this.comments.splice(index,1);
  }*/
  LoadComments():void{
    this.commentConfig.getComments()
    .then(response=>this.comments=response);
    console.log(this.comments);
  }
}
