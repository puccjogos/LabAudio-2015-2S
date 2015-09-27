var a
function setup() {
  createCanvas( 200, 200 )
  c = EDrums("xxxx", 1/8)
  a = Synth().note.seq( [0,1,2,3], 1/4 )
  b = Flanger()
  a.fx.add(b)
}

function draw() {
  if(mouseIsPressed){
    b.rate = mouseY
  }
}