import { useEffect, useRef, useState } from "react";

const RefEX2=()=>{

    const[inputValue, setInputValue]=useState("")
    const count=useRef(0)
    useEffect(()=>{
        count.current=count.current+1;
    })
    return(
        <div>
            <input type="text" value={inputValue} onChange={(e)=>setInputValue(e.target.value)}/>
            <h1>Render count as how many times we changed textbox value: <b>{count.current}</b></h1>
        </div>
    )
}
export default RefEX2;