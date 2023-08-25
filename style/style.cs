@charset "UTF-8";
/*--------------обнуление-------------*/
* {
  padding: 0;
  margin: 0;
  border: 0;
}

*,
*:before,
*:after {
  -moz-box-sizing: border-box;
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

:focus,
:active {
  outline: none;
}

a:active {
  outline: none;
}

nav,
footer,
header,
aside {
  display: block;
}

html,
body {
  height: 100%;
  width: 100%;
  font-size: 100%;
  line-height: 1;
  font-size: 14px;
  -ms-text-size-adjust: 100%;
  -moz-text-size-adjust: 100%;
  -webkit-text-size-adjust: 100%;
  color: #1B2618;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 24px;
}

body {
  margin: 0px;
}

.form__body::after {
  content: "";
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: rgba(51, 51, 51, 0.9);
  opacity: 0;
  visibility: hidden;
  transition: all 0.5s ease 0s;
}

.form__body._sending::after {
  opacity: 1;
  visibility: visible;
}

input,
button,
textarea {
  font-family: inherit;
}

input::-ms-clear {
  display: none;
}

button {
  cursor: pointer;
}

button::-moz-focus-inner {
  padding: 0;
  border: 0;
}

a,
a:visited {
  text-decoration: none !important;
  color: #1B2618;
  transition: all 0.5s ease 0s;
}

a:hover {
  text-decoration: none;
}

ul li {
  list-style: none;
}

img {
  vertical-align: top;
}

p + span {
  color: gray;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 18px;
  margin-top: 10px;
}

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: 700;
  margin: 0px;
}

/*-----------общие параметры страницы----------*/
*,
:after,
:before {
  box-sizing: border-box;
}

html {
  scroll-behavior: smooth;
}

body {
  background-color: #E6E6E6;
  margin: 0px;
}

.wrapper {
  min-height: 100%;
  display: flex;
  flex-direction: column;
}

.container {
  max-width: 1440px;
  margin: 0px auto;
  align-items: center;
}

/*------------------------------------header-----------------------*/
.header__container {
  max-height: 90px;
  display: flex;
  flex-wrap: nowrap;
  font-size: 16px;
  text-transform: capitalize;
  font-family: "Red Hat Text";
  color: #1B2618;
  background: linear-gradient(rgba(255, 182, 193, 0.9), rgba(40, 140, 255, 0));
  z-index: 10;
  position: relative;
  box-shadow: 0px 4px 5px #FFC0CB;
  font-weight: 800;
}

.header__burger, .header__empty {
  display: none;
}

.header__logo, .footer__logo {
  position: relative;
  margin-left: 10.9%;
  padding: 32px 0px 34px 0px;
  font-size: 32px;
  font-family: "Disruptors Script";
  font-weight: 500;
  transition: all 0.2s;
  vertical-align: top;
  text-align: center;
  line-height: 20px;
}

.header__logo:hover {
  text-shadow: 0px 4px 3px rgba(0, 0, 0, 0.5);
}

.header__logo:hover::before {
  filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5));
}

.header__menu {
  margin: 0 auto;
  align-items: center;
  max-width: 100%;
}

.menu__list {
  display: flex;
  flex-wrap: wrap;
  padding: 0px;
  font-family: "Comfortaa";
}

.menu__item:not(:last-child) {
  margin-right: 42px;
}

.menu__item:nth-child(5), .menu__item:nth-child(6) {
  display: none;
}

.menu__item {
  transition: all 0.6s;
}

.menu__item:hover {
  transform: scale(1.2);
}

.menu__link {
  transition: all 0.5s;
  color: #1B2618;
}

.menu__link:hover {
  color: #FFC0CB;
  text-shadow: 0px 4px 3px rgba(0, 0, 0, 0.5);
}

.button__all {
  background-color: #DB7093;
  font-weight: 500;
  color: white !important;
  border: 0px;
  border-radius: 10px;
  font-size: 16px;
  font-family: "Comfortaa";
  padding: 10px 30px;
  text-transform: capitalize;
  transition: color 1s, background-color 1s, box-shadow 0.2s;
}

.button__all a {
  color: white !important;
}

.button__all:hover {
  background-color: #DB7093 !important;
  transform: scale(1.1);
  transition: all 0.5s ease 0s;
  color: #FFC0CB;
}

.button__all:active {
  box-shadow: 0 0 20px 0 #FFC0CB inset, 0 0 30px 10px #FFC0CB;
}

