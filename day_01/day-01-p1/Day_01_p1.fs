// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv = 
    let path = "Day-01-p1-input.txt"

    let lines = System.IO.File.ReadLines(path)

    let s = Seq.sumBy int lines

    printf "%i" s

    0