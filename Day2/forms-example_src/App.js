
import './App.css';
import Calc from './components/calc/calc';
import First from "./components/first/first"
import Login from './components/login/login';
import Second from './components/second/second';
import Third from './components/third/third';

function App() {
  return (
    <div className="App">
      <First/> <br/>
      <Second/><br/>
      <Third/> <br/>
      <Login/> <br/>
      <Calc/>
    </div>
  );
}

export default App;
