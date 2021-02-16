import { Directive, EventEmitter, HostListener, Output } from '@angular/core';

@Directive({
  selector: '[appUpload]'
})
export class UploadDirective {

  @Output() send: EventEmitter<any> = new EventEmitter();

  // Dragover listener
  @HostListener('dragover', ['$event']) onDragOver(evt) {
    evt.preventDefault();
    evt.stopPropagation();
  }

  // Dragleave listener
  @HostListener('dragleave', ['$event']) public onDragLeave(evt) {
    evt.preventDefault();
    evt.stopPropagation();
  }

  // Drop listener
  @HostListener('drop', ['$event']) public ondrop(evt) {
    evt.preventDefault();
    evt.stopPropagation();
    let files = evt.dataTransfer.files;
    if (files.length > 0) {
      this.send.emit(files);
    }
  }

}
