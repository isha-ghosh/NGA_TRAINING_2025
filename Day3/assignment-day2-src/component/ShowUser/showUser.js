import axios from "axios";
import { useState,useEffect } from "react";
import Menu from "../Menu/menu";

const ShowUser=()=>{
    const[users,setPost]=useState([])
    useEffect(()=>{
        const fetchData = async () => {
            const response = await axios.get("http://localhost:1113/show");
            setPost(response.data)
        };
        fetchData()
    },[])
       return(
            <div>
              <Menu/>
            <table border="3" align="center">
              <tr>
                <th>User ID</th>
                <th>Name</th>
                <th>Basic</th>
                
              </tr>
              {users.map((item) => 
                <tr>
                  <td>{item.userid}</td>
                  <td>{item.name}</td>
                  <td>{item.basic}</td>
                 
                </tr>
              )}
            </table>
            </div>
          
    )
}
export default ShowUser;