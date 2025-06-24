import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { pagination } from '../../shared/Models/pagination';
import { item } from '../../shared/Models/item';

@Injectable({
  providedIn: 'root'
})
export class MarketService {

  baseUrl = "http://localhost:5282/api";
  private http = inject(HttpClient);

  getItems(){
    return this.http.get<pagination<item>>(this.baseUrl + 'products')
  }

  constructor() { }
}
