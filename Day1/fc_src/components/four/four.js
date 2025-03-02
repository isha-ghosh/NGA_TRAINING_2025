import { useState } from "react";
import Menu from "../menu/menu";
const Four= () => {
    const [firstName] = useState('Isha')
    const [lastName] = useState('Ghoshhh')
    return(
        <div>
            <Menu/>
            <p>
                First Name is : {firstName} <br/>
                Last Name is : {lastName}<br/>
            </p>
        </div>
    )
}
export default Four;