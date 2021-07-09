function hate(version){

  var formId = document.getElementById("isHateYes").checked;
  var formId2 = document.getElementById("isHateNo").checked;

  if(formId === false && formId2 === false){

    document.getElementById("pleaseSelect")
    .innerHTML = "Please select a choice";

  } else if(formId === true && formId2 === false){

    if(version === 1){

      alert("You'll need this then");
      window.open("https://www.amazon.com/rope/b?node=511394");

    } else {

      alert("We have something in common then!");

    }

  } else if(formId === false && formId2 === true){

      alert("You're lying");

  } else {
    document.reload();
  }

}


function erasePlease(){

  document.getElementById("pleaseSelect").innerHTML = " ";

}


function me(){

  document.getElementById("questionPara").innerHTML = "Do you hate me?";
  document.getElementById("customButton").setAttribute("onclick", "hate(0)");

}