.header__button a:visited, .button__all a:visited {
  color: white !important;
}

.header__button {
  padding: 10px 10px 10px 30px;
  margin-right: 7.6%;
}

.first-button {
  box-shadow: 0px 4px 3px rgba(0, 0, 0, 0.2);
}

/*-------------------------------------------------------------section 1 --------------------------------------------------*/
.preview__container {
  display: flex;
  min-height: 765px;
  background-color: #FFFFFF;
  padding: 150px 10% 190px 10%;
}

.preview__common {
  position: relative;
  z-index: 1;
  top: -140px;
  border-radius: 16px;
}

.preview__second {
  position: absolute;
  left: 40%;
  z-index: 0;
}

.preview__common h1 + p {
  font-family: "Comfortaa";
  font-weight: 700;
  font-size: 20px;
  line-height: 24px;
  color: #1B2618;
  margin-top: 0px;
  transition: all 0.3s;
}

.preview__common h1:hover, .preview__common h1 + p:hover {
  color: #DB7093;
  text-shadow: 0px 4px 3px rgba(0, 0, 0, 0.5);
}

.preview__planning {
  margin-top: 46px;
}

.start-planning {
  font-size: 24px;
  padding: 14px 34px;
}

.main__img_first {
  border-radius: 70% 0% 0% 0%;
  border: 1px solid #FFC0CB;
  position: relative;
  z-index: 2;
  width: 300px;
  height: 250px;
  bottom: -20px;
  right: -20px;
}

.main__image_first {
  margin-left: 40%;
  background: url("../img/light.jpg") 0px/400px 350px no-repeat;
  border-radius: 60% 0% 0% 0%;
  width: 300px;
  height: 250px;
}

.main__img_second {
  display: flex;
}

.main__image_third {
  border-radius: 0% 0% 0% 70%;
  border: 1px solid #FFC0CB;
  position: relative;
  z-index: 2;
  width: 350px;
  height: 300px;
  bottom: -20px;
  left: -20px;
}

.main__image_forth {
  background: url("../img/second.jpeg") 0/300px 300px;
  width: 300px;
  height: 300px;
  border-radius: 50%;
  margin-top: 60px;
}

/*----------------------------------------------section 2 ----------------------------------------------*/
.steps__container {
  background-color: #FFFFFF;
  padding: 90px 10% 90px;
}

.steps__first {
  margin: 0px auto;
}

.steps__icons {
  display: flex;
  flex-wrap: nowrap;
  justify-content: space-between;
  flex-shrink: 1;
}

.steps__icons div:nth-child(2) {
  margin-left: 5.8%;
}

h2 {
  font-family: "Marck+Script&display";
  font-style: normal;
  font-weight: 500;
  font-size: 40px;
  line-height: 53px;
  margin-bottom: 40px;
  color: #FFC0CB;
  transition: all 0.5s ease 0s;
}

h2:hover {
  color: #FFC0CB;
  text-shadow: 0px 4px 3px #DB7093;
}

.steps__icon {
  text-align: center;
}

.steps__icon img {
  padding: 40px 0px 30px;
  transition: all 0.5s ease 0s;
}

.steps__icon img:hover {
  transform: scale(1.3);
  filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5));
}

.steps__icon p {
  font-family: "Comfortaa";
  font-style: normal;
  font-weight: 400;
  font-size: 20px;
  line-height: 24px;
  color: #0D606F;
  transition: all 0.3s;
}

.steps__icon p:hover {
  transform: scale(1.3);
}

/*-------------------------------------------------------destinations---------*/
.destinations__container {
  padding: 90px 10% 90px 10%;
  background-color: #FFFFFF;
}

/*-------------------------слайдер-----------------*/
.slider {
  position: relative;
}

.slider img {
  width: 300px;
  height: 300px;
  object-fit: cover;
}

.slider__text {
  color: #1B2618;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 24px;
  margin-top: 10px;
}

.slider__text span {
  color: gray;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 18px;
  margin-top: 10px;
}

/* Слайдер */
/* Слайдер запущен */
/* Слайдер с точками */
/* Ограничивающая оболочка */
.slick-list {
  overflow: hidden;
}

/* Лента слайдов */
.slick-track {
  display: flex;
  align-items: flex-end;
  align-items: flex-start; /*адаптивная высота для слайдера*/
}

/* Слайд */
.slick-slide {
  margin: 0px 60px 20px 0px;
  width: 300px !important;
}

