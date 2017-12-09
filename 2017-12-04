var notes = ["C","C#","D","D#","E","F","F#","G","G#","A","A#","B"];
var scale = {
    "Do": 0, 
    "Re": 2, 
    "Mi": 4, 
    "Fa": 5, 
    "So": 7, 
    "La": 9, 
    "Ti": 11
};
var answerFinder = function(startNote, solfege) {
  var startLoc = notes.indexOf(startNote);
  var scaleLoc = scale[solfege];
  var idx = startLoc + scaleLoc;
  
  if (idx > notes.length -1) {
    idx = startLoc - (notes.length - scaleLoc);
  }
  // console.log('idx = -> ' + idx);
  return notes[idx];
};

// Problem Location:
// https://www.reddit.com/r/dailyprogrammer/comments/7hhyin/20171204_challenge_343_easy_major_scales/
