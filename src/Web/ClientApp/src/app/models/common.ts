export class KeyWords{
  topics: Array<Word>;
  phrases: Array<Word>;
}

export class Word{
  value: string;
  score: number;
}

export class ReviewerResult{
  data: Data;
  url: string;
  score: number;
}


export class Data {
  paper: string;
  fileName: string;
  reviewer: string;
}
