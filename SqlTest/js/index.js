function LookUp(e) {
    var message = e.value;
    if (e.type == "text") {
        document.getElementById("output").value += "账号:" + message +"                      ";
    }
    else {
        document.getElementById("output").value += "密码:" + message;
    }
}