import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Categoria } from "src/app/models/categoria";
import { Funcionario } from "src/app/models/funcionario";
import { CategoriaService } from "src/app/services/categoria.service";
import { FuncionarioService } from "src/app/services/funcionario.service";

@Component({
    selector: "app-cadastrar-produto",
    templateUrl: "./cadastrar-produto.component.html",
    styleUrls: ["./cadastrar-produto.component.css"],


})
export class CadastrarFuncionarioComponent implements OnInit {
    nome!: string;
    cpf!: string;
    idade!: number;
    salario!: number;
    categorias!: Categoria[];
    categoriaId!: number;

    constructor(
        private router: Router,
        private funcionarioService: FuncionarioService,
        private categoriaService: CategoriaService
    ) {}

    ngOnInit(): void {
        this.categoriaService.list().subscribe((categorias) => {
            this.categorias = categorias;
        });
    }
    

    cadastrar(): void {
        let funcionario: Funcionario = {
            nome: this.nome,
            cpf: this.cpf,
            salario: this.salario,
            idade: this.idade,
            categoriaId: this.categoriaId,
        };
        this.funcionarioService.create(funcionario).subscribe((funcionario) => {
            console.log(funcionario);
            this.router.navigate(["funcionario/listar"]);
        });
    }
}
