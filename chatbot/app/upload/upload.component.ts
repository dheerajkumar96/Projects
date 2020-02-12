import { Component, OnInit, EventEmitter} from '@angular/core';
import { FileUploader, FileLikeObject } from 'ng2-file-upload';

const URL = 'http://localhost:3000/fileupload/';
@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})

export class UploadComponent implements OnInit {
  constructor() { }
  public uploader: FileUploader = new FileUploader({
    url: URL,
    disableMultipart : false,
    autoUpload: true,
    method: 'post',
    itemAlias: 'attachment',
    allowedFileType: ['image', 'pdf']


    });

  ngOnInit() {
  }

  public onFileSelected(event: EventEmitter<File[]>) {
    const file: File = event[0];
    console.log(file);

  }
}
