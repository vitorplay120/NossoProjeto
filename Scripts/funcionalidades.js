
var usuario = {

    serverCall: function (url, data, complete) {

        let formdata = new FormData();

        if (!(data instanceof FormData)) {
            data = data.split('&');
            for (var i = 0; i < data.length; i++) {
                if (data[i] != "") {
                    let nomevalor = data[i].split('=');
                    if (nomevalor.length > 1) {
                        formdata.append(nomevalor[0], nomevalor[1]);
                    }
                }
            }
        } else {
            formdata = data;
        }
        //    var content = "";
        //    data.append("isAjax", "true");
        //    data.forEach(function (value, key) {
        //        if (content != "") content += "&";
        //        content += key + "=" + value;
        //    })
        //    data = content;
        //} else {
        //    data = "isAjax=true&" + data
        //}

        formdata.append("isAjax", "true");



        $.ajax({
            url: url,
            data: formdata,
            processData: false,
            contentType: false,
            type: 'POST',



            //success: function (msg) {

            //    complete(msg, true);
            //    aplicarMascaras();
            //    Loading.hide();

            //},
            //fail: function (xhr, status, error) {

            //    console.log(xhr);
            //    if (xhr.status == 401) {
            //        window.location.reload(true);
            //        return;
            //    }
            //    complete(xhr.responseText, false);

            //},


        }).done(function (msg) {

            complete(msg, true);
            //aplicarMascaras();
            //Loading.hide();

        }).fail(function (xhr, status, error) {

            console.log(xhr);
            if (xhr.status == 401) {
                window.location.reload(true);
                return;
            }
            complete(xhr.responseText, false);

        }).always(function () {

            //Loading.hide();

        });



    }


}


function validateForm() {
    var xnome = document.forms["enviaremail"]["nome"].value;
    var xemail = document.forms["enviaremail"]["email"].value;
    var xmsg = document.forms["enviaremail"]["msg"].value;

    var retorno = true;

    if (xnome == "") {
        document.getElementById("name").style.border = "red solid 4px";
        //$("input[name='nome']").addClass("validacaoinput");
        retorno = false;
    }


    if (xemail == "") {
        document.getElementById("email").style.border = "red solid 4px";
        retorno = false;
    }

    if (xmsg == "") {
        document.getElementById("mensagem").style.border = "red solid 4px";
        //$("#mensagem").addClass("validacaoinput");
        retorno = false;
    }

    return retorno;
};


function emailMask(email) {
    var maskedEmail = email.replace(/([^@\.])/g, "*").split('');
    var previous = "";
    for (i = 0; i < maskedEmail.length; i++) {
        if (i <= 1 || previous == "." || previous == "@") {
            maskedEmail[i] = email[i];
        }
        previous = email[i];
    }
    return maskedEmail.join('');
};

