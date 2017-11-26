import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/topromise';
import { IProject } from "./create-project/create-project.component";
import { Subject } from "rxjs/Rx";

@Injectable()
export class WebService {
  BASE_URL = "http://localhost:49580/api";

  private projectStore = [];

  private projectsSubject = new Subject();

  projects = this.projectsSubject.asObservable();

  constructor(private http: Http) {
    this.getProjects(undefined);
  }

  getProjects(user: string = "") {

    this.http.get(`${this.BASE_URL}/projects/${user}`).subscribe((response) => { // subscribe to an event
      this.projectStore = response.json();
      this.projectsSubject.next(this.projectStore);``
    }, (error) => { // Handle errors (next?: subscription(value: Response) => void, error?: (error: any) => void)
      this.handleError(error, "An error during get request");
    });
  }

  async postProject(project: IProject) {
    try {
      var response = await this.http.post(`${this.BASE_URL}/projects`, project).toPromise();
      this.projectStore.push(response.json());
      this.projectsSubject.next(this.projectStore);
    } catch (error) {
      this.handleError(error, "An error during post request");
    }

  }

  private handleError(error, description: string = "An error occurred:") {
    console.error(description, error);
    // TODO: Later add an error in the UI...
  }
}
