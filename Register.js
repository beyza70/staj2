import React, { useState } from 'react'
import axios from "axios";

 
const Register = () => {
    const [name, setName] = useState('');
    const [password, setPassword] = useState('');
    const [soyadi, StrictMode] = useState('');
    const [adi,set] = useState('');
    
   
 
    const handleNameChange = (value) => { setName(value) };

    const handlePasswordChange = (value) => { setPassword(value) };

    const handleSoyadiChange = (value) => { StrictMode(value) };

    const handleAdiChange = (value) => { set(value) };



    const handleSave = () => {
        const data = {
            Name: name,
            password: password,
            soyadi:soyadi,
            adi:adi
           

        };
    const url = 'https://localhost:44312/api/yeni1/Registration';
    axios.post(url,data).then((result) =>{
        alert(result.data);
    }).catch((error)=>{
        alert(error);
    })   
        
    }
 
    return (
        <section className="hero has-background-grey-light is-fullheight is-fullwidth">
            <div className="hero-body">
                <div className="container">
                    <div className="columns is-centered">
                        <div className="column is-4-desktop">
                            <form onSubmit={Register} className="box">
                                <p className="has-text-centered">{}</p>
                                <div className="field mt-5">
                                    <label className="label">Ad</label>
                                    <div className="controls">
                                        <input type="text" className="input" placeholder="Ad"
                                            value={adi} onChange={(e) => handleAdiChange(e.target.value)} />
                                    </div>
                                </div>
                                <div className="field mt-5">
                                    <label className="label">Soyad</label>
                                    <div className="controls">
                                        <input type="text" className="input" placeholder="Soyad"
                                            value={soyadi} onChange={(e) => handleSoyadiChange(e.target.value)} />
                                    </div>
                                </div>
                                <div className="field mt-5">
                                    <label className="label">Kullanıcı Adı</label>
                                    <div className="controls">
                                        <input type="text" className="input" placeholder="Kullanıcı Adı"
                                            value={name} onChange={(e) => handleNameChange(e.target.value)} />
                                    </div>
                                </div>
                                <div className="field mt-5">
                                    <label className="label">Şifre</label>
                                    <div className="controls">
                                        <input type="password" className="input" placeholder="******" value={password} onChange={(e) => handlePasswordChange(e.target.value)} />
                                    </div>
                                </div>
                               
                                <div className="field mt-5">
                                    <button onClick={() => handleSave()} className="button is-success is-fullwidth">Kayıt Ol</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    )
}
 
export default Register