import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import './ProductList.css';

const ProductList = () => {
    const [productos, setProductos] = useState([]);
    const [loading, setLoading] = useState(false);

    useEffect(() => {
        fetch('https://fakestoreapi.com/products')
            .then(response => response.json())
            .then(data => {
                setProductos(data);
                setLoading(false);
            })
            .catch(error => {
                console.log(error);
                setLoading(false);
            });
    }, []);

    return (
        <div>
            <h1>Productos</h1>
            {loading ? (
                <p>Cargando Producto</p>
            ) : (
                <ul className="producto_lista">
                    {productos.map(producto => (
                        <li key={producto.id} className="producto_item">
                            <h3>{producto.title}</h3>
                            <p>Precio: ${producto.price}</p>
                            <Link to={`/product/${producto.id}`}>Ver Detalles</Link>
                        </li>
                    ))}
                </ul>
            )}
        </div>
    );
};

export default ProductList;
