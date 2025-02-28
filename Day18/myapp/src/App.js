
import './App.css';
//import FDemo  from './components/FunctionalDemo';
//import ClassDemo1 from './components/ClassDemo';
import { Route,Routes } from 'react-router-dom';
import AboutUs from './components/AboutUs';
import ContactUs from './components/ContactUs';
import Home from './components/Home';
import NoMatch from './components/NoMatch';
import Menu from './components/Menu';


function App() {
  return (
   /*
    <div className='App'>
       <ClassDemo1 sitevisited = "2"/>
      <FDemo username = "Isha"/>
     
    </div>*/
    <div>
      <Menu/>
      <Routes>
        <Route path ='/' element={<Home/>}></Route>
        <Route path ='/contact' element={<ContactUs/>}></Route>
        <Route path ='/about' element={<AboutUs/>}></Route>
        <Route path ='*' element={<NoMatch/>}></Route>
      </Routes>
    </div>
  );
}

export default App;
