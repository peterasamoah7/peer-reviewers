export class KeyWords{
  topics: Array<Word>;
  phrases: Array<Word>;
}

export class Word{
  value: string;
  score: string;
}

export class SearchResult{
  value: Array<SearchDetails>;
}

export class SearchDetails{
  score: number;
  paper: string;
  url: string;
}
