import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { pagination } from '../../shared/Models/pagination';
import { battleStat } from '../../shared/Models/battleStat';
@Injectable({
  providedIn: 'root'
})
export class StatService {

  
    baseUrl = "http://localhost:5282/api";
    private http = inject(HttpClient);
  
    getItems(){
      return this.http.get<pagination<battleStat>>(this.baseUrl + 'products')
    }

  constructor() { }
}
