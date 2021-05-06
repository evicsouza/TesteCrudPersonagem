import { Component, OnInit } from '@angular/core';
import { PersonagemService } from '../shared/personagem.service';
import { Personagem } from '../shared/personagem.model';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-personagem-home',
  templateUrl: './personagem-home.component.html',
  styles: [
  ]
})
export class PersonagemHomeComponent implements OnInit {

  constructor(public service: PersonagemService,
    public toastr: ToastrService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }
  populateForm(selectedRecord: Personagem) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id: number) {
    if (confirm('Realmente deseja deletar esse personagem?')) {
      this.service.deletePersonagem(id)
        .subscribe(
          res => {
            this.service.refreshList();
            this.toastr.error("Deletado com sucesso", 'personagem  Register');
          },
          err => { console.log(err) }
        )
    }
  }

}
