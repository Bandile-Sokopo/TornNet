import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { pagination } from '../../shared/Models/pagination';
import { stock } from '../../shared/Models/stock';
@Injectable({
  providedIn: 'root'
})
export class StockService {

  
    baseUrl = "http://localhost:5282/api";
    private http = inject(HttpClient);
  
    getItems(){
      return this.http.get<pagination<stock>>(this.baseUrl + 'products')
    }

  constructor() { }
}
