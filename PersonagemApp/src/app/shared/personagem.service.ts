import { Injectable } from '@angular/core';
import { Personagem } from './personagem.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class PersonagemService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'http://localhost:61236/api/Personagem'
  formData: Personagem = new Personagem();
  list: Personagem[];

  postPersonagem() {
    return this.http.post(this.baseURL, this.formData);
  }

  putPersonagem() {
    return this.http.put(`${this.baseURL}/${this.formData.id}`, this.formData);
  }

  deletePersonagem(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  refreshList() {
    this.http.get(this.baseURL)
      .toPromise()
      .then(res =>this.list = res as Personagem[]);
  }


}
