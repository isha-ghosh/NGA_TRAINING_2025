import React from "react";
class ClassDemo1 extends React.Component
{
    render()
    {
        return (
        <div><h1>Class Component </h1>
           <h2>You have visited :{this.props.sitevisited}</h2>
            </div>
        );
    }
}
export default ClassDemo1;