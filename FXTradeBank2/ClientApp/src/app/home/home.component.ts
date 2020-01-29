import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  TradeBank: TradeBank2[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseURL: string) {
    http.get<TradeBank2[]>(baseURL + 'api/TradeBank').subscribe(
      data => { this.TradeBank = data },
      error => console.error(error)
    );
  }

}

interface TradeBank2 {
  id: string;
  sourceCurrency: string;
  destinationCurrency: string;
  amount: number;
  status: string;
}
