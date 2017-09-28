module PhotoApp.Types

// MODEL
type Photo = {
    url: string
    }

type Album = {
    photos : Photo list
    selectedUrl : string
    }

type Model = Album
    
type Msg = | SelectedUrl of string