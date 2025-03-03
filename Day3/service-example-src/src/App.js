import './App.css';
// import EmployInsert from './components/EmployInsert/employInsert';
// import EmploySearch from './components/EmploySearch/employSearch';
// import PostSearch from './components/PostSearch/postSearch';
// import UserSearch from './components/UserSearch/userSearch';
// import PostShow from './components/PostShow/postShow';
// import ShowEmploy from './components/ShowEmploy/showEmploy';
// import UserShow from './components/UserShow/userShow';

import { BrowserRouter, Routes,Route } from 'react-router-dom';
import Menu from './components/Menu/menu';
import UserSearch from './components/UserSearch/userSearch';
import PostSearch from './components/PostSearch/postSearch'
import EmploySearch from './components/EmploySearch/employSearch';
import PostShow from './components/PostShow/postShow';
import ShowEmploy from './components/ShowEmploy/showEmploy';
import UserShow from './components/UserShow/userShow';
import EmployInsert from './components/EmployInsert/employInsert';
import Login from './components/login/login';

function App() {
  return (
    <div className="App">
      {/* <UserShow/><br/>
      <PostShow/><br/>
      <ShowEmploy/>
      <UserSearch/>
      <EmploySearch/>
      <PostSearch/>
      <EmployInsert/> */}
      <BrowserRouter>
        <Routes>
          <Route path='/' element={<Login/>}/>
          <Route path='/menu' element={<Menu/>} />
          <Route path='/searchu' element={<UserSearch/>}/>
          <Route path='/searchp' element={<PostSearch/>}/>
          <Route path='/searche' element={<EmploySearch/>}/>
          <Route path='/showu' element={<UserShow/>}/>
          <Route path='/showp' element={<PostShow/>}/>
          <Route path='/showe' element={<ShowEmploy/>}/>
          <Route path='/inserte' element={<EmployInsert/>}/>

        </Routes>
      </BrowserRouter>

    </div>
  );
}

export default App;
