import { Funcionario } from "./funcionario";

export interface Folha {
    id?: number;
    ano: string;
    mes: string;
    valorHora: number;
    horasTrabalhadas: number;
    funcionario?: Funcionario;
    funcionarioId: number
    criadoem?: string

}
