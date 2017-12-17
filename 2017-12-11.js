// Problem:
// https://www.reddit.com/r/dailyprogrammer/comments/7j33iv/20171211_challenge_344_easy_baumsweet_sequence/
// My solution below.

let arr = [ ];
baum = n => {return (n === 0 || !n.toString(2).split('1').some(x => x.length % 2)) ? 1 : 0};

sweet = x => {
  for (let i = 0; i <= x; i++) {
    arr.push(baum(i));
  };
  return arr.join(', ');
};

console.log(sweet(20));

// 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0
