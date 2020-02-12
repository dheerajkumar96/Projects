import { Component, OnInit } from '@angular/core';
import { ChatService, Message } from '../../chat.service';
import { Observable } from 'rxjs';
import { scan } from 'rxjs/operators';
import { Router } from '@angular/router';

@Component({
  selector: 'app-chat-dialog',
  templateUrl: './chat-dialog.component.html',
  styleUrls: ['./chat-dialog.component.css']
})
export class ChatDialogComponent implements OnInit {
  messages: Observable<Message[]>;
  formValue: string;
  constructor(public chat: ChatService, private rout: Router) { }

  ngOnInit() {
    this.messages = this.chat.conversation.asObservable()
      .pipe(
        scan((acc, val) => acc.concat(val))
      );
  }

  sendmessage() {
    this.chat.converse(this.formValue);
    this.formValue = '';
  }

  navigate() {
    this.rout.navigate(['/upload']);
  }

}
