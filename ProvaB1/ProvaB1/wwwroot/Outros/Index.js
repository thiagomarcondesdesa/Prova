var index = {

    logar: function () {

        var dados = {
            cpf: fd.getValById("txtUsuario"),
            senha: fd.getValById("txtSenha")
        }

        fd.getById("reqUsuario").style.display = "none";
        fd.getById("reqSenha").style.display = "none";

        if (dados.cpf == "") {
            fd.getById("reqUsuario").style.display = "inline";
        }

        if (dados.senha == "") {
            fd.getById("reqSenha").style.display = "inline";
        }

        if (dados.cpf == "" || dados.senha == "") {
            return;
        }


        fd.ajax("POST", "login/logar", dados, function (retornoServ) {

            //success

            if (retornoServ.operacao) {
                //redirect
                window.location.href = "home/index";
            }
            else {
                alert("Dados inválidos");
            }

        }, function () {//fail
            alert("Não foi possível processar sua requisição.");
        });
    }


}