/* Слайд активный (показывается) */
/* Слайд основной */
.slick-slide.slick-current {
  opacity: 1;
}

.slider__item {
  text-align: center;
  display: flex;
  flex-direction: column-reverse;
  padding-top: 20px;
}

/* Слайд по центру */
/* Клонированный слайд */
/* Стрелка */
.slider .slick-arrow {
  position: absolute;
  z-index: 5;
  top: 0%;
  font-size: 0;
  width: 5%;
  height: 100%;
}

/* Стрелка влево */
.slick-arrow.slick-prev {
  top: 40%;
  left: -10%;
  background: url(../img/arrow-left.svg) 0 0/90% no-repeat;
}

/* Стрелка вправо */
.slick-arrow.slick-next {
  top: 40%;
  right: -10%;
  background: url(../img/arrow-right.svg) 0 0/90% no-repeat;
}

/* Стрелка не активная */
/* Точки (булиты) */
.slider .slick-dots {
  display: flex;
  align-items: center;
  justify-content: center;
  padding-bottom: 90px;
}

/* Активная точка */
.slider .slick-dots li.slick-active {
  background-color: #FFC0CB;
}

/* Элемент точки */
.slider .slick-dots li button {
  font-size: 0;
}

.slider .slick-dots li {
  width: 20px;
  height: 20px;
  border-radius: 50%;
  background-color: #ECEAEB;
}

.slider .slick-dots li:not(:last-child) {
  margin-right: 10px;
}

.img__circle {
  border-radius: 50% !important;
  height: 300px;
}

.img__circle_div {
  width: 300px;
  height: 300px;
  border: 1px solid #FFC0CB;
  position: absolute;
  top: 0px;
  border-radius: 50%;
}

.img__square-circle {
  border-radius: 0% 50% 0% 0% !important;
  height: 300px;
}

/*---------------------------------------------------------------------------*/
.info__candles {
  background: rgb(236, 234, 235);
  display: flex;
  justify-content: space-between;
}

.info__img {
  min-width: 300px;
  height: inherit;
  background: url("../img/forth.jpeg") 0px -40px/cover no-repeat;
}

.info__form {
  min-width: 50%;
  margin-left: 40px;
}

.candle4 img {
  border-radius: 50%;
  min-width: 300px;
  min-height: 300px;
  margin-top: -20px;
}

/*-----------------------------------------------stories----------------------*/
.stories__container, .subscribe__email {
  background-color: #FFFFFF;
  padding: 0px 10% 90px;
}

.stories__first {
  display: flex;
  justify-content: space-between;
  position: relative;
  margin-bottom: 40px;
  align-items: flex-end;
}

.stories__first p, .stories__second p {
  padding-top: 20px;
}

.stories__first ul, .stories__second ul, .stories__first li, .stories__second li {
  color: gray;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 18px;
  margin-top: 10px;
}

.stories__first div:hover, .stories__second div:hover {
  transform: scale(1.1);
  transition: all 0.5s ease 0s;
}

.img__square {
  width: 300px;
  height: 350px;
}

.img__square-circle {
  background: url(../img/fifth.jpg) 0/300px 300px;
  width: 350px;
  height: 350px;
  border-radius: 0% 70% 0% 0% !important;
  z-index: 0;
  position: relative;
}

.stories__second {
  position: relative;
  display: flex;
  justify-content: space-between;
  margin-bottom: 40px;
  align-items: flex-end;
}

.img__square-circle-down {
  background: url(../img/fifth.jpg) 0/600px 600px;
  width: 350px;
  height: 300px;
  border-radius: 0% 0% 70% 0% !important;
  z-index: 0;
  position: relative;
}

.img__square-circle-border-down {
  border-radius: 0% 0% 70% 0%;
  border: 1px solid #FFC0CB;
  position: absolute;
  z-index: 2;
  width: 350px;
  height: 300px;
  top: 20px;
  left: 20px;
}

.stories__first_border_radius {
  position: relative;
}

.img__square-circle-border {
  border-radius: 0% 70% 0% 0%;
  border: 1px solid #FFC0CB;
  position: absolute;
  z-index: 2;
  width: 350px;
  height: 350px;
  top: -20px;
  left: 20px;
}

.img__square-circle-top {
  background: url(../img/fifth.jpg) 0/300px 300px;
  width: 350px;
  height: 300px;
  border-radius: 70% 0% 0% 0% !important;
  z-index: 0;
  position: relative;
}

