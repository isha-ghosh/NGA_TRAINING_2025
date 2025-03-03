import axios from "axios";
import { useState,useEffect } from "react";
import Menu from "../Menu/menu";

const ShowEmploy=()=>{
    const[users,setPost]=useState([])
    useEffect(()=>{
        const fetchData = async () => {
            const response = await axios.get("http://localhost:5555/showemploy");
            setPost(response.data)
        };
        fetchData()
    },[])
       return(
            <div>
              <Menu/>
            <table border="3" align="center">
              <tr>
                <th>Emp No</th>
                <th>Name</th>
                <th>Basic</th>
                
              </tr>
              {users.map((item) => 
                <tr>
                  <td>{item.empno}</td>
                  <td>{item.name}</td>
                  <td>{item.basic}</td>
                 
                </tr>
              )}
            </table>
            </div>
          
    )
}
export default ShowEmploy;