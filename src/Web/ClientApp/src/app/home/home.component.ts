import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { KeyWords, SearchResult } from '../models/common';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  keyWords: KeyWords;
  searchResult: SearchResult;
  url: string = '';

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string){
      this.url = `${baseUrl}/reviewer`;
  }

  upload(request: any){
    this.http.post<KeyWords>(this.url, request).subscribe(result => {
      this.keyWords = result;
    }, () => console.log('Api call failed'));
  }

  search(request: any){
    this.http.get<SearchResult>(`${this.url}?query=${request}`).subscribe(result => {
      this.searchResult = result;
    }, () => console.log('Api call failed'));
  }

}
