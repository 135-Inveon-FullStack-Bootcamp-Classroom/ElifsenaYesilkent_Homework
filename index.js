/**
 * 1. todo ekleme
 * 2. tamamla butonu (complete)
 * 3. sil butonu olacak
 * 4. kayıt edilsin (localStorage, cookie) - sayfa yenilendiği zaman son hali yeniden görünsün
 *
 * --- optional
 * 1. güncelleme
 * 2. toplu silme (mehmete required gerisi optional)+++++
 * 3. eklenme - tamamlanma tarihi++++
 * 4. berke -> tamamlanma tarihi gelince alert version----
 * 5. kategoriler koyulabilir -> spor, iş vs.----
 * 6.
 */

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
