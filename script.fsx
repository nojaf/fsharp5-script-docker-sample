#r "nuget: Thoth.Json.Net"

open Thoth.Json.Net

Encode.object [
    "user", Encode.string "nojaf"
    "likesFSharpScript", Encode.bool true
]
|> Encode.toString 4
|> printfn "json:\n%s"
