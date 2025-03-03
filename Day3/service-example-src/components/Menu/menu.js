
import { Link } from "react-router-dom";

const Menu = () => {
    return(
        <div>
            Welcome to Menu Page <br/> <hr/>
            <Link to="/searchu">Search User</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/searchp">Search Post</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/searche">Search Employee</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/showu">Show Users</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/showp">Show Posts</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/showe">Show Employee</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/inserte">Insert Employee</Link>
            <br/><br/><hr/>
            
        </div>
    )
}

export default Menu;