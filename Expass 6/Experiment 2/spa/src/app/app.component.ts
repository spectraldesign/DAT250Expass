import { Component, OnInit } from '@angular/core';
import { Todo } from './Todo';
import { TodoService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class TodosComponent implements OnInit {
  todos: Todo[] = []
  summary:string = ""
  description:string = ""
  constructor(
    private TodoService: TodoService,
    ){}

  ngOnInit(): void {
    this.getTodos()
  }

  getTodos(){ 
    this.TodoService.getTodo().subscribe(result => this.todos = result) 
  }

  deleteOne(todo:Todo){
    this.TodoService.delete(todo.id).subscribe()
    this.getTodos()
  }

  addOne(summary:string, description:string){
    this.TodoService.post(summary, description).subscribe()
    this.getTodos()
  }
 
  populateForm(){
    this.TodoService.post("summary1", "description1").subscribe()
    this.TodoService.post("summary2", "description2").subscribe()
    this.TodoService.post("summary3", "description3").subscribe()
    this.TodoService.post("summary4", "description4").subscribe()
    this.getTodos()
  }
}
