import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  constructor() {}

  n1= '';
  n2 = '';
  n3 = '';
  n4 = '';
  res = '';

  cl(){
    this.res = ((parseFloat(this.n1) + parseFloat(this.n2) + parseFloat(this.n3) + parseFloat(this.n4)) / 4).toFixed(2);
    if (parseFloat(this.res) < 3) {
      this.res = `Aluno RETIDO! \n media: ${this.res}`
    } else if (parseFloat(this.res) >= 3 && parseFloat(this.res) < 6 ) {
      this.res = `Aluno em RECUPERAÇÃO \n media: ${this.res}`
    } else if (parseFloat(this.res) >= 6) {
      this.res = `Parabens!! Aluno aprovado \n media: ${this.res}`
    }
}

}

