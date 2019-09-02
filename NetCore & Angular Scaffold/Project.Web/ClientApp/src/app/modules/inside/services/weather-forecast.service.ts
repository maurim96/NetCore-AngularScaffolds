import { Injectable, Inject } from '@angular/core';

import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class WeatherForecastService {


  constructor(
    private _httpClient: HttpClient, 
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  getAll(){
    return this._httpClient.get(this.baseUrl + "api/weatherforecast");
  }
}
