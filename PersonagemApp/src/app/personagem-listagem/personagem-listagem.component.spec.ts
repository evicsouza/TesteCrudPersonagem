import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonagemListagemComponent } from './personagem-listagem.component';

describe('PersonagemListagemComponent', () => {
  let component: PersonagemListagemComponent;
  let fixture: ComponentFixture<PersonagemListagemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonagemListagemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonagemListagemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
