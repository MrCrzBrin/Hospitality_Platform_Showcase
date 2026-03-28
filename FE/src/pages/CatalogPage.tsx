import { ProductCard } from '../components/ProductCard';
import { SectionHeader } from '../components/SectionHeader';
import { products } from '../data/content';

export function CatalogPage() {
  return (
    <section className="section container section-top-gap">
      <SectionHeader
        eyebrow="Product Catalog"
        title="Curated product cards with boutique styling."
        text="This prototype can later be extended with backend data, filters, categories, and API-driven content."
      />
      <div className="filter-bar">
        <span className="filter-pill active">All</span>
        <span className="filter-pill">Signature Collection</span>
        <span className="filter-pill">Curated Drops</span>
        <span className="filter-pill">House Favorites</span>
      </div>
      <div className="card-grid">
        {products.map((product) => (
          <ProductCard key={product.id} product={product} />
        ))}
      </div>
    </section>
  );
}
