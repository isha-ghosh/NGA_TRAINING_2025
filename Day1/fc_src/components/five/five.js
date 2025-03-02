import { useState } from "react";
import Menu from "../menu/menu";
const Five = () => {
    const [firstName, setFirstNameeee] = useState('kiki')
    const update = () => {
        setFirstNameeee("Disha")
    }
    return(
        <div>
            <Menu/>
            First Name is : {firstName} 
            <br/>
            <input type="button" value="Change" onClick={update} />
        </div>
    )
}
export default Five;