.img__square-circle-border-top {
  border-radius: 70% 0% 0% 0%;
  border: 1px solid #FFC0CB;
  position: absolute;
  z-index: 2;
  width: 350px;
  height: 300px;
  top: -20px;
  right: 20px;
}

/*-------------------------------------subscribe-----------------------------------------*/
.subscribe__email {
  background-color: #ECEAEB;
  text-align: center;
}

.subscribe__email {
  padding: 20px 10%;
}

.subscribe__email h2 {
  margin-bottom: 20px;
}

.textarea__ask {
  background-color: #ECEAEB;
  border-bottom: 1px solid #FFC0CB;
  resize: none;
  line-height: 20px;
  margin: 30px 0px;
  width: 90%;
}
.textarea__ask a {
  font-size: 20px;
}

.info__form {
  position: relative;
}

.info__form .email:hover::after, .info__form .phone:hover::after {
  transform: rotate(20deg);
}

.info__form .email::after {
  content: "";
  position: absolute;
  width: 30px;
  height: 30px;
  background: url("../img/email.svg") 0/20px 20px no-repeat;
  right: 0px;
  transition: all 0.2s ease-in-out;
}

.info__form .phone::after {
  content: "";
  position: absolute;
  width: 30px;
  height: 30px;
  background: url("../img/phone.svg") 0/20px 20px no-repeat;
  right: 0px;
  transition: all 0.2s ease-in-out;
}

.info__text img {
  width: 40px;
  height: 40px;
  vertical-align: -7px;
  margin-right: 10px;
  padding: 10px;
}

.subscribe__text {
  display: flex;
  padding: 0px 0px 40px;
  color: #1B2618;
  font-family: "Comfortaa";
  font-weight: 500;
  margin-top: 10px;
  font-size: 20px;
}

/*-------------------------------------------------------------------------------------------------------*/
.slider__container {
  padding: 90px 10% 90px 10%;
  background-color: #FFFFFF;
}

.insta, .insta2 {
  display: flex;
  justify-content: space-around;
  align-items: flex-start;
  flex-wrap: wrap;
}

/*--------------------------------------------------footer------------------------------------------------*/
* {
  padding: 0;
  margin: 0;
  border: 0;
}

*, *:before, *:after {
  -moz-box-sizing: border-box;
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

:focus, :active {
  outline: none;
}

a:active {
  outline: none;
}

nav, footer, header, aside {
  display: block;
}

html, body {
  height: 100%;
  width: 100%;
  font-size: 100%;
  line-height: 1;
  font-size: 14px;
  -ms-text-size-adjust: 100%;
  -moz-text-size-adjust: 100%;
  -webkit-text-size-adjust: 100%;
  color: #1B2618;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 24px;
}

body {
  margin: 0px;
}

.form__body::after {
  content: "";
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: rgba(51, 51, 51, 0.9);
  opacity: 0;
  visibility: hidden;
  transition: all 0.5s ease 0s;
}

.form__body._sending::after {
  opacity: 1;
  visibility: visible;
}

input, button, textarea {
  font-family: inherit;
}

input::-ms-clear {
  display: none;
}

button {
  cursor: pointer;
}
button::-moz-focus-inner {
  padding: 0;
  border: 0;
}

a, a:visited {
  text-decoration: none;
  color: #1B2618;
  transition: all 0.5s ease 0s;
}

a:hover {
  text-decoration: none;
}

ul li {
  list-style: none;
}

img {
  vertical-align: top;
}

p + span {
  color: gray;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 18px;
  margin-top: 10px;
}

h1, h2, h3, h4, h5, h6 {
  font-size: inherit;
  font-weight: 700;
  margin: 0px;
}

*, :after, :before {
  box-sizing: border-box;
}

html {
  scroll-behavior: smooth;
}

body {
  background-color: #E6E6E6;
  margin: 0px;
}

.wrapper {
  min-height: 100%;
  display: flex;
  flex-direction: column;
}

.container {
  max-width: 1440px;
  margin: 0px auto;
  align-items: center;
}

.header__container {
  max-height: 90px;
  display: flex;
  flex-wrap: nowrap;
  font-size: 16px;
  text-transform: capitalize;
  font-family: "Red Hat Text";
  color: #1B2618;
  background: linear-gradient(rgba(255, 182, 193, 0.9), rgba(40, 140, 255, 0));
  z-index: 10;
  position: relative;
  box-shadow: 0px 4px 5px #FFC0CB;
  font-weight: 800;
}

.header__burger, .header__empty {
  display: none;
}

.header__logo, .footer__logo {
  position: relative;
  margin-left: 10.9%;
  padding: 32px 0px 34px 0px;
  font-size: 32px;
  font-family: "Disruptors Script";
  font-weight: 500;
  transition: all 0.2s;
  vertical-align: top;
  text-align: center;
  line-height: 20px;
}

.header__logo:hover {
  text-shadow: 0px 4px 3px rgba(0, 0, 0, 0.5);
}
.header__logo:hover::before {
  filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5));
}

