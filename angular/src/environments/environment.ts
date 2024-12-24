 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44311/',
  redirectUri: baseUrl,
  clientId: 'AngulareTestProject_App',
  responseType: 'code',
  scope: 'offline_access AngulareTestProject',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AngulareTestProject',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44311',
      rootNamespace: 'Acme.AngulareTestProject',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
