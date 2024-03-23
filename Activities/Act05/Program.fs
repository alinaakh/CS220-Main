/// KAIST CS220 In-Class Activity Project

type Shape =
  /// A circle of a radius.
  | Circle of float
  /// A square with a side length.
  | Square of float
  /// A triangle with side lengths.
  | Triangle of float * float * float

/// Modify this function to compute the area of a given shape.
/// Hint: To compute a square root, use `sqrt`.
let area shape =
  match shape with
  |Circle r -> 3.14 * r * r
  |Square a -> a * a
  |Triangle (a, b, c) -> 
    let p = (a + b + c) / 2.0
    sqrt (p * (p - a) * (p - b) * (p - c))

let circle = Circle 0.5
let square = Square 1.0
let triangle = Triangle (1.0, 1.0, 1.0)

printfn "circle = %f" <| area circle
printfn "square = %f" <| area square
printfn "triangle = %f" <| area triangle