.header__logo::before {
  position: absolute;
  content: "";
  z-index: 20;
  width: 200px;
  height: 230px;
  top: -60px;
  left: 40px;
  background: url("../img/logo2.png") no-repeat 10px 0px/132px 132px;
  margin: 30px 0px 0px -40px;
  transition: all 0.5s ease 0s;
}

.header__menu {
  margin: 0 auto;
  align-items: center;
  max-width: 100%;
}

.menu__list {
  display: flex;
  flex-wrap: wrap;
  padding: 0px;
  font-family: "Comfortaa";
}

.menu__item:not(:last-child) {
  margin-right: 42px;
}

.menu__item:nth-child(5), .menu__item:nth-child(6) {
  display: none;
}

.menu__item {
  transition: all 0.6s;
}
.menu__item:hover {
  transform: scale(1.2);
}

.menu__link {
  transition: all 0.5s;
  color: #1B2618;
}
.menu__link:hover {
  color: #DB7093;
  text-shadow: 0px 4px 3px rgba(0, 0, 0, 0.5);
}

.button__all {
  background-color: #DB7093;
  font-weight: 500;
  color: white;
  border: 0px;
  font-size: 16px;
  font-family: "Comfortaa";
  padding: 10px 30px;
  text-transform: capitalize;
  transition: color 1s, background-color 1s, box-shadow 0.2s;
}
.button__all a {
  color: white;
}
.button__all:hover {
  background-color: #E6E6E6;
  color: #FFC0CB;
}
.button__all:active {
  box-shadow: 0 0 20px 0 #FFC0CB inset, 0 0 30px 10px #FFC0CB;
}

.header__button a:visited, .button__all a:visited {
  color: white;
}

.header__button {
  padding: 10px 10px 10px 30px;
  margin-right: 7.6%;
}

.first-button {
  box-shadow: 0px 4px 3px rgba(0, 0, 0, 0.2);
}

.preview__container {
  display: flex;
  min-height: 765px;
  background-color: #FFFFFF;
  padding: 150px 10% 190px 10%;
}
.preview__container h1 {
  font-family: "Marck+Script&display";
  font-style: normal;
  font-weight: 300;
  font-size: 80px;
  line-height: 96px;
  transition: all 0.3s;
  color: #DB7093;
  text-shadow: 0px 4px 3px #FFC0CB;
}

.preview__common {
  position: relative;
  z-index: 1;
  top: -140px;
  border-radius: 16px;
}
.preview__common h1 + p {
  font-family: "Comfortaa";
  font-weight: 700;
  font-size: 20px;
  line-height: 24px;
  color: #1B2618;
  margin-top: 0px;
  transition: all 0.3s;
}
.preview__common h1:hover, .preview__common h1 + p:hover {
  color: #DB7093;
  text-shadow: 0px 4px 3px rgba(0, 0, 0, 0.5);
}

.preview__second {
  position: absolute;
  left: 40%;
  z-index: 0;
}

.preview__planning {
  margin-top: 46px;
}

.start-planning {
  font-size: 24px;
  padding: 14px 34px;
}

.main__img_first {
  border-radius: 70% 0% 0% 0%;
  border: 1px solid #FFC0CB;
  position: relative;
  z-index: 2;
  width: 300px;
  height: 250px;
  bottom: -20px;
  right: -20px;
}

.main__image_first {
  margin-left: 40%;
  background: url("../img/light.jpg") 0px/400px 350px no-repeat;
  border-radius: 60% 0% 0% 0%;
  width: 300px;
  height: 250px;
}

.main__img_second {
  display: flex;
}

.main__image_third {
  border-radius: 0% 0% 0% 70%;
  border: 1px solid #FFC0CB;
  position: relative;
  z-index: 2;
  width: 350px;
  height: 300px;
  bottom: -20px;
  left: -20px;
}

