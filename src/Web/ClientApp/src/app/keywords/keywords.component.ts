import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
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
  topicsForm: FormGroup;
  phrasesForm: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    // this.initTopicsRadio();
    // this.initPhrasesRadio();
  }

  // initTopicsRadio(){
  //   this.topicsForm = this.formBuilder.group({
  //     topics: this.formBuilder.array(this.createTopicsRadios())
  //   });
  // }

  // initPhrasesRadio(){
  //   this.phrasesForm = this.formBuilder.group({
  //     phrases: this.formBuilder.array(this.createPhrasesRadio())
  //   });
  // }

  // createTopicsRadios(){
  //   let formArr = [];
  //   let topics = this.keywords.topics;
  //   for(var i = 0; i < topics.length; i++){
  //     formArr.push(new FormGroup({
  //       text: new FormControl(topics[i].value),
  //       score: new FormControl(topics[i].score)
  //     }))
  //   }
  //   return formArr;
  // }

  // createPhrasesRadio(){
  //   let formArr = [];
  //   let phrases = this.keywords.phrases
  //   for(var i = 0; i < phrases.length; i++){
  //     formArr.push(new FormGroup({
  //       text: new FormControl(phrases[i].value),
  //       score: new FormControl(phrases[i].score)
  //     }))
  //   }
  //   return formArr;
  // }

  selectWord(word: string){
    this.searchWords.push(word)
  }

  submit(){
    let query = '';
    for(var i = 0; i < this.searchWords.length; i++){
      query += `${this.searchWords[i]},`
    }

    this.send.emit(query);
  }

}
