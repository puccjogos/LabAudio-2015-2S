var osc

function setup() {
  osc = Triangle(880)
}

function draw() {
  osc.frequency = mouseY
  if(mouseIsPressed) {
    osc.amp = mouseX / width
  }
  else {
    osc.amp = 0
  }
}