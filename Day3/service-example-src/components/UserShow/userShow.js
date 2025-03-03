import axios from "axios";
import { useState,useEffect } from "react";
import Menu from "../Menu/menu";

const UserShow=()=>{
    const[users,setUser]=useState([])
    useEffect(()=>{
        const fetchData = async () => {
            const response = await axios.get("https://jsonplaceholder.typicode.com/users");
            setUser(response.data)
        };
        fetchData()
    },[])
       return(
            <div>
              <Menu/>
            <table border="3" align="center">
              <tr>
                <th>ID</th>
                <th>Name</th>
                <th>UserName</th>
                <th>Email</th>
              </tr>
              {users.map((item) => 
                <tr>
                  <td>{item.id}</td>
                  <td>{item.name}</td>
                  <td>{item.username}</td>
                  <td>{item.email}</td>
                </tr>
              )}
            </table>
            </div>
        )
}
export default UserShow;