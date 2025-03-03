import axios from "axios";
import { useState } from "react";
import Menu from "../Menu/menu";

const EmploySearch = () => {
    const[employResult, SetEmployResult] = useState({})//return single or 0 record
    const[empNo,SetEmployNo] = useState(0)  
    const handleChange = event => {
        SetEmployNo(event.target.value)
         }
    const show = () => {
            // alert(userId)
            let eid = parseInt(empNo);
            axios.get("http://localhost:5555/searchemploy/"+eid).then(
                (response) => {
                    SetEmployResult(response.data)
                }  
              )
          
        }
         return(
            <div>
                <Menu/>
                <label> Employ Id : </label>
                <input type="number" name="employId" value={empNo} onChange={handleChange} /> <br/>
                <input type="button" value="Show" onClick={show} />
                <hr/>
                
                Emp No.: <b>{employResult.empno}</b> <br/>
                Name : <b>{employResult.name}</b> <br/>
                Basic : <b>{employResult.basic}</b> <br/>
               
                <hr/>
                 </div>
        )
}
export default EmploySearch;