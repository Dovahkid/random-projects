class sequences{
  constructor(keySeq, name){
    var keySeq = [];
    var name;
  }
  getSeq(keysPressed){
    for(var i = 0; i < 4; i++){
      for(var j = 0; j < 4; j++){
        if(this.keySeq[i] == keysPressed[j]){
          return true;
        } else{
          return false;
        }
      }
    }
  }
}
newSeq = new sequences;
newSeq.keySeq = [107,121,115]

// 107 121 115
var keyPressSeq = [];
function getKeyPress(event){
  var x = event.which || event.keyCode;
  document.getElementById("testPara").innerHTML = x;
  keyPressSeq.push(x);

  // console.log(newSeq.name);
  // newSeq.getSeq();

  var newTest = newSeq.getSeq(keyPressSeq);
  console.log(newTest);

}
