var swiper = new Swiper(".Section-Banner-principal .mySwiper", {
    scrollbar: {
        el: ".Section-Banner-principal .swiper-scrollbar",
        hide: true,
    },
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
    autoplay: {
        delay: 3500, // Tiempo entre transiciones (en milisegundos)
        disableOnInteraction: false, // Si se establece en true, el autoplay se detendrá después de la primera interacción del usuario
    }
});