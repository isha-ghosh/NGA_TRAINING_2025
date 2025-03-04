import logo from './logo.svg';
import './App.css';
import RefEX1 from './components/RefEx1/refEx';
import RefEX2 from './components/RefEx2/refEx2';
import UseMem1 from './components/Memo1/memo1';
import UseMemo2 from './components/Memo2/memo2';
import UseMemo3 from './components/Memo3/memo3';
import ContextEx1 from './components/ContextEx1/contextEx1';
import ContextEx2 from './components/ContextEx2/contextEx2';
import ThemeContextEx1 from './components/ThemeContextEx1/themeContextEx1';
import UserShow from './components/UserShow/userShow';

function App() {
  return (
    <div className="App">
      <RefEX1/><br/>
      <RefEX2/><br/>
      <UseMem1/><br/>
      <UseMemo2/><br/>
      <UseMemo3/> <br/>
      <ContextEx1/> <hr/>
      <ContextEx2/><hr/>
      <ThemeContextEx1/><hr/>
      <UserShow/>

    </div>
  );
}

export default App;
