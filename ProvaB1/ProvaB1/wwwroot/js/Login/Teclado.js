var tecla = {
    capturar: function (NomeCampo) {
        fd.getById("txtSenha").value = fd.getById("txtSenha").value + fd.getById(NomeCampo).value;
    }

}

