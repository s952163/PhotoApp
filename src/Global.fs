module Global

type Page =
  | Home
  | Counter
  | PhotoApp
  | About

let toHash page =
  match page with
  | About -> "#about"
  | Counter -> "#counter"
  | PhotoApp -> "#photoapp"
  | Home -> "#home"
