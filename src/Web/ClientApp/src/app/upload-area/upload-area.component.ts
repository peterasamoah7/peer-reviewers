import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-upload-area',
  templateUrl: './upload-area.component.html',
  styleUrls: ['./upload-area.component.css']
})
export class UploadAreaComponent implements OnInit {

  file: File = null;
  @Output()upload : EventEmitter<any> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  getfile(file: any){
    this.upload.emit(file);
  }

  openUpload(){
    document.getElementById('file-upload').click();
  }
}
