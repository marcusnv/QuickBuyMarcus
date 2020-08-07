import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;

  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {

    }

  public enderecoImagem = "https://img2.gratispng.com/20180727/sfz/kisspng-logo-best-buy-brand-bouy-5b5be347df40a9.7352804615327486159145.jpg";
  public titulo = "BEST BUY Marcus";

}

