import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import AdminLogin from './pages/AdminLogin';
import './custom.css';
import Index from './pages/Index';

function App() {
  return (
    <Routes>
      <Route path="/login" element={<AdminLogin />} />
      <Route path="/" element={<Index />} />
    </Routes>
  );
}

export default App;