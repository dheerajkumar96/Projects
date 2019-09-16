function CheckPassword()
{
    var a = document.getElementById("password");
    var decimal = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{8,15}$/;
    if (a.value.match(decimal)) {
        alert('strong password');
        return true;
    }
    else {
        alert('password should contain at least one lowercase letter, one uppercase letter, one numeric digit, and one special character');
        return false;
    }
} 