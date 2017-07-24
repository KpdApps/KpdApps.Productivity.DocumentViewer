import { NgModule } from '@angular/core';

import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { MdListModule } from '@angular/material';
import { MaterialModule } from '@angular/material';

import { FileDropzoneModule } from 'angular-file-dropzone';

import { AppComponent } from './app.component';

@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        MdListModule,
        MaterialModule,
        FileDropzoneModule
    ],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule { }
