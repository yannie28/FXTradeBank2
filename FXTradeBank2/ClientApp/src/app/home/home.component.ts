import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent{
  TradeBank: TradeBank[] = [];

  constructor(private http: HttpClient,@Inject('BASE_URL') baseURL: string) {
    http.get<TradeBank[]>(baseURL + 'api/TradeBank').subscribe(
      data => { this.TradeBank = data },
      error => console.error(error)
    );

  }

  public setAdjustedPPU(adjustedPPU: string, @Inject('BASE_URL') baseURL: string) {
    console.log(baseURL);
    this.http.post('/api/Adjustment', adjustedPPU).subscribe(
      data => { console.log(data) },
      error => console.error(error)
    );
  }
  
}

interface TradeBank {
  id: string;
  sourceCurrency: string;
  destinationCurrency: string;
  amount: number;
  status: string;
}
