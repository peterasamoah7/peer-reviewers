import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { SearchResult } from '../models/common';

@Component({
  selector: 'app-results',
  templateUrl: './results.component.html',
  styleUrls: ['./results.component.css']
})
export class ResultsComponent implements OnInit {

  @Input()results: SearchResult
  @Output()send: EventEmitter<any> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }
}
