const abrirMenu = () => {
    const botao = document.querySelector(".menu-button");
    const menu = document.querySelector(".menu");

    if (menu.classList.contains("open-menu")) {
        menu.classList.remove("open-menu");
        menu.classList.add("close-menu");
        botao.style.display = "block";
    } else {
        menu.classList.remove("close-menu");
        menu.classList.add("open-menu");
        botao.style.display = "none";
    }
};
