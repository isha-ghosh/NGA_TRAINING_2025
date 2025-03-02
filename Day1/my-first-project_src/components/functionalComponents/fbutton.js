const Fbutton=()=>{

    const isha=()=>{
        alert("i am Isha");
    }
    const disha=()=>{
        alert("i am Disha");
    }

    return(
        <div>
            <input type="button" value="Isha" onClick={isha}/>
            &nbsp;&nbsp;
            <input type="button" value="Disha" onClick={disha}/>
            &nbsp;&nbsp;

        </div>
    );
}
export default Fbutton;