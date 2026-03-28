import { Link } from 'react-router-dom';
import type { Product } from '../data/content';

export function ProductCard({ product }: { product: Product }) {
  return (
    <article className="product-card">
      <img className="product-card-image" src={product.image} alt={product.name} />
      <div className="product-card-body">
        <p className="eyebrow">{product.category}</p>
        <h3>{product.name}</h3>
        <p className="muted">{product.profile}</p>
        <div className="tag-row">
          {product.tags.map((tag) => (
            <span key={tag} className="tag">
              {tag}
            </span>
          ))}
        </div>
        <Link className="text-link" to={`/catalog/${product.id}`}>
          View details →
        </Link>
      </div>
    </article>
  );
}
