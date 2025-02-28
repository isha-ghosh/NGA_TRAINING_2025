import React from "react";
//import { Link } from "react-router-dom";
import "../styles.css";
import Menu from "./Menu";
import logo from "../components/logo.png";

function Header(){
  return (
    <header className="header">
      <div className="logo-container">
      <img src={logo} alt="Logo" className="logo" /> 
      </div>
   <nav>
      <Menu/>
      </nav>
   
    </header>
  );
}

export default Header;
