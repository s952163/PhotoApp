module PhotoApp.View

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Elmish
open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.Helpers.React
open Elmish.React

open Types
open State


// VIEW (rendered with React)
let root model dispatch =
 
  let viewThumbnail selectedUrl thumbnail = 
        
        img [ Src (urlPrefix + thumbnail.url)
              classList  ["selected", selectedUrl = thumbnail.url] 
              OnClick (fun _ -> dispatch (SelectedUrl thumbnail.url))
        ]


  let sizeToString (size: ThumbnailSize) =
      match size with
      | Small -> "small"
      | Medium -> "med"
      | Large -> "large"

  let viewSizeChooser (size : ThumbnailSize) =
      label [] [ input [Type "radio"; Name "size"] 
                 str (sizeToString size) ]

  div [] [
        br [] 
        h1 [ClassName "content"] [  str "Photo Groove"]
        button [ClassName "button"
                Id "button2"
                OnClick (fun _ -> dispatch (SelectedUrl "2.jpeg"))] [str "Surprise Me!"]
        h3 [] [ str "Thumbnail Size:" ]
        div [Id "choose-size"] ([Small; Medium; Large] |> List.map viewSizeChooser) 
        div [Id "thumbnails"; ClassName (sizeToString model.chosenSize) ] (model.photos |> List.map (viewThumbnail model.selectedUrl)) 
        img [ClassName "large"
             Src (urlPrefix + "large/" + model.selectedUrl)]   
        br []
        ]
