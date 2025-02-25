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

  converter(){
    this.res=(parseFloat(this.n1)*parseFloat(this.n2)).toFixed(2).toString();
  }


}


