
const button = document.querySelector("#button-save");
const text = document.querySelector("#text-input");
const ulList = document.querySelector("#ul-list");

const li = document.createElement("LI");
const textNode=document.createTextNode("ulList")

const ok="file:///C:/React_Bootcamp/Odevler/ToDoList/tikEmoji.png";
const notOk="file:///C:/React_Bootcamp/Odevler/ToDoList/carpiEmoji.png";

const check = document.querySelector("#check-input");
let listStr = "";

ulList.innerHTML+=localStorage.getItem("List");

function onButtonClick() {

  const li = document.createElement("LI");//createElement:html nesnesi oluşturmak için
  
  li.appendChild(document.createTextNode(text.value));
  li.innerHTML += ' <input  type="image" id="check-input" onclick="onInputClick(this)" src="C:/React_Bootcamp/Odevler/ToDoList/carpiEmoji.png"></input>';
  li.innerHTML += ' <button onclick="this.parentNode.remove()"  id="button-delete">Sil</button>';
  ulList.appendChild(li);

  localStorage.setItem("List", ulList.innerHTML);
 
}

function onInputClick(elem)
{
  if(elem.src===notOk)
  {
    elem.src=ok;
  }
  else
  {
    elem.src=notOk;
  }

}

function allDelete()
{
  document.getElementById("ul-list").innerHTML = "";
  localStorage.setItem("List", ulList.innerHTML);
}
