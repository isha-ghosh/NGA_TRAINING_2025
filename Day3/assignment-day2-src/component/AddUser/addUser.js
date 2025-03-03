import { useState } from "react";

import axios from "axios";
import Menu from "../Menu/menu";

const AddUser = () => {

    const [data, setData] = useState({
        userid : 0, 
        name : '',
        basic : 0
    })

    const handleChange = event => {
        setData({
            ...data,[event.target.name] : event.target.value  
        })
    }

    const addEmploy = () => {
        axios.post("http://localhost:1113/add",{
          userid : data.userid,
          name : data.name,
          basic : data.basic 
        }).then(resp => {
        //   alert(resp.data);
          console.log(resp.data);
        })
      }
    

    return(
        <div>
            <Menu/>
            <label>User ID : </label>
            <input type="number" name="userid" 
                value={data.userid} onChange={handleChange} /> <br/><br/>
            <label>User Name : </label>
            <input type="text" name="name" 
                value={data.name} onChange={handleChange} /> <br/><br/> 
            <label>Basic Pay : </label>
            <input type="number" name="basic" 
                value={data.basic} onChange={handleChange} /> <br/><br/> 
            <input type="button" value="Add User" onClick={addEmploy} /> 
         </div>
    )
}

export default AddUser;