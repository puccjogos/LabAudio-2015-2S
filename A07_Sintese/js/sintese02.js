var noise = {}, delay ={}, osc = {},
    aT = 0.01, aL = 0.7, dT = 0.1, dL = 0.2, sT = 0.1, sL = dL, rT = 0.2

function setup() {
  osc = new p5.SinOsc()
  osc.freq(220)
  osc.start()
  noise = new p5.Noise("white")
  noise.amp(0.5)
  noise.start()
  delay = new p5.Delay()
  env = new p5.Env(aT, aL, dT, dL, sT, sL, rT)
  noise.amp(env)
  osc.amp(env)
}

function draw() {
  if(mouseIsPressed){
    var novanota1 = 40 + mouseY / 20
    osc.freq(midiToFreq(novanota1))
    delay.process(noise, mouseX / 400, 0.7)
    delay.process(osc, mouseX / 400, 0.7)
    env.play()
  }
}