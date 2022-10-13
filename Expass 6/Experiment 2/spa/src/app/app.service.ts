import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Todo} from './Todo';
import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root',
})

export class TodoService{
    constructor(
        private http: HttpClient) { }
    private todoUrl = "/api"
    private counter = 0
    
    //GET Todo from server: 
    getTodo(): Observable<Todo[]> {
        return this.http.get<Todo[]>(this.todoUrl)
    }

    post(summary:string, description:string){ 
        const id = this.counter
        this.counter++
        return this.http.post(this.todoUrl, {
            id,
            description,
            summary
        })
    }

    delete(id:number){
        return this.http.delete(`${this.todoUrl}/${id}`)
    }
}