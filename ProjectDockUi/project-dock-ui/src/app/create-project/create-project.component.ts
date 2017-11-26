import { Component, OnInit } from '@angular/core';
import { WebService } from "../web.service";

export interface IProject {
  name:string;
  description: string;
}

@Component({
  selector: 'app-create-project',
  templateUrl: './create-project.component.html',
  styleUrls: ['./create-project.component.css']
})
export class CreateProjectComponent{

  constructor(private webService: WebService) { }

  project: IProject = {
    name: "",
    description: ""
  }

  post(){
    this.webService.postProject(this.project);
  }
}
