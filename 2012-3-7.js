// count the number of alphanumeric characters in Sherlock Holmes from project gutenberg
// http://www.gutenberg.org/cache/epub/1661/pg1661.txt
// run script from the browser console.

var a = document.body.textContent.trim().replace(/\s/g,'');
// splits text to remove header and footer put on by PG
var b = a.split('***');
var c = new RegExp(/^\w+$/, 'g');
var d = b[2].replace(c, '').replace(/[^\w\s]|_/g, "").replace(/\s+/g, " ");
var e = d.length;
console.log(e);
// 432,188
