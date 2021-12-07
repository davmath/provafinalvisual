import { Component, OnInit } from "@angular/core";
import { Funcionario } from "src/app/models/funcionario";
import { FuncionarioService } from "src/app/services/funcionario.service";

@Component({
    selector: "app-listar-produto",
    templateUrl: "./listar-produto.component.html",
    styleUrls: ["./listar-produto.component.css"],
})
export class ListarProdutoComponent implements OnInit {
    funcionarios: Funcionario[] = [];
    colunasExibidas: String[] = [
        "id",
        "nome",
        "cpf",
        "salario",
        "idade",
        "categoria",
    ];

    constructor(private service: FuncionarioService) {}

    ngOnInit(): void {
        this.service.list().subscribe((funcionarios) => {
            this.funcionarios = funcionarios;
        });
    }
}
