import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../../servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string;
  public mensagem: string;
  public ativar_spinner: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
              private usuarioServico: UsuarioServico) {
  }
    ngOnInit(): void {
      this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario();
    }

  entrar() {
    this.ativar_spinner = true;
    this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(
        usuario_json => {
          // será executada no caso de retorno sem erros
          this.usuarioServico.usuario = usuario_json;

          if (this.returnUrl == null) {
            this.router.navigate(['/']);
          }
          else {
            this.router.navigate([this.returnUrl]);
          }
        },
        err => {
          console.log(err.error);
          this.mensagem = err.error;
          this.ativar_spinner = false;
        }
    );

    //if (this.usuario.email == "teste@teste.com.br" && this.usuario.senha == "123456") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);
  }
  public enderecoImagem = "https://img2.gratispng.com/20180727/sfz/kisspng-logo-best-buy-brand-bouy-5b5be347df40a9.7352804615327486159145.jpg";
  public titulo = "BEST BUY Marcus";

  }



