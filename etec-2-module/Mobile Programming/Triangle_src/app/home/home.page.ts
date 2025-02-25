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
  res = '';

  cl(){
    if(this.n1 == this.n2 && this.n1 == this.n3){
      this.res = 'O triangulo é equilatero'
    }else if(this.n1 == this.n2 && this.n1 != this.n3 || this.n2 == this.n3 && this.n2 != this.n1 ||this.n3 == this.n1 && this.n3 != this.n2){
      this.res ='O triangulo é ióseles'
    }else if(
      parseFloat(this.n1) <= 0 || parseFloat(this.n2) <=0 || parseFloat(this.n3) <= 0 ||

      this.n1 + this.n2 <= this.n3 ||
      this.n1 + this.n3 <= this.n2 ||
      this.n2 + this.n3 <= this.n1)
    {
      this.res = 'nao é um triangulo'
    }else if(this.n1 != this.n2 && this.n1 != this.n3){
      this.res = 'O triangulo é escaleno'
  }

}

}

