var nash = (x,y,a,b) => {
    let aPercent = (b-y) / (x-y+b-a);
    let bPercent = 1 - aPercent;
    let expectedPay = (x * aPercent) + y + (y * -aPercent);
	console.log(`Other player should pick A ${aPercent*100}% of the time and B ${bPercent*100}%`)
    console.log(`Expected Payoff: ${expectedPay}`)
}

var calculate = () => {
    let playerA = document.getElementById("cell1").value.split(',');
    let playerB = [];

    for(let i = 0; i < test.length; i++) {
        test[i] = Number(test[i]);
    }
}