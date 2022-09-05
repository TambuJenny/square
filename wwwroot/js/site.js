// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

import {CardCarousel} from "./Components/Cards.js";

$(document).ready (async function ()
{
   for (let index = 0; index < 10; index++) 
   {
    document.getElementById('CardCarousel').innerHTML += CardCarousel("olalala","Lorem","Lorem");
   }
});

