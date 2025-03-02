
import './App.css';
import First from './components/first/first';
import Second from './components/second/second';
import Third from './components/third/third';
import Button from './components/button/button';
import Four from './components/four/four';
import Five from './components/five/five';
import Counter from './components/counter/counter';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Menu from './components/menu/menu';
import Login from './components/login/login';

function App() {
  return (
    <div className="App">
      
     Welcome to Functional Components...Isha Ghosh <br/><hr/>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/menu" element={<Menu />} />
        <Route path="/first" element={<First />} />
        <Route path="/second" element={<Second />} />
        <Route path="/third" element={<Third firstName="Disha" lastName="Ghosh" />} /> 
        <Route path="/four" element={<Four />} />
        <Route path="/five" element={<Five />} /> 
        <Route path="/button" element={<Button />} />
        <Route path="/counter" element={<Counter />} />
      </Routes>
    </BrowserRouter>
     {/* <First /> <br/>
     <Second /> <br/>
     <Third firstName="Ajay" lastName="Kandagatla"  /> <br/> 
     <Four />
     <ButtonEx /> <hr/>
     <Five /> <br/>
     <Counter /> */}
    </div>
  );
}

export default App;