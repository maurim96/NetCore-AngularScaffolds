import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InsideRoutingModule } from './inside-routing.module';


import { InsideComponent } from './inside.component';
import { CounterComponent } from './components/counter/counter.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { FetchDataComponent } from './components/fetch-data/fetch-data.component';
import { HomeComponent } from './components/home/home.component';

@NgModule({
  imports: [
    CommonModule,
    InsideRoutingModule
  ],
  declarations: [
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    InsideComponent
  ]
})
export class InsideModule { }
