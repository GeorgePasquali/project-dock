import { Component, OnInit } from '@angular/core';
import { WebService } from "../web.service";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit  {
  
  constructor(private webService: WebService, private route: ActivatedRoute) { }

  ngOnInit(){
    let name = (this.route.snapshot.params.name);
    this.webService.getProjects(name);
  }
}
