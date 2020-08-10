import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;

  constructor(private router: Router) {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "teste@teste.com.br" && this.usuario.senha == "123456") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate(['/'])
    }
    }

  public enderecoImagem = "https://img2.gratispng.com/20180727/sfz/kisspng-logo-best-buy-brand-bouy-5b5be347df40a9.7352804615327486159145.jpg";
  public titulo = "BEST BUY Marcus";

}

