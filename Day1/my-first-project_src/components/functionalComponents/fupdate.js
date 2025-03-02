import { useState } from "react";
const Fupdate = () => {
    const [firstName, setFirstNameeee] = useState('kiki')
    const update = () => {
        setFirstNameeee("Disha")
    }
    return(
        <div>
            First Name is : {firstName} 
            <br/>
            <input type="button" value="Change" onClick={update} />
        </div>
    )
}
export default Fupdate;