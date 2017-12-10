// First part of solution (generating lucky numbers);

let numbers = [];

(function(){
  for (let i = 1; i < 100; i++){
    numbers.push(i);
  }
})();

function answer(numbers){
for (let k = 1; k < numbers.length; k++)
  numbers.splice( k , 1 );
  // j is the position of numbers to remove.
  for (let j = 1; j < numbers.length; j++)
    // remove numbers in the position, accounting for the numbers postition
    // changing when removed. (help from /u/aplik789)
    for (let i = numbers[j] - 1; i < numbers.length; i += numbers[j] - 1)
      numbers.splice(i, 1);
  return numbers;
}

console.log(answer(numbers))
