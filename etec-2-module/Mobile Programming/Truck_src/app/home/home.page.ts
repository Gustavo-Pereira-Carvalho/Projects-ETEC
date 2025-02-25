import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  constructor() { }

  n1 = '';
  res = '';
  cl() {
    var distancia = parseFloat(this.n1);

    if (parseFloat(this.n1) <= 50) {
      var valorBase = distancia * 4.20;
      var taxa = valorBase * 0.20;
      this.res = (valorBase + taxa).toFixed(2);
      this.res = `O valor a ser pago será de: R$ ${this.res}`

    } else if (parseFloat(this.n1) > 50) {
      var valorBase = distancia * 3.98;
      var taxa = valorBase * 0.20;
      this.res = (valorBase + taxa).toFixed(2);
      this.res = `O valor a ser pago será de: R$ ${this.res}`
    }

}

}