import { Injectable, ErrorHandler, Injector } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class HandleErrorService implements ErrorHandler {

  constructor(
    private injector: Injector
  ) { }

    
  handleError(error: any): void {
    const router = this.injector.get(Router);

    let httpErrorCode = error.httpErrorCode;

    if(httpErrorCode == null) httpErrorCode = error.status;

    switch(httpErrorCode){
      //Manage number errors in cases
    }
  }

}