.main__image {
  background: url("../img/candle.jpg") 0px/400px 350px no-repeat;
  width: 350px;
  height: 300px;
  border-radius: 0% 0% 0% 70%;
  margin: 60px 60px 0px 0px;
  z-index: 0;
  position: relative;
}
.main__image_forth {
  background: url("../img/second.jpeg") 0/300px 300px;
  width: 300px;
  height: 300px;
  border-radius: 50%;
  margin-top: 60px;
}

.steps__container {
  background-color: #FFFFFF;
  padding: 90px 10% 90px;
}

.steps__first {
  margin: 0px auto;
}

.steps__icons {
  display: flex;
  flex-wrap: nowrap;
  justify-content: space-between;
  flex-shrink: 1;
}
.steps__icons div:nth-child(2) {
  margin-left: 5.8%;
}

h2 {
  font-family: "Marck Script";
  font-style: normal;
  font-weight: 500;
  font-size: 60px;
  line-height: 53px;
  margin-bottom: 40px;
  color: #DB7093;
  transition: all 0.5s ease 0s;
  text-shadow: 0px 4px 3px #FFC0CB;
}
h2:hover {
  color: #DB7093;
  text-shadow: 0px 4px 3px rgba(0, 0, 0, 0.5);
}

.steps__icon {
  text-align: center;
}
.steps__icon img {
  padding: 40px 0px 30px;
  transition: all 0.5s ease 0s;
}
.steps__icon img:hover {
  transform: scale(1.3);
  filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5));
}
.steps__icon p {
  font-family: "Comfortaa";
  font-style: normal;
  font-weight: 400;
  font-size: 20px;
  line-height: 24px;
  color: #0D606F;
  transition: all 0.3s;
}
.steps__icon p:hover {
  transform: scale(1.3);
}

.destinations__container {
  padding: 90px 10% 0px 10%;
  background-color: #FFFFFF;
}

.diffusors {
  padding: 90px 10% 90px 10%;
}

.diffusor {
  margin-bottom: 10px;
}

.diffusor__img {
  min-width: 300px;
  height: inherit;
  background: url(../img/bg2.jpg) 0px -40px/cover no-repeat;
}

.slider {
  position: relative;
}
.slider img {
  width: 300px;
  height: 300px;
  object-fit: cover;
}
.slider__text {
  color: #1B2618;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 24px;
  margin-top: 10px;
}
.slider__text span {
  color: gray;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 18px;
  margin-top: 10px;
}
.slider__item {
  text-align: center;
  display: flex;
  flex-direction: column-reverse;
  padding-top: 20px;
}
.slider .slick-arrow {
  position: absolute;
  z-index: 5;
  top: 0%;
  font-size: 0;
  width: 5%;
  height: 100%;
}
.slider .slick-dots {
  display: flex;
  align-items: center;
  justify-content: center;
  padding-bottom: 90px;
}
.slider .slick-dots li.slick-active {
  background-color: #FFC0CB;
}
.slider .slick-dots li button {
  font-size: 0;
}
.slider .slick-dots li:not(:last-child) {
  margin-right: 10px;
}
.slider .slick-dots li {
  width: 20px;
  height: 20px;
  border-radius: 50%;
  background-color: #ECEAEB;
}
.slider__container {
  padding: 90px 10% 90px 10%;
  background-color: #FFFFFF;
}

.slick-list {
  overflow: hidden;
}

.slick-track {
  display: flex;
  align-items: flex-end;
  align-items: flex-start;
}

.slick-slide {
  margin: 0px 60px 20px 0px;
  width: 300px;
}
.slick-slide.slick-current {
  opacity: 1;
}
.slick-slide.slick-center {
  padding: 0 60px 0px 0px;
}

.slick-arrow.slick-prev {
  top: 40%;
  left: -10%;
  background: url(../img/arrow-left.svg) 0 0/90% no-repeat;
}

.slick-arrow.slick-next {
  top: 40%;
  right: -10%;
  background: url(../img/arrow-right.svg) 0 0/90% no-repeat;
}

.img__circle {
  border-radius: 50%;
  height: 300px;
}
.img__circle_div {
  width: 300px;
  height: 300px;
  border: 1px solid #FFC0CB;
  position: absolute;
  top: 0px;
  border-radius: 50%;
}

