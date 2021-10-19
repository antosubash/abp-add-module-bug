import { Component, OnInit } from '@angular/core';
import { MainAppService } from '../services/main-app.service';

@Component({
  selector: 'lib-main-app',
  template: ` <p>main-app works!</p> `,
  styles: [],
})
export class MainAppComponent implements OnInit {
  constructor(private service: MainAppService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
