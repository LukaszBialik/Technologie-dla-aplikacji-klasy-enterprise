import { useParams, Link } from 'react-router-dom';

function ProductDetails({ products }) {
  const { id } = useParams();
  
  const filtered = products.filter(p => p.id === parseInt(id));
  
  if (filtered.length === 0) {
    return null;
  }

  const product = filtered[0];

  return (
    <div>

      <h1>{product.title}</h1>
      
      Category: {product.category} <br />
      Brand: {product.brand} <br />
      Description: {product.description} <br />
      Price: {product.price}$ <br />
      <img src={product.thumbnail} alt={product.title} />
      <br /><br />
      
      <Link to="/">Wróć do listy produktów</Link>
    </div>
  );
}

export default ProductDetails;