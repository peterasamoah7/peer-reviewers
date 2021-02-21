import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { KeyWords, ReviewerResult } from '../models/common';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  keyWords: KeyWords;
  searchResult: Array<ReviewerResult>;
  url: string = '';
  loadingText: boolean = false
  loadingSearch: boolean = false;
  error: boolean = false;
  query: string;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string){
      this.url = `${baseUrl}reviewers`;
  }

  upload(files: any) {
    this.error = false;
    this.loadingText = true;
    this.query = ''; 
    let request = new FormData();
    request.append('file',files[0]);

    this.http.post<KeyWords>(this.url, request).subscribe(result => {
      this.keyWords = result;
      this.loadingText = false;
    }, () => {
      this.error = true;
      this.loadingText = false;
      console.log('Api call failed')
    });
  }

  search(request: any) {
    this.query = request; 
    this.loadingSearch = true;
    this.http.get<Array<ReviewerResult>>(`${this.url}?query=${request}`).subscribe(result => {
      this.searchResult = result;
      this.loadingSearch = false;
    }, () => console.log('Api call failed'));
  }

}
