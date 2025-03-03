import axios from "axios";
import {  useState } from "react";
import Menu from "../Menu/menu";

const PostSearch = () => {
    const[postResult, SetPostResult] = useState({})//return single or 0 record
    const[postId,SetPostId] = useState(0)  
    const handleChange = event => {
        SetPostId(event.target.value)
         }
    const show = () => {
            // alert(userId)
            let pid = parseInt(postId);
            axios.get("http://jsonplaceholder.typicode.com/posts/"+pid).then(
                (response) => {
                    SetPostResult(response.data)
                }  
              )
          
        }
        return(
            <div>
                <Menu/>
                <label> Post Id : </label>
                <input type="number" name="postId" value={postId} onChange={handleChange} /> <br/>
                <input type="button" value="Show" onClick={show} />
                <hr/>
                
                User Id : <b>{postResult.userId}</b> <br/>
                ID: <b>{postResult.id}</b> <br/>
                Title : <b>{postResult.title}</b> <br/>
                Body : <b>{postResult.body}</b>
                <hr/>
            </div>
        )
}
export default PostSearch;