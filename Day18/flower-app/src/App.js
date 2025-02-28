
import './App.css';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import Middle from "./components/Middle";
import Footer from "./components/Footer";
import About from "./components/About";
import Contact from "./components/Contact";
import Login from './components/Login';

 //import Menu from './components/Menu';


function App() {
  return (
    <Router>
    <div className="app-container">

      <Header/>
      
      <Routes>
      
        <Route path="/" element={<Middle />} />
        <Route path="/about" element={<About />} />
        <Route path="/contact" element={<Contact />} />
        <Route path="/login" element={<Login />} />
      

      </Routes>
      <Footer />
    </div>
  </Router>
  );
}

export default App;
