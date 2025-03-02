import Menu from "../menu/menu";

const  Third =(props)=>{
    return(
        <div>
        <Menu/>
        <h1>Name: <b>{props.firstName} {props.lastName}</b></h1>
        </div>
    );
}
export default Third;