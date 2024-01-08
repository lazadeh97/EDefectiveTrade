/*
=====================================================
                    =    main scripts starts   =
=====================================================
*/
$(".six-carousel").owlCarousel({
  loop: true,
  margin: 24,
  nav: true,
  dots: false,
  navText: [
    '<img src="assets/img/right_arrow.svg" alt="right"/>',
    ' <img class="rotate-180" src="assets/img/right_arrow.svg" alt="left"/>',
  ],
  responsive: {
    0: {
      items: 1,
    },
    600: {
      items: 4,
    },
    1000: {
      items: 6,
    },
  },
});

$(".product-list .product-item").on("click", function () {
  let _this = $(this),
    _img = _this.find("img");

  $(".product-list .product-item").removeClass("active");
  _this.addClass("active");
  $(".main-img img").attr("src", _img.attr("src"));
});

$(".hamburger").on("click", function () {
  $("header").toggleClass('active')
});