import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { ChatDialogComponent } from './chatbot/chat/chat-dialog/chat-dialog.component';
import { UploadComponent } from './upload/upload.component';


const routes: Routes = [
  {
    path: 'register', component: RegisterComponent
  },
  {
    path: 'login', component: LoginComponent
  },
  {
    path: '', component: RegisterComponent
  },
  {
    path: 'chatbot', component: ChatDialogComponent
  },
  {
    path: 'upload', component: UploadComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
