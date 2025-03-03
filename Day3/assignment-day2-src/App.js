import { BrowserRouter, Routes,Route } from 'react-router-dom';
import './App.css';
import Menu from './component/Menu/menu';
import SearchUser from './component/SearchUser/searchUser';
import ShowUser from './component/ShowUser/showUser';
import AddUser from './component/AddUser/addUser';

function App() {
  return (
    <div className="App">
      <h1>Welcome to User History Portal</h1>
      <BrowserRouter>
        <Routes>
          <Route path='/' element={<Menu/>}/>
          <Route path='/searchu' element={<SearchUser/>} />
          <Route path='/addu' element={<AddUser/>} />
          <Route path='/showu' element={<ShowUser/>}/>
          
        </Routes>
      </BrowserRouter>

    </div>
  );
}

export default App;
