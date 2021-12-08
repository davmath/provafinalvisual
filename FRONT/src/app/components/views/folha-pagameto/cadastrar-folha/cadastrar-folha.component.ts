import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Folha } from 'src/app/models/folha';
import { Funcionario } from 'src/app/models/funcionario';
import { CategoriaService } from 'src/app/services/categoria.service';
import { FolhaService } from 'src/app/services/folha.service';
import { FuncionarioService } from 'src/app/services/funcionario.service';

@Component({
  selector: 'app-cadastrar-folha',
  templateUrl: './cadastrar-folha.component.html',
  styleUrls: ['./cadastrar-folha.component.css']
})
export class CadastrarFolhaComponent implements OnInit {

  ano!: string;
  mes!: string;
  valorHora!: number;
  horasTrabalhadas!: number;
  funcionarios!: Funcionario[];
  funcionarioId!: number
  

  constructor(private router: Router, private folhaService: FolhaService, private funcionarioService: FuncionarioService) { }

  ngOnInit(): void {

    this.funcionarioService.list().subscribe((funcionarios)=>{
      this.funcionarios = funcionarios;
    });
 
  }
  cadastrar(): void {
    let folha: Folha = {
        ano: this.ano,
        mes: this.mes,
        valorHora: this.valorHora,
        horasTrabalhadas: this.horasTrabalhadas,
        funcionarioId: this.funcionarioId,
    };
    this.folhaService.create(folha).subscribe((folha) => {
        console.log(folha);
        this.router.navigate(["funcionario/listar"]);
    });
  }
}
