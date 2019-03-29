var index = {

    autenticar: function () {

        var dados = {
            usuario: fd.getValById("txtUsuario"),
            senha: fd.getValById("txtSenha")
        }


        fd.ajax("POST", "Login/Autenticar", dados, function (retornoServ) {

            if (retornoServ.operacao) {  
                alert("Autenticado com sucesso! ");
            }
            else {
                alert("Dados Inválidos! ");
            }

        }, function () {
            alert("Erro de Requisição.");
        });
    }


}

