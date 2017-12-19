function fib(n){
  let a = 0;
  let b = 1;
  let c = 1;
  for (i = 1; i <= n; i++){
    c = a + b;
    a = b;
    b = c;
    console.log(c);
  }
}

fib(20);
// 10946
// https://www.reddit.com/r/dailyprogrammer/comments/qnkro/382012_challenge_20_easy/
