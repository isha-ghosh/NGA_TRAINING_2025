import axios from "axios";
import { useState,useEffect } from "react";
import Menu from "../Menu/menu";

const PostShow=()=>{
    const[users,setPost]=useState([])
    useEffect(()=>{
        const fetchData = async () => {
            const response = await axios.get("https://jsonplaceholder.typicode.com/posts");
            setPost(response.data)
        };
        fetchData()
    },[])
       return(
            <div>
              <Menu/>
            <table border="3" align="center">
              <tr>
                <th>UserID</th>
                <th>ID</th>
                <th>Title</th>
                <th>Body</th> 
              </tr>
              {users.map((item) => 
                <tr>
                  <td>{item.userId}</td>
                  <td>{item.id}</td>
                  <td>{item.title}</td>
                  <td>{item.body}</td>
                </tr>
              )}
            </table>
            </div>
          
    )
}
export default PostShow;