function postMsg(){
	
	
	var newMsg = document.getElementById("textBox").value;
	console.log(newMsg);
	
	allMsgs += ( "<p>" + newMsg + "</p>");
	console.log(allMsgs);
	
	document.getElementById("msgArea").innerHTML = allMsgs;
	document.getElementById("textBox").value = "";
	
}