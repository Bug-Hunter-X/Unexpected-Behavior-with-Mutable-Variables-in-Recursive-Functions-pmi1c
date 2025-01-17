let mutable x = 0
let addOne x = x <- x + 1
let rec loop counter =
    if counter > 10 then ()
    else (
        addOne x; 
        loop (counter + 1)
    )

loop 0
printf "%d" x