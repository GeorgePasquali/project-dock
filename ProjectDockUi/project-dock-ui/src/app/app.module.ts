import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router'
import { NgModule } from '@angular/core';
import { WebService } from "./web.service"
import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { ProjectListComponent } from './project-list/project-list.component';
import { HttpModule } from "@angular/http";
import { CreateProjectComponent } from './create-project/create-project.component';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HomeComponent } from './home/home.component';
import { SideBarComponent } from './side-bar/side-bar.component';
import { RegisterComponent } from './register/register.component';
import { AuthService } from "./auth.service";
import { CanBanBoardComponent } from './can-ban-board/can-ban-board.component';


var routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'projects',
    component: ProjectListComponent
  },
  {
    path: 'projects/:name',
    component: CanBanBoardComponent
  },
  {
    path: 'create',
    component: CreateProjectComponent
  },
  {
    path: 'register',
    component: RegisterComponent
  }
];

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    ProjectListComponent,
    CreateProjectComponent,
    HomeComponent,
    SideBarComponent,
    RegisterComponent,
    CanBanBoardComponent,
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [WebService, AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
