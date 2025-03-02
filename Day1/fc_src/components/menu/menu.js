
//install--->npm install react-router-dom


import { Link } from "react-router-dom";

const Menu = () => {
    return(
        <div>
            Welcome to Menu Page <br/> <hr/>
            <Link to="/first">First</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/second">Second</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/third">Third</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/four">Four</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/five">Five</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/button">Button Example</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/counter">Counter</Link>
            
        </div>
    )
}

export default Menu;