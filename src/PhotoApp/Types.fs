module PhotoApp.Types

// MODEL
type Photo = {
    url: string
    }

type ThumbnailSize =
    | Small
    | Medium
    | Large

type Album = {
    photos : Photo list
    selectedUrl : string
    chosenSize : ThumbnailSize
    }

type Model = Album
    
type Msg = | SelectedUrl of string
           | RandomUrl of string

