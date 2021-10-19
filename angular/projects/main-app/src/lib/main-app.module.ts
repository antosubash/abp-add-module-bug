import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { MainAppComponent } from './components/main-app.component';
import { MainAppRoutingModule } from './main-app-routing.module';

@NgModule({
  declarations: [MainAppComponent],
  imports: [CoreModule, ThemeSharedModule, MainAppRoutingModule],
  exports: [MainAppComponent],
})
export class MainAppModule {
  static forChild(): ModuleWithProviders<MainAppModule> {
    return {
      ngModule: MainAppModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<MainAppModule> {
    return new LazyModuleFactory(MainAppModule.forChild());
  }
}
