import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class MainAppService {
  apiName = 'MainApp';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/MainApp/sample' },
      { apiName: this.apiName }
    );
  }
}
