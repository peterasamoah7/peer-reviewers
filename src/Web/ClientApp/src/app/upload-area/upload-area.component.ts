import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';

@Component({
  selector: 'app-upload-area',
  templateUrl: './upload-area.component.html',
  styleUrls: ['./upload-area.component.css']
})
export class UploadAreaComponent implements OnInit {

  @ViewChild("fileDropRef", { static: false }) fileDropEl: ElementRef;
  @Output()upload : EventEmitter<any> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  getfile(file: any){
    this.upload.emit(file);
    this.fileDropEl.nativeElement.value = "";
  }

  openUpload(){
    document.getElementById('file-upload').click();
  }
}
