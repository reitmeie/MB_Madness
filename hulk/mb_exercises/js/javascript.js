var num = localStorage.length;
var badgeNames= [];
function addBadge() {
num++;
	var badgeName = prompt("Merit Badge# "+String(num), "enter name here");
	if (badgeName==="radio) {
		alert("cand");
		return;
	}else {
			
	var ul = document.getElementById("myBadges");

   var li = document.createElement("li");
   li.appendChild(document.createTextNode(badgeName));
   li.setAttribute("id", "element4"); // added line
   ul.appendChild(li);
var count = document.getElementById("badgeCount")
count.innerHTML = "Merit Badge Count: "+String(localStorage.length);   
   if (typeof(Storage) !== "undefined") {
    // Code for localStorage/sessionStorage.
    
} else {
    // Sorry! No Web Storage support..
}
localStorage.setItem("badge: "+String(num), badgeName);
  //alert(li.id);
}
}
function getlist() {
var str ="";
 for (i=0; localStorage.length>i; i++) {
 	str=str+localStorage["badge: "+String(i+1)]+'/n'
 	}
}
function start() {
console.log((localStorage["badge: 1"]));
if(localStorage["badge: 1"]===null){
    localStorage.clear();
} else {
   var load = confirm("Load a save");
   if (load===true){
   for (i=0; localStorage.length>i; i++) {
		   		var ul = document.getElementById("myBadges");
   var li = document.createElement("li");
   li.appendChild(document.createTextNode("- " +String(localStorage["badge: "+String(i+1)])));
   console.log(String(i+1)+localStorage["badge: "+String(i+1)]);  
   if (num%2) {
   	
   
   li.setAttribute("id", "badge1"); // added line
}else {
	li.setAttribute("id","badge2");
}   
   ul.appendChild(li);
   	}
}else {
	localStorage.clear();
}

var count = document.getElementById("badgeCount")
count.innerHTML = "Merit Badge Count: "+String(localStorage.length);
}
}
window.onload = start;