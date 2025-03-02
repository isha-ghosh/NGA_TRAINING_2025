import { useState } from "react";
const Faccess= () => {
    const [firstName] = useState('Isha')
    const [lastName] = useState('Ghoshhh')
    return(
        <div>
            <p>
                First Name is : {firstName} <br/>
                Last Name is : {lastName}<br/>
            </p>
        </div>
    )
}
export default Faccess;