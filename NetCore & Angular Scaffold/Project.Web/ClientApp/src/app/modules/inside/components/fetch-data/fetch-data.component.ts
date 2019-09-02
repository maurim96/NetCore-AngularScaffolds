import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { WeatherForecastService } from '../../services/weather-forecast.service';
import { WeatherForecast } from '../../models/WeatherForecast';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {

  public forecasts: WeatherForecast[];

  constructor(
    private _weatherForecastService: WeatherForecastService
    ) { }

    ngOnInit(){
      this._weatherForecastService.getAll()
        .subscribe((res: Array<WeatherForecast>) => {
          this.forecasts = res;
        })
    }
}