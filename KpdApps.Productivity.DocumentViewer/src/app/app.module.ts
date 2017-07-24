﻿import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { MdListModule } from '@angular/material';
import { MaterialModule } from '@angular/material';

@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        MdListModule,
        MaterialModule
    ],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule { }
