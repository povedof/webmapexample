
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as WindowsFormsApp1 from './components/windows-forms-app1';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
  ],
  exports: [
    WindowsFormsApp1.Form1Component,
  ],
  declarations: [
    WindowsFormsApp1.Form1Component,
  ],
  bootstrap: [
    WindowsFormsApp1.Form1Component,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class WindowsFormsApp1Module { }
