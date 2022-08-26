import React, { useState } from "react";
import "./App.css";
import Axios from 'axios';

function App() {

  const [usernameReg, setUsernameReg] =useState("");
  const [passwordReg, setPasswordReg] =useState("");

  const register = () => {
    Axios.post("https://localhost3001/register",{
      username: usernameReg,
      password: passwordReg,
    }).then((response) => {
      console.log(response);
    });
  };


  return (
    <div className="App">
      <div className="registration">
        <h1>Kayıt Ol</h1>
        <label>Username</label>
        <input
        type="text"
        onChange={(e) => {
          setUsernameReg(e.target.value);
        }}
        />
        <label>Password</label>
        <input type= "text"
        onChange={(e) => {
          setPasswordReg(e.target.value);
        }}/>
        <button>Kaydet</button>
      </div>
      <div className="login">
        <h1>Login</h1>
        <input type= "text" placeholder="Username..."/>
        <input type= "password" placeholder="Password..."/>
        <button>Giriş</button>


      </div>



    </div>
  );
}

export default App;