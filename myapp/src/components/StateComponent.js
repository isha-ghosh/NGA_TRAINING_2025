import React from "react";
class StateComponenet extends React.Component
{
    constructor(props)
    {
        super(props)
        this.state={
            Counter:0
        };
        this.handleClick=this.handleClick.bind(this);
    }
    handleClick()
    {
        this.setState({Counter:this.state.Counter+1});  //to update
        console.log("Counter value: "+this.state.console);
    }
    render()
    {
        let {Counter}=this.state;//to redefine the counter
        //console.log(Counter);
        return(
            <div>
                {/* hanfleClick event */}
                <button onClick={this.handleClick}>Press to continue</button>  
                <div>Counter variable has incremented {Counter}</div>
            </div>
        );
    }
}
export default StateComponenet;