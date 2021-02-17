import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { KeyWords } from '../models/common';

@Component({
  selector: 'app-keywords',
  templateUrl: './keywords.component.html',
  styleUrls: ['./keywords.component.css']
})
export class KeywordsComponent implements OnInit {

  @Input()keywords: KeyWords
  @Output()send: EventEmitter<any> = new EventEmitter();
  searchWords: Array<string> = [];


  constructor() { }

  ngOnInit() {
  }

  selectWord(word: string){
    if(this.searchWords.indexOf(word) > -1){
      this.searchWords = this.searchWords.filter(w => w !== word);
    }else{
      this.searchWords.push(word)
    }
    console.log(this.searchWords);
  }

  submit(){
    let query = '';
    for(var i = 0; i < this.searchWords.length; i++){
      query += `${this.searchWords[i]},`
    }
    console.log(query);
    this.send.emit(query);
  }

}
