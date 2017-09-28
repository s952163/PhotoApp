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
    }

let urlPrefix = "http://elm-in-action.com/"

let init() : Model = album

// UPDATE
let update (msg:Msg) (model:Model) =
  match msg with 
  | (SelectedUrl x) -> {model with selectedUrl = x}    
  //| _ -> model