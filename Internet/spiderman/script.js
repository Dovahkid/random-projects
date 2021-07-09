function flipper(){
	
	var imgSrc = document.getElementById("spiderman").getAttribute('src');
	
	if (imgSrc == "accuse.jpg"){
		document.getElementById("spiderman").src = "spoder.png";
	} 
	else if(imgSrc == "spoder.png"){
		document.getElementById("spiderman").src = "accuse.jpg";
	} 
	else {
		document.getElementById("bodyBody").innerHTML = "<h1>I don't understand how you broke it...</h1>"
	}
	
}