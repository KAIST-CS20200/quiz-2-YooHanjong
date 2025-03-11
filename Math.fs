module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz  (n ) =
  let rec iter product count =
    if product=1UL then count
    else if product%2UL=0UL then iter (product/2UL) (count+1)
      else iter (3UL*product+1UL) (count+1)
  iter (uint64 n) 0
