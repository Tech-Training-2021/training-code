import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {Comment} from './comment/Model/Comment';

@Injectable({
  providedIn: 'root'
})
export class CommentConfigService {
  url='https://jsonplaceholder.typicode.com/comments';
  constructor(private client:HttpClient) { }
  getComments():Promise<Comment[]>
  {
    return this.client.get<Comment[]>(this.url).toPromise();
  }
}
