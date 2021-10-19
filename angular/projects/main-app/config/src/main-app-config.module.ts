import { ModuleWithProviders, NgModule } from '@angular/core';
import { MAIN_APP_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class MainAppConfigModule {
  static forRoot(): ModuleWithProviders<MainAppConfigModule> {
    return {
      ngModule: MainAppConfigModule,
      providers: [MAIN_APP_ROUTE_PROVIDERS],
    };
  }
}
