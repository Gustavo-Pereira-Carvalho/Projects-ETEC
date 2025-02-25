import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  constructor() {}

  vl= '';
  res = '';

  celcius(){
    this.res = ((9 *parseFloat(this.vl) + 160) /5).toFixed(2);
  }

  fahrenheit(){
    this.res = ((parseFloat(this.vl) - 32) * (5/9)).toFixed(2);
  }
}
