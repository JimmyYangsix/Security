function checksign() {
    var psd=document.getElementsByClassName("psd");
    var show=document.getElementById("show");
    if(psd[0].value==psd[1].value)
    {
        show.innerHTML="密码一致";
    }
    else{
        show.innerHTML="密码不一致";
    }
}




//alert("注册成功")