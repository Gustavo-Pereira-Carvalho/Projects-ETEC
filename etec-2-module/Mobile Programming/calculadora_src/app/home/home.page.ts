import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  constructor() {}

  n1='';
  n2='';
  res='';

  somar(){
    this.res=this.n1+this.n2;
  }
  subtrair(){
    this.res=(parseFloat(this.n1)-parseFloat(this.n2)).toString();
  }

  multiplicar(){
    this.res=(parseFloat(this.n1)*parseFloat(this.n2)).toString();
  }

  dividir(){
    if(parseFloat(this.n2)==0){
      this.res="impossivel dividir por zero!!"
    }else{
    this.res=(parseFloat(this.n1)/parseFloat(this.n2)).toString();
    }
  }

}


