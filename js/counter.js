const countEl = document.getElementById("counter");
let numberss;
function separateComma(val) {
  // remove sign if negative
  var sign = 1;
  if (val < 0) {
    sign = -1;
    val = -val;
  }
  // trim the number decimal point if it exists
  let num = val.toString().includes(".")
    ? val.toString().split(".")[0]
    : val.toString();
  let len = num.toString().length;
  let result = "";
  let count = 1;

  for (let i = len - 1; i >= 0; i--) {
    result = num.toString()[i] + result;
    if (count % 3 === 0 && count !== 0 && i !== 0) {
      result = "," + result;
    }
    count++;
  }

  // add number after decimal point
  if (val.toString().includes(".")) {
    result = result + "." + val.toString().split(".")[1];
  }
  // return result with - sign if negative
  return sign < 0 ? "-" + result : result;
}

function updateVisitCount() {
  fetch(
    "https://api.countapi.xyz/update/svuhelp.org/df52e842-986d-4cb9-927d-505357d25f98?amount=1"
  )
    .then((res) => res.json())
    .then((res) => {
      numberss = res.value;
      countEl.innerText = separateComma(numberss);
    });
}
updateVisitCount();
countEl.onchange = function () {
  countEl.innerText = separateComma(countEl.innerText);
};
