import { useState } from "react";
import {useNavigate} from "react-router-dom"
import axios from "axios";

const Login = () => {

    const navigate = useNavigate();
    const [data, setData] = useState({
        userName : '',
        passCode : ''
    })

    

    const handleChange = event => {
        setData({
            ...data,[event.target.name] : event.target.value  
        })
    }

    const handleSubmit = () => {

        let user = data.userName;
        let pwd = data.passCode;
        alert(user + " " + pwd)
        axios.get("http://localhost:2223/validate/"+user +"/"+pwd)
        .then((response) => {
            if ((response.data) === 1) {
                alert("Correct credentials");
                navigate("/menu");
            } else {
                alert("Invalid Credentials...");
            }
        })

    }
          

    return(
        <div>
            <br/><br/>
           <h1>Login to use the Portal</h1>
            <form>
                <label>
                    User Name : </label>
                    <input type="text" name="userName" onChange={handleChange}
                        value={data.userName} /> <br/><br/>
                <label>Password</label> 
                    <input type="password" name="passCode" onChange={handleChange}
                        value={data.passCode} /> <br/><br/>
                <input type="button" value="Login" onClick={handleSubmit} />
            </form>
        </div>
    )
}

export default Login;









// import axios from "axios";
// import { useState } from "react";
// import {useNavigate} from "react-router-dom" //button navigate dynamically


// const Login=()=>{
//     const navigate = useNavigate();
//     const[data,setData]=useState({
//         userName:'',
//         passCode:''

//     })
  
//     const handleChange = event => {
//         setData({
//             ...data,[event.target.name] : event.target.value  
//         })
//     }
//     const handleSubmit = () => {

//         let user = data.userName;
//         let pwd = data.passCode;
//         alert(user + " " + pwd)
//         axios.get("http://localhost:2222/validate/"+user +"/"+pwd)
//         .then((response) => {
//             if ((response.data) === 1) {
//                 alert("Correct credentials");
//                 navigate("/menu");
//             } else {
//                 alert("Invalid Credentials...");
//             }
//         })

//     }
    
//     return(
//         <div>
//             <br/><br/>
//             <h1>Login to use the Portal</h1>
//             <form onSubmit={handleSubmit}>
//                 <label> User Name: </label>
//                 <input type="text" name="userName" value={data.userName} onChange={handleChange}/><br/><br/>
//                 <label> Pass Code: </label>
//                 <input type="password" name="passCode" value={data.passCode} onChange={handleChange}/><br/><br/>
//                 <input type="submit" value="Login" />
//             </form>
//         </div>
//     )

// }
// export default Login;