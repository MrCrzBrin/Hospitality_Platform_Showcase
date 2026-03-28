import { Link } from 'react-router-dom';
import { SectionHeader } from '../components/SectionHeader';
import { ProductCard } from '../components/ProductCard';
import { experiences, products } from '../data/content';

export function HomePage() {
  return (
    <>
      <section className="hero-section">
        <div className="hero-overlay" />
        <div className="container hero-content">
          <p className="eyebrow eyebrow-light">Boutique Hospitality Prototype</p>
          <h1>Curated Excellence</h1>
          <p className="hero-text">
            A premium product showcase and lounge concept built to present
            modern hospitality, aesthetic merchandising, and immersive guest
            experiences.
          </p>
          <div className="button-row">
            <Link className="button button-primary" to="/catalog">
              Explore Catalog
            </Link>
            <Link className="button button-secondary" to="/experience">
              View Experience
            </Link>
          </div>
        </div>
      </section>

      <section className="section container">
        <SectionHeader
          eyebrow="Featured Collection"
          title="Designed to feel modern, refined, and memorable."
          text="This prototype focuses on premium presentation, product storytelling, and a boutique showroom atmosphere."
        />
        <div className="card-grid">
          {products.map((product) => (
            <ProductCard key={product.id} product={product} />
          ))}
        </div>
      </section>

      <section className="section section-alt">
        <div className="container">
          <SectionHeader
            eyebrow="Experience Zones"
            title="More than a catalog: a complete in-location concept."
            text="Use dedicated sections to promote relaxation areas, entertainment corners, and signature ritual spaces."
          />
          <div className="experience-grid">
            {experiences.map((experience) => (
              <article className="experience-card" key={experience.title}>
                <img src={experience.image} alt={experience.title} />
                <div className="experience-body">
                  <h3>{experience.title}</h3>
                  <p className="muted">{experience.text}</p>
                </div>
              </article>
            ))}
          </div>
        </div>
      </section>
    </>
  );
}
