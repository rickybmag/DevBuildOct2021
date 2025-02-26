import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Movie } from './Movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  url: string = "Movie";
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl + this.url;
  }

  GetMovieList() {
    return this.http.get(this.url);
  }

  //Think of observable as the pizza order, I've told papajohn what I want 
  //And now I need to wait it to be delivered
  GetMovie(id: number) {
    return this.http.get(this.url + "/get/" + id);
  }

  CreateMovie(m: Movie) {

    //If an api call isn't working, first thing to check should be 
    // your URL 
    //console.log(this.url + "/makeNew/");
    console.log(m);
    return this.http.post(this.url + "/makeNew/", m);
  }
}
