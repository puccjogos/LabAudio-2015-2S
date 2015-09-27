var synth,
    clique = false,
    drum

function setup() {
  drum = EDrums("x-o-x-o-", 1/4)
  
  synth = Synth({
    waveform : "Sine",
    attack : ms(50),
    decay : ms(2000),
    amp: 0.9
  })
  //synth.play([220, 440, 880], 1/2)
  
}

function draw() {
  if(mouseIsPressed && clique == false){
    synth.note(mouseY, 0.8)
    clique = true
  }
  if(!mouseIsPressed){
    clique = false
  }
}







