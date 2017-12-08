/**
Write a program that outputs the first recurring character in a string.

inputs: 
IKEUNFUVFV
PXLJOUDJVZGQHLBHGXIW
*l1J?)yn%R[}9~1"=k7]9;0[$

https://www.reddit.com/r/dailyprogrammer/comments/7cnqtw/20171113_challenge_340_easy_first_recurring/
*/


function answerer( str ) {
  var obj = { };
  for (var i = 0; i < str.length; i++) {
    var val = str[i];
    if ( !obj[val] ){
      obj[val] = i;
    } else {
      return(obj[val]);
    }
  }
}
