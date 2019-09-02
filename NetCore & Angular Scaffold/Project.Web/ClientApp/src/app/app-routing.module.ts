import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { InsideModule } from './modules/inside/inside.module';
import { InsideComponent } from './modules/inside/inside.component';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => InsideModule
    }
];

@NgModule({
  imports: [
      CommonModule,
      RouterModule.forRoot(routes, {
          useHash: false,
          enableTracing:true
      })
  ],
    declarations: [],
  exports: [RouterModule]
})
export class AppRoutingModule { }
