import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  template : "<html><body>{{ obterNome() }}</body></html>"
})

/* Nome das classes em maiusculo - Pascal Case */

export class ProdutoComponent {
  /*Camel case para variaveis, atributos e nomes das funções*/
  public nome: string;
  public liberadoParaVenda: boolean;


  public obterNome(): string {
    return "Samsung";
  }
}
