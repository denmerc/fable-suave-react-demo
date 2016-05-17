#r "../../node_modules/fable-core/Fable.Core.dll"
#load "../../node_modules/fable-import-react/Fable.Import.React.fs" 
#load "../../node_modules/fable-import-react/Fable.Helpers.React.fs"

open System
open Fable.Core
open Fable.Import
module R = Fable.Helpers.React
module P = Fable.Helpers.React.Props

let (^) = (<|)
 
ReactDom.render(
    R.span [ P.Value ^ U2.Case1 "Hello World" ] [],
    Browser.document.getElementById "content"
) 