import { Categoria } from "./categoria";

export interface Funcionario {
    id?: number;
    nome: string;
    cpf: string;
    idade: number;
    salario: number;
    criadoem?: string;
    categoriaId: number;
    categoria?: Categoria;
}
