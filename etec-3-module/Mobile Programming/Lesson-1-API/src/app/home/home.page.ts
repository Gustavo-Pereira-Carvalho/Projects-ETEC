import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'
import { Observable } from 'rxjs'
import { HttpClient } from '@angular/common/http';
import { retry, catchError } from 'rxjs/operators';
import { ToastController } from '@ionic/angular';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
  standalone: false,
})
export class HomePage implements OnInit{

  films: Observable <any> | undefined;


  constructor(private router: Router, private http: HttpClient, public toastController: ToastController) {}
  ngOnInit(){
    this.films = this.http.get('https://swapi.dev/api/films');
  }
  openDetaisl(film){
    const split = film.url.split('/');
    const filmeId = split[5];
    this.router.navigateByUrl(`/filme-detalhe/${filmeId}`)
  }
}
