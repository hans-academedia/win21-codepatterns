import React from 'react';
import { BrowserRouter, Routes } from 'react-router-dom'
import './App.css';
import UserProvider from './Contexts/UserContext';
import UsersController from './Controllers/UsersController';

function App() {
  return (
    <>
      <UserProvider>
      <BrowserRouter>
        <Routes>       
            <UsersController />
        </Routes>
      </BrowserRouter>
      </UserProvider>
    </>
  );
}

export default App;
