//import logo from './logo.svg';
import './App.css';
import Menu from './components/menu/menu';
// import First from './components/first/first'
// import Second from './components/second/second';
// import Third from './components/third/third';
// import Buttex from './components/buttex/buttex';
// import Ffirst from './components/functionalComponents/ffirst';
// import Fsecond from './components/functionalComponents/fsecond';
// import Fthird from './components/functionalComponents/fthird';
// import Fbutton from './components/functionalComponents/fbutton';
// import Faccess from './components/functionalComponents/faccess';
// import Fupdate from './components/functionalComponents/fupdate';
//import Counter from './components/counter/counter';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Ffirst from './components/functionalComponents/ffirst';
import Fsecond from './components/functionalComponents/fsecond';
import Fthird from './components/functionalComponents/fthird';



function App() {
  return (
    <div className="App">
    
    {/* Class components

    <p>I am isha</p>
    <First/><br/>
    <Second/> <br/>
    <Third/><br/>
    <Buttex/> */}


{/* Functional Components
<Ffirst/><br/>
<Fsecond/><br/>
<Fthird fname="Isha" lname="Ghosh"/><br/>
<Fbutton/><br/>
<Faccess/> <br/>
<Fupdate/> */}

{/* <Counter/> */}

<BrowserRouter>
  <Routes>
      <Menu/>
      <Route path="/" element={<Menu/>}/>
      <Route path="/first" element={<Ffirst />} />
        <Route path="/second" element={<Fsecond />} />
        <Route path="/third" element={<Fthird firstName="Isha" lastName="Ghosh" />} />
  </Routes>
</BrowserRouter>

 </div>
    
  );
}

export default App;
