var osc1 = {}, osc2 = {},
    nota1 = 60, nota2 = 200
    env = {},
    aT = 0.1, aL = 0.7, dT = 0.3, dL = 0.2, sT = 0.5, sL = dL, rT = 0.2,
    delay = {}

function setup() {
  createCanvas(400, 300)
  background(50)
  
  osc1 = new p5.TriOsc()
  
  osc1 = new p5.TriOsc()
  osc1.freq(midiToFreq(nota1))
  env = new p5.Env(aT, aL, dT, dL, sT, sL, rT)
  osc1.amp(env)
  delay = new p5.Delay()
  osc1.start()
}

function draw() {
  
}

function keyPressed() {
  var novanota1 = 40 + mouseY / 20
  osc1.freq(midiToFreq(novanota1))
  delay.process(osc1, mouseX / 100, 0.7)
  env.play()
}

/*
function keyPressed() {
  if(keyCode == UP_ARROW){
    note += 2
    osc1.freq(midiToFreq(note))
  }
  
  if(keyCode == DOWN_ARROW){
    note -= 2
    osc1.freq(midiToFreq(note))
  }
}
*/