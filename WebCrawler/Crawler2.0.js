const request = require('request');
global.fetch = require("node-fetch");
const cheerio = require('cheerio');
var fs = require('fs');
global.fetch = require("node-fetch");


var Image = new Array() ;
var Items = new Array() ;
var Price = new Array() ;
var Part = new Array() ;
var complete = 0;
var objGPU = [];

function UpdateImage(data ={}){
  Image.push(data);
}

function UpdateItems(data ={}){
  Items.push(data);
}

function UpdatePrice(data ={}){
  Price.push(data);
}
function UpdatePart(data ={}){
  Part.push(data);
}


function startWrite(Items, Image, Price, Part){
  console.log(Items);
  try {
    for(var i = 0; i < Items.length; i++){
      for(var k =0 ; k < Items[i].length; k++){
        console.log(Items[i][k]);
        console.log(Image[i][k]);
        console.log(Price[i][k]);
        console.log(Part[i][k]);
        objGPU.push({
          name: Items[i][k],
          description: Items[i][k],
          InventoryValue: Price[i][k],
          PartType: Part[i][k],
          url: Image[i][k]
        });
      };
      };
      PLZWORK();
    } catch (error) {
    console.log(error);
  }

}


async function postData(url = '', data= {}) {
    // Default options are marked with *
    const response = await fetch(url, {
      method: 'POST', // *GET, POST, PUT, DELETE, etc.
      mode: 'cors', // no-cors, *cors, same-origin
      cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
      credentials: 'same-origin', // include, *same-origin, omit
      headers: {
        'Content-Type': 'application/json'
        // 'Content-Type': 'application/x-www-form-urlencoded',
      },
     // redirect: 'follow', // manual, *follow, error
      referrerPolicy: 'origin', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
      body: JSON.stringify(data) // body data type must match "Content-Type" header
    });
  return response.json(); // parses JSON response into native JavaScript objects
};





function PostIT(objGPU = {}){
  try{
    postData('https://nameless-forest-23875.herokuapp.com/RawProduct/', objGPU)
      .then(data => {
        console.log(data); // JSON data parsed by data.json() call
      });
  }catch(error){
      console.log(error);
  }
};




