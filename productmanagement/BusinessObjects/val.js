function VForm(e) {
    var isvalid = true;
    // check that a valid email address has been entered
    var eidrex = /[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}/;
    if (!eidrex.test(String($("#eid").val()).toUpperCase())) {
        errmsg("eid", "You would have to enter a valid email address.");
        isvalid = false;
    } else {
        errrmv("eid");
    }
    // check that first name has one or more characters
    var fn = /^[a-zA-z]/;
    if ($("#fntxt").val() == '') {
        errmsg("fntxt", "Text Box is Empty Field Required.");
        isvalid = false;
    else if (!fn.test(String($("#fntxt").val()))) {
            errmsg("fntxt", "Please Enter the only alphabetic value.");
            isvalid = false;
        }
        else {
            removeError("fntxt");
        }
        var ln = /^[a-zA-z]/;
        if ($("#lntxt").val() == '') {
            errmsg("lntxt", "Text Box is Empty Field Required.");
            isvalid = false;
    else if (!ln.test(String($("#lntxt").val()))) {
                errmsg("lntxt", "Please Enter the only alphabetic value.");
                isvalid = false;
            }
        }
        else {
            errrmv("lntxt");
        }
        if (!isvalid) {
            e.preventDefault();
        }
        var pwd = /^[A-Za-z]\w{6,}[A-Za-z]$/;
        if (!pwd.test(String($("pdtxt").val()))) {
            errmsg("pdtxt", "password must be at least 8 characters long and start and end with a letter.");
            isvalid = false;
        } else {
            errrmv("pdtxt");
        }
    }
    function errmsg(id, msg) {
        if ($("#" + id).parent().find("label[class=error]").attr("generated") == "true") {
            $("#" + id).parent().find("label[class=error]").css("display", "block");
        } else {
            $("#" + id).parent().append(<label for="' + id + '" generated="true" class="error">' + msg + ' </label>').css("display", "block");
    }
    }
    function errrmv(id) {
        $("#" + id).parent().find("label[class=error]").css("display", "none");
    }
}