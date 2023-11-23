// NavBar.js
import React from 'react';
import './NavBar.css';
import { Link } from 'react-router-dom';

const NavBar = () => {
  return (
    <nav className="navbar">
      <div className="logo">Logo de la Tienda</div>
      <ul className="nav-links">
        <li><Link to="/">Inicio</Link></li>
        <li><Link to="/products">Productos</Link></li>
        <li><Link to="/registration">Registro</Link></li>
        <li><Link to="/login">Inicio de Sesión</Link></li>
      </ul>
    </nav>
  );
}

export default NavBar;
