import React from "react";
//import { Link } from "react-router-dom";
import "../styles.css";
class Menu extends React.Component
{
   render()
   {
    return(
        <div>
          <ul className="links">
          <li><a href="/">Home</a></li>
         <li>  <a href="/contact">ContactUs</a></li>
        <li>    <a href="/about">AboutUs</a></li>
        <li><a href="/login"><button className="login-button">Login</button></a></li>
          </ul>
           
            {/* <ul>
            <li><Link to="/">Home</Link></li>
          <li><Link to="/about">About</Link></li>
          <li><Link to="/contact">Contact</Link></li>
            </ul> */}


        </div>
    );
   }
  
    
}
export default Menu;