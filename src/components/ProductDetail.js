import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import './ProductDetail.css';

const ProductDetail = () => {
    const { id } = useParams();
    const [product, setProduct] = useState(null);

    useEffect(() => {
        fetch(`https://fakestoreapi.com/products/${id}`)
            .then(response => response.json())
            .then(data => setProduct(data))
            .catch(error => console.error('Error fetching product details:', error));
    }, [id]);

    return (
        <div className="product-details">
            <h1>Detalles del Producto</h1>
            {product ? (
                <div>
                    <h2>{product.title}</h2>
                    <p>Precio: ${product.price}</p>
                    <p>Stock: {product.stock}</p>
                    <p>Código: {product.code}</p>
                    <p>Descripción: {product.description}</p>
                </div>
            ) : (
                <p>Cargando detalles del producto...</p>
            )}
        </div>
    );
}

export default ProductDetail;
