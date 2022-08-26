import React, { useState } from 'react'
import axios from 'axios';
import './YeniAnasayfa';

import './App.css';


 
const Login = () => {
    const [name, setName] = useState('');
    const [password, setPassword] = useState('');
    

    
    const openInNewTab = url => {
        window.open(url, '_blank', 'noopener,noreferrer');
    };


    const handleNameChange = (value) => { setName(value) };

    const handlePasswordChange = (value) => { setPassword(value) };



    const handleLogin = () => {
        const data = {
            Name: name,
            password: password
            

        };
    const url = 'https://localhost:44312/api/yeni1/Login';
    
    axios.post(url,data).then((result) =>{
        alert(result.data);
       
    }).catch((error)=>{
        alert(error);
    }) 

    //window.open('http://localhost:3000/YeniAnasayfa')
    
    
        
    }
    
 
    return (
        <section className="hero has-background-grey-light is-fullheight is-fullwidth">
            <div className="hero-body">
                <div className="container">
                    <div className="columns is-centered">
                        <div className="column is-4-desktop">
                            <form onSubmit={Login} className="box">
                                <p className="has-text-centered">{}</p>
                                <div className="field mt-5">
                                    <label className="label">Kullanıcı Adı</label>
                                    <div className="controls">
                                        <input type="text" className="input" placeholder="Kullanıcı Adı" value={name} onChange={(e) => handleNameChange(e.target.value)} />
                                    </div>
                                </div>
                                <div className="field mt-5">
                                    <label className="label">Şifre</label>
                                    <div className="controls">
                                        <input type="password" className="input" placeholder="******" value={password} onChange={(e) => handlePasswordChange(e.target.value)} />
                                    </div>
                                </div>
                                <div className="field mt-5">
                                    <button onClick={() => handleLogin()} className="button is-success is-fullwidth">Giriş Yap</button>
                                </div>
                                <div className="field mt-5">
                                    <button onClick={() => openInNewTab('http://localhost:3000/register')}  className="button is-success is-fullwidth">Kayıt Ol</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    )
}
 
export default Login

// if(result.data){

//     this.setState({ redirect: anasayfa });

//     window.open('https://www.google.com');

// }