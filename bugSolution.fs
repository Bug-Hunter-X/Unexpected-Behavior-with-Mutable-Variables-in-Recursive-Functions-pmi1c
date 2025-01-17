let xRef = ref 0

let addOne xRef = xRef := !xRef + 1

let rec loop counter xRef =
    if counter > 10 then ()
    else (
        addOne xRef; 
        loop (counter + 1) xRef
    )

loop 0 xRef
printf "%d" !xRef