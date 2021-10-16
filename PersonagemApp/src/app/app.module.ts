import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { PersonagemHomeComponent } from './personagem-home/personagem-home.component';
import { PersonagemFormComponent } from './personagem-home/personagem-form/personagem-form.component';
import { HttpClientModule } from '@angular/common/http';
import { PersonagemListagemComponent } from './personagem-listagem/personagem-listagem.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonagemHomeComponent,
    PersonagemFormComponent,
    PersonagemListagemComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
