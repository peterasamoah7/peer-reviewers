<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->

<!-- PROJECT LOGO -->
<br />
<p align="center">
<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
      </ul>
      <ul>
        <li><a href="#setup">Setup & Running</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
Peer Reviewers App is a web application that uses AI knowledge extraction to perform document similarity to help recommend peer reviewers  for 
academic and scholarly journals and articles. A possible peer reviewer for a submitted scholarly article or paper is a researcher or academic with experience
in the research area of the submitted research paper. Using knowledge extraction and document similarity we can compare research papers of academics to determine possible reviewers. 

The inspiration for this project is based on a university project I worked on where I used the Bag of Words approach to search indexed documents in a 
search store. In this application we take advantage of Expert AI Keyphrase API to extract key phrases from submitted research papers, the topics and 
main sentences are used to build an intelligent query to retrieve the best matching document from a document store built using Azure Cognitive Services. 

You can view the demo [here](https://youtu.be/k9EI3Qo8fvU)

You can try the live application here [Live site](https://prsapp.azurewebsites.net)  using these research papers from the demo [Test Papers](https://github.com/peterasamoah7/peer-reviewers/tree/master/reviewpapers)

### Built With
* [Angular](https://angular.io/)
* [ASP.NET Core](https://dotnet.microsoft.com/)
* [PdfPig](https://uglytoad.github.io/PdfPig/)
* [Expert AI](https://www.expert.ai/)
* [Azure Cognitive Services](https://azure.microsoft.com/en-gb/services/cognitive-services/)



<!-- GETTING STARTED -->
## Getting Started

To run the application locally, please follow the steps below.

### Prerequisites

* [Visual Studio 2019](https://visualstudio.microsoft.com/)
* [Node.js](https://nodejs.org/)
* [Expert AI Developer account](https://developer.expert.ai/)
* [Azure Account](https://azure.microsoft.com/)


### Setup

1. Clone the repo 
2. Create a developer account at [Expert AI](https://developer.expert.ai/)
3. Create a free Azure Account at [Azure](https://azure.microsoft.com/) or use an existing one. 
4. Create a free Azure Cognitive Search (Free Tier) resource and index these [research papers](https://github.com/peterasamoah7/peer-reviewers/tree/master/researchpapers). You can do that by following the tutorial [here](https://docs.microsoft.com/en-us/azure/search/cognitive-search-quickstart-blob). For this project we used 15 unique research papers in various fields in computer science. The details of the research papers are managed in memory. The details can be moved to a database or any persistent storage if prefered. 
5. Update `appsettings.json`
  ```sh
  {
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "AzureCognitive": {
    "Endpoint": "<your azure search endpoint>",
    "ApiKey": "<your azure search api key>",
    "ApiVersion": "<yazure search api version>",
    "Index": "<your azure search index>",
    "Docblob": "<the url to the public blob from your tutorial in pt.4>"
  },
  "ExpertAi": {
    "Username": "<developer account username>",
    "Password": "<developer account password>",
    "Endpoint": "<expert ai nlp base url>",
    "AuthUrl": "<expert ai authentical base url>"
  }
}
```

### Running from Visual Studio

1. Install front end dependencies 
```sh
npm install
```

2. From Visual Studio, press `F5`
 
<!-- USAGE EXAMPLES -->
## Usage

Please refer to the [demo](https://youtu.be/k9EI3Qo8fvU)

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

