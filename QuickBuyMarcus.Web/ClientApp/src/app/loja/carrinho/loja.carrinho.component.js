"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var LojaCarrinhoComponent = /** @class */ (function () {
    function LojaCarrinhoComponent() {
        this.produtos = [];
    }
    LojaCarrinhoComponent.prototype.adicionar = function (produto) {
        var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
        if (!produtoLocalStorage) {
            this.produtos.push(produto);
        }
        else {
            this.produtos = JSON.parse(produtoLocalStorage);
            this.produtos.push(produto);
        }
        localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));
    };
    LojaCarrinhoComponent.prototype.obterProdutos = function () {
        var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
        if (produtoLocalStorage) {
            return JSON.parse(produtoLocalStorage);
        }
    };
    LojaCarrinhoComponent.prototype.removerProduto = function (produto) {
        var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
        if (produtoLocalStorage) {
            this.produtos = JSON.parse(produtoLocalStorage);
            this.produtos = this.produtos.filter(function (p) { return p.id != produto.id; });
            localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));
        }
    };
    LojaCarrinhoComponent.prototype.atualizar = function (produtos) {
        localStorage.setItem("produtoLocalStorage", JSON.stringify(produtos));
    };
    LojaCarrinhoComponent.prototype.ngOnInit = function () {
    };
    return LojaCarrinhoComponent;
}());
exports.LojaCarrinhoComponent = LojaCarrinhoComponent;
//# sourceMappingURL=loja.carrinho.component.js.map