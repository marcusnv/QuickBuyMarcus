/* Nome das classes em maiusculo - Pascal Case */
export class ProdutoComponent {
  /*Camel case para variaveis, atributos e nomes das funções*/
  public nome: string;
  public liberadoParaVenda: boolean;


  public obterNome(): string {
    return this.nome;
  }
}
