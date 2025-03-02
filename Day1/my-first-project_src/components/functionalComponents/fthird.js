import Menu from "../menu/menu";

const  Fthird =(props)=>{
    return(
        <div>
        <Menu/>
        <h1>Name: <b>{props.fname} {props.lname}</b></h1>
        </div>
    );
}
export default Fthird;