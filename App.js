
import {
  BrowserRouter,
  Routes,
  Route,
} from "react-router-dom";
import './App.css';
import Login from './Login';
import Register from './Register';
import YeniAnasayfa from "./YeniAnasayfa";



function App() {
  return (
    <div className="App">
      <BrowserRouter>
    <Routes>
      <Route path="/" element={<Login />} />
      <Route path="register" element={<Register />} />
      <Route path="yenianasayfa" element={<YeniAnasayfa />} />
      
    </Routes>
  </BrowserRouter>
      
    </div>
  );
}

export default App;

/* <Register/>
<br></br>
<Login/>
<br></br>
<anasayfa/> */