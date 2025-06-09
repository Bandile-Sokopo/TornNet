import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MarketService {

  baseUrl = "http://localhost:5282/api";
  private http = inject(HttpClient);

  constructor() { }
}
