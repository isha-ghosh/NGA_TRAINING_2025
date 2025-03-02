import {useState} from 'react'

const First=()=>{
    const[name,setName]=useState('')
    const isha = () => {
        setName("Hi I am isha...")
    }
    const disha = () => {
        setName("Hi I am disha...")
    }
    const mita = () => {
        setName("Hi I am mita...")
    }

    return(
        <div>
            <p>Student name is:{name}</p>
            <br/>
            <hr/>
            <br/>
            
            <input type="button" value="Isha" onClick={isha}/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="button" value="Disha" onClick={disha}/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="button" value="Mita" onClick={mita}/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        </div>
    );
}
export default First;