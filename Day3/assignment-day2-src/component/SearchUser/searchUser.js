import axios from "axios";
import { useState } from "react";
import Menu from "../Menu/menu";

const SearchUser = () => {
    const[employResult, SetEmployResult] = useState({})//return single or 0 record
    const[userid,SetEmployNo] = useState(0)  
    const handleChange = event => {
        SetEmployNo(event.target.value)
         }
    const show = () => {
            // alert(userId)
            let uid = parseInt(userid);
            axios.get("http://localhost:1113/search/"+uid).then(
                (response) => {
                    SetEmployResult(response.data)
                }  
              )
          
        }
         return(
            <div>
                <Menu/>
                <label> User ID: </label>
                <input type="number" name="employId" value={userid} onChange={handleChange} /> <br/>
                <input type="button" value="Show" onClick={show} />
                <hr/>
                
                User ID: <b>{employResult.userid}</b> <br/>
                Name : <b>{employResult.name}</b> <br/>
                Basic : <b>{employResult.basic}</b> <br/>
               
                <hr/>
                 </div>
        )
}
export default SearchUser;