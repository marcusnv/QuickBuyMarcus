import { Component, OnInit } from "@angular/core";
import { LojaCarrinhoComponent } from "../carrinho/loja.carrinho.component";
import { Produto } from "../../modelo/produto";
import { Pedido } from "../../modelo/pedido";
import { UsuarioServico } from "../../../servicos/usuario/usuario.servico";
import { ItemPedido } from "../../modelo/itemPedido";
import { PedidoServico } from "../../../servicos/pedido/pedido.servico";
import { Router } from "@angular/router";

@Component({
  selector: "loja-efetivar",
  templateUrl: "./loja.efetivar.component.html",
  styleUrls: ["./loja.efetivar.component.css"]
})

export class LojaEfetivarComponent implements OnInit {
  public lojaCarrinho: LojaCarrinhoComponent;
  public produtos: Produto[];
  public total: number;

  ngOnInit(): void {
    this.lojaCarrinho = new LojaCarrinhoComponent();
    this.produtos = this.lojaCarrinho.obterProdutos();
    this.atualizarTotal();
  }

  constructor(private usuarioServico: UsuarioServico, private pedidoServico: PedidoServico, private router: Router) {

  }

  public atualizarPreco(produto: Produto, quantidade: number) {
    if (!produto.precoOriginal) {
      produto.precoOriginal = produto.preco;
    }
    if (quantidade <= 0) {
      quantidade = 1;
      produto.quantidade = quantidade;
    }
    produto.preco = produto.precoOriginal * quantidade;

    this.lojaCarrinho.atualizar(this.produtos);
    this.atualizarTotal();
  }

  public remover(produto: Produto) {
    this.lojaCarrinho.removerProduto(produto);
    this.produtos = this.lojaCarrinho.obterProdutos();
    this.atualizarTotal();
  }

  public atualizarTotal() {
    this.total = this.produtos.reduce((acc, produto) => acc + produto.preco, 0);
  }

  public criarPedido(): Pedido {
    let pedido = new Pedido();
    pedido.usuarioId = this.usuarioServico.usuario.id;
    pedido.cep = "20735230";
    pedido.cidade = "Rio de Janeiro";
    
    pedido.dataPrevisaoEntrega = new Date();
    pedido.enderecoCompleto = "Rua Paulo Silva Araújo";
    pedido.estado = "RJ";
    pedido.formaPagamentoId = 1;
    pedido.numeroEndereco = "221";
    this.produtos = this.lojaCarrinho.obterProdutos();
    for (let produto of this.produtos) {
      let itemPedido = new ItemPedido();
      itemPedido.produtoId = produto.id;

      if (!produto.quantidade) {
        produto.quantidade = 1;
      }
      itemPedido.quantidade = produto.quantidade;
      pedido.itensPedido.push(itemPedido);
    }

    return pedido;
  }

  public efetivarComprar() {
    this.pedidoServico.efetivarComprar(this.criarPedido())
      .subscribe(
        pedidoId => {
          console.log(pedidoId);
          sessionStorage.setItem("pedidoId", pedidoId.toString());
          this.produtos = [];
          this.lojaCarrinho.limparCarrinhoCompras();
          this.router.navigate(["/compra-realizada-sucesso"]);
        },
        e => {
          console.log(e.error);
        });

  }

}
