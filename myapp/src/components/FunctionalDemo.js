import React from "react";
import Demo2 from "./FunctionalDemo2";
import ClassDemo1 from "./ClassDemo";
function Demo(props)
{
    return(
        <div>
            
            <h1>Heading of fuctional Demo</h1>
            <h2>Hi! I am {props.username}</h2>
            <h2>Heading of fuctional Demo</h2>
            <Demo2/>
            <ClassDemo1/>
        </div>
    );

}
export default Demo;