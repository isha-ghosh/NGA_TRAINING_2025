import { useEffect, useRef, useState } from "react";
const RefEX1 = () => {
    const [count, setCount] = useState(0)
    const prev=useRef()
    useEffect(()=>{
        prev.current=count;
        },[count])

   
    return(
        <div>
            Current Count is : <b>{count}</b> <br/>
            Previous Count is : <b>{prev.current}</b> <br/>
            <input type="button" value="Increment" onClick={() => setCount(count+1)} /> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="button" value="Decrement" onClick={() => setCount(count-1) }  />
        </div>
    )
}
export default RefEX1;