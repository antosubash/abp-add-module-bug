import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'MainApp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44324',
    redirectUri: baseUrl,
    clientId: 'MainApp_App',
    responseType: 'code',
    scope: 'offline_access MainApp',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44324',
      rootNamespace: 'MainApp',
    },
    MainApp: {
      url: 'https://localhost:44398',
      rootNamespace: 'MainApp',
    },
  },
} as Environment;
