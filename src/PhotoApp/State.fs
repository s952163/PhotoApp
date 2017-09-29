module PhotoApp.State

open Elmish
open Types

let photoAlbum = [
         {url="1.jpeg"}
         {url= "2.jpeg"}
         {url = "3.jpeg"}
         ]

let album = {
    photos = photoAlbum
    selectedUrl = "1.jpeg"
    chosenSize = Medium
    }

let urlPrefix = "http://elm-in-action.com/"

// UPDATE
let update msg model : Model * Cmd<Msg>   =
  match msg with 
  | (SelectedUrl x) -> {model with selectedUrl = x}, [] 
  | (RandomUrl x) -> {model with selectedUrl = x}, []   
  

let init() : Model * Cmd<Msg>  = album, [] 