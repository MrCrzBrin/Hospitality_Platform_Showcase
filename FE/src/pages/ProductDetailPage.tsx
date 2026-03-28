import { Link, useParams } from 'react-router-dom';
import { products } from '../data/content';

export function ProductDetailPage() {
  const { productId } = useParams();
  const product = products.find((item) => item.id === productId);

  if (!product) {
    return (
      <section className="section container section-top-gap">
        <h1>Item not found</h1>
        <Link className="text-link" to="/catalog">
          Return to catalog →
        </Link>
      </section>
    );
  }

  return (
    <section className="section container section-top-gap">
      <div className="detail-grid">
        <img className="detail-image" src={product.image} alt={product.name} />
        <div>
          <p className="eyebrow">{product.category}</p>
          <h1>{product.name}</h1>
          <p className="detail-lead">{product.description}</p>
          <div className="detail-panel">
            <div>
              <span className="detail-label">Profile</span>
              <p>{product.profile}</p>
            </div>
            <div>
              <span className="detail-label">Origin</span>
              <p>{product.origin}</p>
            </div>
            <div>
              <span className="detail-label">Positioning</span>
              <p>Premium showcase with visual storytelling and refined details.</p>
            </div>
          </div>
          <div className="tag-row">
            {product.tags.map((tag) => (
              <span key={tag} className="tag">
                {tag}
              </span>
            ))}
          </div>
          <Link className="button button-primary" to="/contact">
            Inquire about concept
          </Link>
        </div>
      </div>
    </section>
  );
}