function Scrape(link, filename){
  request(link, (error, response, html) => {
  if(!error && response.statusCode ==200) {
      const $ = cheerio.load(html);
      const HeadingInfo = $('.detail');
      const siteInfo = $('.fst');
      const Product = $('.myProductName');
      var arrImage = [] ;
      var arrItems = [] ;
      var arrPrice = [] ;
      var arrPartType = [] ;

      //console.log(HeadingInfo.text());
      //console.log(HeadingInfo.html());
      //const output = HeadingInfo.children('h1').text();
      //const output = HeadingInfo.children('h1').next().text(); // only gets the next info after h1

      // const output = HeadingInfo.children('h1').parent().text(); // gets more info 

      const Heading = HeadingInfo.find('h1').text();
      const output = Product.text();
      const removefirst = output.trim();
      const removed = removefirst.replace( /\s\s+/g, ',' );
      var res = removed.split(",");



      $('.myProductName span').each((i, el) => {
        const item = $(el).text();
        arrItems.push(item);
        if( item.includes("HDD") ||item.includes("SSD")  || item.includes("Hard Drive")  || item.includes("External")  || item.includes("Portable")){
          arrPartType.push("Storage");
        }
        else if(item.includes("Motherboard") ||item.includes("X570")){
          arrPartType.push("Motherboard");
        }
        else if(item.includes("Processor") ||item.includes("APU")){
          arrPartType.push("CPU");
        }
        else if(item.includes("Chair") ||item.includes("Sofa") ||item.includes("chair")){
          arrPartType.push("Chair");
        }
        else if(item.includes("MousePad") ||item.includes("mousepad")){
          arrPartType.push("MousePad");
        }
        else if(item.includes("DDR4") ||item.includes("Memory") ||item.includes("Vengeance")){
          arrPartType.push("Ram");
        }
        else if(item.includes("Case") ||item.includes("case")){
          arrPartType.push("Case");
        }
        else if(item.includes("Headset") ||item.includes("Headphone") ||item.includes("Memecoleus") ||item.includes("Earbuds") ||item.includes("Earphone")){
          arrPartType.push("Headset");
        }
        else if(item.includes("Gaming Combo") ){
          arrPartType.push("Gaming Combo");
        }
        else if(item.includes("Wrist Rest") ){
          arrPartType.push("Wrist Rest");
        }
        else if(item.includes("Network Cable") ||item.includes("Cord")){
          arrPartType.push("Network Cable");
        }
        else if(item.includes("Switch") ){
          arrPartType.push("Switch");
        }
        else if(item.includes("Workstation") ){
          arrPartType.push("Workstation");
        }
        else if(item.includes("Upgrade Kit") ){
          arrPartType.push("UpgradeKit");
        }
        else if(item.includes("Speaker")||item.includes("speaker") ){
          arrPartType.push("Speakers");
        }
        else if(item.includes("Adapter")||item.includes("Card Extender") ||item.includes("Extender")){
          arrPartType.push("Adapter");
        }
        else if(item.includes("Mouse")||item.includes("Trackball") ){
          arrPartType.push("Mouse");
        }
        else if(item.includes("Keycap")||item.includes("Key Caps") ){
          arrPartType.push("Keycap");
        }
        else if(item.includes("NVLink") ){
          arrPartType.push("NVLink");
        }
        else if(item.includes("Wireless Combo") ||item.includes("Gaming Starter Kit")){
          arrPartType.push("Mouse Keyboard combo");
        }
        else if(item.includes("Keyboard") || item.includes("Keypad") || item.includes("Orange Switch") || item.includes("keyboard")){
          arrPartType.push("Keyboard");
        }
        
        else if(item.includes("GDDR5") ||item.includes("GTX")||item.includes("Graphics Card") ||item.includes("RTX") || item.includes("Radeon")  || item.includes("GeForce")  || item.includes("Portable")) {
          arrPartType.push("GPU");
        }
        else{
          arrPartType.push("Unknown");
        }
      });

      UpdatePart(arrPartType);
      UpdateItems(arrItems);
      $('.price').each((i, el) => {
          const Price = $(el).text();
          const removefirst = Price.trim();
          var removed = removefirst.replace(/\s/g, '');
          removed = removed.replace("IncludingVAT",'');
          arrPrice.push(removed);

      });          
      UpdatePrice(arrPrice);

      $('.image a').each((i, el) => {
          const image = $(el).text();
          //const removefirst = Price.trim();
          //var removed = removefirst.replace(/\s/g, '');
          //removed = removed.replace("IncludingVAT",'');
          var FIndex = image.indexOf('/repository');
          var last = image.lastIndexOf('jpg');
          var src = image.slice(FIndex,last);
          arrImage.push('https://evetech.co.za'+src+'jpg');
          
          
      });
      UpdateImage(arrImage);
      console.log("Scrape Done");
      console.log(complete++);
      
      if(complete >13){
        startWrite(Items, Image, Price, Part);
      }

}
})

}

function Crawl(link){
  request(link, (error, response, html) => {
  if(!error && response.statusCode ==200) {
      const $ = cheerio.load(html);
      var arrLinks = [];
      // goes through the links and searches for components only 
      $("a").each((i, el) => {
          var data =($(el).attr());
          var search = JSON.stringify(data);
          var search = search.includes("components");
          if(search ==true){
              correct = JSON.stringify(data);
              var lIndex = correct.lastIndexOf('"');
              var FIndex = correct.indexOf('"',7)+1 ;
              correct = correct.slice(FIndex,lIndex);
              arrLinks.push(correct);
          }
          
      });
      // removes duplicate entries
      for(var I = 0; I < arrLinks.length ; I++){
          for(var J = 0; J< arrLinks.length; J++)
          {
              if(arrLinks[I] == arrLinks[J])
              {
                  arrLinks.splice(J,1);
              }
          }
      }
     // console.log(arrLinks);

      for(var x = 0; x< arrLinks.length; x++){
          var Indexfirst = arrLinks[x].indexOf("/",27) +1 ;
          var IndexLast = arrLinks[x].indexOf(".aspx");
          var str = arrLinks[x].slice(Indexfirst,IndexLast) +".json";
          Scrape(arrLinks[x], str);
        }
        console.log("done");
  }});
};



Crawl("https://www.evetech.co.za/");


function PLZWORK(){
  for(var j = 0 ; j < objGPU.length; j++){
    postData("https://nameless-forest-23875.herokuapp.com/RawProduct/",(objGPU[j]));
  }
}