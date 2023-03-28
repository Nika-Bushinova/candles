$(document).ready(function(){
   $('.slider').slick({
      arrows:true,
      dots:true,
      adaptiveHeight:false,
      slidesToShow:3,
      slidesToScroll:1,
      speed:1000,
      initialSlide:1,
      autoplay:false,
      autoplaySpeed:2000,
      infinite:true,
      pauseOnDotsHover:true,
      pauseOnFocus:true,
      waitForAnimate:false,
      centerMode:true,
      variableWidth:true
   })
});

$(document).ready(function() {
   $('.header__burger').click(function(event){
      $('.header__burger,.header__menu').toggleClass('_active');
   })
})

$(document).ready(function() {
   $('.header__close,.menu__link,section').click(function(event){
      $('.header__burger,.header__menu').removeClass('_active');
   })
})
/*
$(document).ready(function() {
   $('.first-button').click(function(event){
      $('.pop-up').toggleClass('_active-pop');
      let signBlock=document.querySelector('._active-pop')
      signBlock.style.height="360px"
      signBlock.style.zIndex="10"

   })
})

$(document).ready(function() {
   $('.preview,.steps,.destinations,.stories').click(function(event){
      $('.pop-up').removeClass('_active-pop');
   })
})
*/
