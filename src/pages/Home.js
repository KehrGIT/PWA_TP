import React from 'react';
import './Home.css';

const Home = () => {
  return (
    <div className="home-container">
      <h1 className="welcome-message">Bienvenido a nuestra tienda en línea</h1>
      <div className="featured-products">
        <div className="featured-product">
          <img src="https://via.placeholder.com/150" alt="Product 1" />
          <h2 className="product-title">Producto 1</h2>
          <p className="product-price">$19.99</p>
        </div>
        <div className="featured-product">
          <img src="https://via.placeholder.com/150" alt="Product 2" />
          <h2 className="product-title">Producto 2</h2>
          <p className="product-price">$24.99</p>
        </div>
        <div className="featured-product">
          <img src="https://via.placeholder.com/150" alt="Product 3" />
          <h2 className="product-title">Producto 3</h2>
          <p className="product-price">$29.99</p>
        </div>
      </div>
    </div>
  );
}

export default Home;
