
const button = document.querySelector("#button-save");
const text = document.querySelector("#text-input");
const ulList = document.querySelector("#ul-list");

const li = document.createElement("LI");
const textNode=document.createTextNode("ulList")

const ok="tikEmoji.png";
const notOk="carpiEmoji.png";


const check = document.querySelector("#check-input");
let listStr = "";

ulList.innerHTML+=localStorage.getItem("List");

function onButtonClick() {

  const li = document.createElement("LI");//createElement:html nesnesi oluşturmak için
  
  li.appendChild(document.createTextNode(text.value));
  li.innerHTML += ' <input  type="image" id="check-input" onclick="onInputClick(this)" src="carpiEmoji.png"></input>';
  li.innerHTML += ' <button onclick="this.parentNode.remove()"  id="button-delete">Sil</button>';
  ulList.appendChild(li);

  localStorage.setItem("List", ulList.innerHTML);
 
}

function onInputClick(elem)
{
  const source=elem.src.split('/').reverse()[0];
  if(source==notOk)
  {
    elem.src=ok;
    localStorage.setItem("List", ulList.innerHTML);
  }
  else
  {
    elem.src=notOk;
    localStorage.setItem("List", ulList.innerHTML);
  }

}

function allDelete()
{
  document.getElementById("ul-list").innerHTML = "";
  localStorage.setItem("List", ulList.innerHTML);
}
