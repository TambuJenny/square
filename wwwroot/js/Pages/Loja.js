import CardProduct from "./../Components/Cards.js";

$(document).ready(async function() {
  for (let index = 0; index < 10; index++) {
    document.getElementById("cardsProduct").innerHTML += CardProduct();
  }
});
