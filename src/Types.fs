module App.Types

open Global

type Msg =
  | CounterMsg of Counter.Types.Msg
  | PhotoAppMsg of PhotoApp.Types.Msg
  | HomeMsg of Home.Types.Msg

type Model = {
    currentPage: Page
    counter: Counter.Types.Model
    photoapp: PhotoApp.Types.Model
    home: Home.Types.Model
  }
