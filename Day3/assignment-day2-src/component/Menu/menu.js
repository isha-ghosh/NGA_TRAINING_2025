import { Link } from "react-router-dom";

const Menu = () => {
    return(
        <div>
           
            <Link to="/searchu">Search User</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/addu">Add User</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/showu">Show User</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br/><br/><hr/>
            
        </div>
    )
}

export default Menu;