.img__square-circle {
  border-radius: 0% 50% 0% 0%;
  height: 300px;
}
.img__square-circle-down {
  background: url(../img/fifth.jpg) 0/600px 600px;
  width: 350px;
  height: 300px;
  border-radius: 0% 0% 70% 0%;
  z-index: 0;
  position: relative;
}
.img__square-circle-border-down {
  border-radius: 0% 0% 70% 0%;
  border: 1px solid #FFC0CB;
  position: absolute;
  z-index: 2;
  width: 350px;
  height: 300px;
  top: 20px;
  left: 20px;
}
.img__square-circle-border {
  border-radius: 0% 70% 0% 0%;
  border: 1px solid #FFC0CB;
  position: absolute;
  z-index: 2;
  width: 350px;
  height: 350px;
  top: -20px;
  left: 20px;
}
.img__square-circle-border-top {
  border-radius: 70% 0% 0% 0%;
  border: 1px solid #FFC0CB;
  position: absolute;
  z-index: 2;
  width: 350px;
  height: 300px;
  top: -20px;
  right: 20px;
}
.img__square-circle-top {
  background: url("../img/fifth.jpg") 0px 0px/350px 400px;
  width: 350px;
  height: 300px;
  border-radius: 70% 0% 0% 0%;
  z-index: 0;
  position: relative;
}

.info__candles {
  background: rgb(236, 234, 235);
  display: flex;
  justify-content: space-between;
}

.info__img {
  min-width: 300px;
  height: inherit;
  background: url("../img/forth.jpeg") 0px -40px/cover no-repeat;
}

.info__form {
  min-width: 50%;
  margin-left: 40px;
}
.info__form .email:hover::after, .info__form .phone:hover::after {
  transform: rotate(20deg);
}
.info__form .email::after {
  content: "";
  position: absolute;
  width: 30px;
  height: 30px;
  background: url("../img/email.svg") 0/20px 20px no-repeat;
  right: 0px;
  transition: all 0.2s ease-in-out;
}
.info__form .phone::after {
  content: "";
  position: absolute;
  width: 30px;
  height: 30px;
  background: url("../img/phone.svg") 0/20px 20px no-repeat;
  right: 0px;
  transition: all 0.2s ease-in-out;
}

.info__text {
  display: flex;
  padding: 40px 40px 40px 10px;
  color: #1B2618;
  font-family: "Comfortaa";
  font-weight: 500;
  margin-top: 10px;
  font-size: 20px;
  align-items: center;
}
.info__text img {
  width: 40px;
  height: 40px;
  vertical-align: -7px;
  margin-right: 10px;
  padding: 10px;
}

.candle4 img {
  border-radius: 50%;
  min-width: 300px;
  min-height: 300px;
  margin-top: -20px;
}

.stories__container, .subscribe__email {
  background-color: #FFFFFF;
  padding: 0px 10% 90px;
}

.stories__first {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  position: relative;
  margin-bottom: 40px;
  align-items: flex-end;
}
.stories__first_border_radius {
  position: relative;
}

.stories__first p, .stories__second p {
  padding-top: 20px;
}

.stories__first ul, .stories__second ul, .stories__first li, .stories__second li {
  color: gray;
  font-family: "Comfortaa";
  font-weight: 500;
  font-size: 18px;
  margin-top: 10px;
}

.stories__first div:hover, .stories__second div:hover {
  transform: scale(1.1);
  transition: all 0.5s ease 0s;
}

.img__square {
  width: 300px;
  height: 350px;
}
.img__square-circle {
  background: url("../img/fifth.jpg") 0px 0px/350px 400px;
  width: 350px;
  height: 350px;
  border-radius: 0% 70% 0% 0%;
  z-index: 0;
  position: relative;
}

.stories__second {
  position: relative;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  margin-bottom: 40px;
  align-items: flex-end;
}

.subscribe__email {
  background-color: #ECEAEB;
  text-align: center;
}
.subscribe__email h2 {
  margin-bottom: 20px;
}

.subscribe__email {
  padding: 20px 10%;
}

.textarea__ask {
  background-color: #ECEAEB;
  border-bottom: 1px solid #FFC0CB;
  resize: none;
  line-height: 20px;
  margin: 30px 0px;
  width: 90%;
}

.info__form {
  position: relative;
}

.subscribe__text {
  display: flex;
  padding: 0px 0px 40px;
  color: #1B2618;
  font-family: "Comfortaa";
  font-weight: 500;
  margin-top: 10px;
  font-size: 20px;
}

