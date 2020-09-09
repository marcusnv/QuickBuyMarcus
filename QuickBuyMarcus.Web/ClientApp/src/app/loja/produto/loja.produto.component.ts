import { Component, OnInit } from "@angular/core";
import { ProdutoServico } from "../../../servicos/produto/produto.servico";
import { Produto } from "../../modelo/produto";
import { Router } from "@angular/router";
import { LojaCarrinhoComponent } from "../carrinho/loja.carrinho.component";

@Component({
  selector: "loja-app-produto",
  templateUrl: "./loja.produto.component.html",
  styleUrls: ["./loja.produto.component.css"]
})

export class LojaProdutoComponent implements OnInit {
  public produto: Produto;
  public carrinhoCompras: LojaCarrinhoComponent;


  ngOnInit(): void {
    this.carrinhoCompras = new LojaCarrinhoComponent();
    var produtoDetalhe = sessionStorage.getItem('produtoDetalhe');
    if (produtoDetalhe) {
      this.produto = JSON.parse(produtoDetalhe);
    }
  }

  constructor(private produtoServico: ProdutoServico, private router: Router) {

  }

  public comprar() {
    this.carrinhoCompras.adicionar(this.produto);
    this.router.navigate(["/loja-efetivar"]);
  }

}
