import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import {ApiAiClient} from 'api-ai-javascript/es6/ApiAiClient';
import { Observable } from 'rxjs';
import { BehaviorSubject } from 'rxjs';

export class Message {
  constructor(public content: string, public sentby: string) {}
}

@Injectable({
  providedIn: 'root'
})
export class ChatService {
readonly token = environment.dialogflow.angularbot;
readonly client = new ApiAiClient({accessToken: this.token});

conversation = new BehaviorSubject<Message[]>([]);

  constructor() { }

  converse(msg: string) {
    const usermsg = new Message(msg, 'user');
    this.update(usermsg);

    return this.client.textRequest(msg)
    .then(res => {
      const speech = res.result.fulfillment.speech;
      const botmsg = new Message(speech, 'bot');
      this.update(botmsg);
    });
  }

  update(msg: Message) {
    this.conversation.next([msg]);
  }
}
