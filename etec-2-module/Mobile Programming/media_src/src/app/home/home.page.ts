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
  n3= '';
  res='';

  media(){
    this.res=(
      (
        (parseFloat(this.n1)*0.2)+
        (parseFloat(this.n2)*0.1)+
        (parseFloat(this.n3)*0.7)
      )
    ).toFixed(2).toString();
  }


}


