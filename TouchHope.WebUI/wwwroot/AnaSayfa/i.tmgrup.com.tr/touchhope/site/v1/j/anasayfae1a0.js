﻿$(function(){$(".go-scroll").click(function(o){if(o.stopPropagation(),o.preventDefault(),$(".navbar-collapse.in").collapse("hide"),null!=$(this).data("target")){var t=$("#"+$(this).data("target"));$("html, body").animate({scrollTop:t.offset().top-50},750,function(){$("html>body").scrollTop()!=t.offset().top-50&&(console.log("-- 1 -- ",t.offset().top-50),$("html, body").animate({scrollTop:t.offset().top-50},100))})}});var o=function(o){var t,e,i=decodeURIComponent(window.location.search.substring(1)).split("&");for(e=0;e<i.length;e++)if((t=i[e].split("="))[0]===o)return void 0===t[1]||t[1]}("link");if(""==!o){var t=$("#"+o);$("html, body").animate({scrollTop:t.offset().top-50},750,function(){$("html>body").scrollTop()!=t.offset().top-50&&(console.log("-- 1 -- ",t.offset().top-50),$("html, body").animate({scrollTop:t.offset().top-50},100))})}});var swiperBigNews=new Swiper(".card-news-big-slider-cover .swiper-container",{paginationClickable:!0,nextButton:".swiper-button-next",prevButton:".swiper-button-prev",loop:!0,slidesPerView:1,slidesPerGroup:1,spaceBetween:0,lazyLoading:!0,pagination:".swiper-pagination",paginationClickable:!0});