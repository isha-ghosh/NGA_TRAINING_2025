import { useState } from "react";
import {useNavigate} from "react-router-dom" //button navigate dynamically


const Login=()=>{
    const[data,setData]=useState({
        userName:'',
        passCode:''

    })
    const navigate = useNavigate();
    const handleSubmit=()=>{
        if(data.userName==="Wipro" && data.passCode==="wipro")
            //alert("Correct credentials")
            navigate("/menu")
        else
            alert("Incorrect credentials")
        //alert(data.userName+" "+data.passCode)
      //  alert(data.passCode)

    }
    const handleChange = event => {
        setData({
            ...data,[event.target.name] : event.target.value  
        })
    }

    return(
        <div>
            <form onSubmit={handleSubmit}>
                <label> User Name: </label>
                <input type="text" name="userName" value={data.userName} onChange={handleChange}/><br/>
                <label> Pass Code: </label>
                <input type="password" name="passCode" value={data.passCode} onChange={handleChange}/><br/>
                <input type="submit" value="Login" />
            </form>
        </div>
    )

}
export default Login;