/*--------------------------------------------*/
footer {
  margin-top: -61px;
  color: #1B2618;
}
footer a:first-of-type {
  padding-left: 19px;
}

.footer_container {
  display: flex;
  justify-content: space-between;
  padding: 40px 10% 10px 10%;
  box-shadow: 0px 0px 5px 1px #FFC0CB;
  z-index: 10;
  position: relative;
  background-color: #ECEAEB;
}

.footer__contacts {
  display: flex;
  padding: 10px 0% 13.35px 0%;
  justify-content: space-between;
  flex-basis: 100%;
}
.footer__contacts .footer__logo {
  padding: 0px;
  margin: 0px;
}

.delivery {
  display: none;
}

.footer__logo::before {
  position: absolute;
  content: "";
  width: 130px;
  height: 130px;
  top: -50px;
  left: 110px;
  background: url("../img/logo2.png") no-repeat 0 0/130px 130px;
  margin: 30px 0px 0px -40px;
  transition: all 0.5s ease 0s;
}

.footer__logo p, .footer__my-contacts, .footer__my-contacts a {
  font-family: "Comfortaa";
  font-size: 16px;
  Line-height: 21px;
  padding-top: 68px;
  position: relative;
}

.footer__my-contacts a {
  padding-left: 50px;
}
.footer__my-contacts a::before {
  position: absolute;
  content: "";
  left: -20px;
  top: 0;
  width: 42px;
  height: 32px;
  background: url("../img/butter.png") no-repeat 0 0/32px 32px;
}

.footer__text {
  vertical-align: middle;
  flex-basis: 35.7%;
  padding-top: 10px;
}
.footer__text ul li {
  list-style: decimal;
  padding-bottom: 10px;
}
.footer__text h3 {
  padding: 10px 0px;
  text-decoration: underline;
}

.footer__icons li {
  padding: 10px;
  font-size: 18px;
}
.footer__icons li img {
  width: 40px;
  height: 40px;
  vertical-align: -10px;
  padding-right: 10px;
}

.footer__icons a:not(:last-child) {
  padding-right: 15px;
  padding-left: 10px;
}

.footer__contacts img, .footer__my-contacts a::before {
  transition: all 0.5s ease 0s;
}

.footer__contacts img:hover, .footer__my-contacts a:hover::before {
  transition: all 0.5s ease 0s;
  transform: scale(1.1);
}

/*-------------------------------------------pop-up------------*/
.pop-up {
  display: none;
}

._active-pop {
  display: block;
  width: 650px;
  position: absolute;
  top: 100px;
  border-radius: 2%;
  padding: 27px 45px 23px 45px;
  background: #FFFFFF linear-gradient(#FEFFFF, rgba(13, 96, 111, 0.5333333333));
  left: 0;
  right: 0;
  margin: auto;
}

.pop-up__container_img {
  width: 100px;
  height: 100px;
}

.pop-up__button {
  padding: 15px 0px;
  border-radius: 10px;
  width: 100%;
  font-size: 20px;
  line-height: 26px;
  font-family: "Comfortaa";
}

.pop-up__button span {
  margin-left: 7.14%;
}

.pop-up p {
  margin: 10px 0px 10px;
  color: #DB7093;
  font-family: "Comfortaa";
  font-size: 23px;
  line-height: 19px;
}

.pop-up input {
  height: 52px;
  width: 100%;
  margin-bottom: 30px;
}

.pop-up__sign-in {
  margin: 5px 0px 5px;
  background: #DB7093;
  color: #FFFFFF;
}

.pop-up a {
  text-align: center;
  display: block;
  font-family: "Comfortaa";
  font-size: 15px;
  color: #DB7093;
  margin-bottom: 26px;
  margin: 5px 0px 10px;
}

.pop-up a > span {
  font-weight: bold;
  text-decoration: underline;
}

.pop-up__sign-in ~ hr {
  width: 100%;
  margin-bottom: -5px;
}

.pop-up__sign-in ~ span {
  display: block;
  font-size: 15px;
  margin: 20px auto;
  width: 39.11%;
}

.pop-up__sign-in ~ span a {
  display: inline;
}

h4 {
  text-align: center;
  font-family: "Comfortaa";
  font-style: bold;
  font-size: 32px;
  line-height: 38px;
  line-height: 100%;
  color: #DB7093;
}

/*# sourceMappingURL=style.cs.map */
