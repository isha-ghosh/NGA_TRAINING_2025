//import Ffirst from "../functionalComponents/ffirst";
import { Link } from "react-router-dom";
//import Fsecond from "../functionalComponents/fsecond";
//install--->npm install react-router-dom
const Menu =()=>{
    return(
        <div>
            Welcome to Menu Page<br/>
            <hr/>
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/first">First</Link>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <Link to="/second">second</Link>
            


            
        </div>
    );

}
export default Menu;