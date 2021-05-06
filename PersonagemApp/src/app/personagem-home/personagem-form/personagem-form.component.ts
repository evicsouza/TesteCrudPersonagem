import { Component, OnInit } from '@angular/core';
import { PersonagemService } from 'src/app/shared/personagem.service';
import { NgForm } from '@angular/forms';
import { Personagem } from 'src/app/shared/personagem.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-personagem-form',
  templateUrl: './personagem-form.component.html',
  styles: [
    "../node_modules/bootstrap/dist/css/bootstrap.min.css"
  ]
})
export class PersonagemFormComponent implements OnInit {

  constructor(public service: PersonagemService,
    public toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    if (this.service.formData.id == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postPersonagem().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success('Submitted successfully', 'Personagem adicionado')
      },
      err => { console.log(err); }
    );
  }

  updateRecord(form: NgForm) {
    this.service.putPersonagem().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.info('Updated successfully', 'Personagem atualizado')
      },
      err => { console.log(err); }
    );
  }
  
  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Personagem();
  }
}
