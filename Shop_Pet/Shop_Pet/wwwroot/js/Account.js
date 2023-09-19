

    // let myBlock = document.querySelector(".login");
    // myBlock.classList.add("block");
    // function myClick() {
    //     myBlock.addEventListener("click", myBlock.classList.add("block"));
    // }
    const myBlock = document.querySelector(".sign");
    const myLine = document.querySelector(".login");
    if (myBlock) {
        myBlock.addEventListener("click", function () {
            document.querySelector(".login-form").style.display = "none";
            document.querySelector(".sign-up-form").style.display = "block";
        })
    }
    if (myLine) {
        myLine.addEventListener("click", function () {
            document.querySelector(".login-form").style.display = "block";
            document.querySelector(".sign-up-form").style.display = "none";
        })
    }