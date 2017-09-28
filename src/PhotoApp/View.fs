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

  div [] [
        br [] 
        h1 [ClassName "content"] [  str "Photo Groove"]
        br []
        div [Id "thumbnails" ] (model.photos |> List.map (viewThumbnail model.selectedUrl)) 
        img [ClassName "large"
             Src (urlPrefix + "large/" + model.selectedUrl)]   
        br []
        ]
