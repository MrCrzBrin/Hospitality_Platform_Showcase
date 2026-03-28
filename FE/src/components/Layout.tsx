import { Link, NavLink } from 'react-router-dom';
import { PropsWithChildren } from 'react';

const navItems = [
  { to: '/', label: 'Home' },
  { to: '/catalog', label: 'Catalog' },
  { to: '/experience', label: 'Experience' },
  { to: '/about', label: 'About' },
  { to: '/contact', label: 'Contact' }
];

export function Layout({ children }: PropsWithChildren) {
  return (
    <div className="app-shell">
      <header className="site-header">
        <div className="container nav-row">
          <Link to="/" className="brand-mark">
            ATELIER
          </Link>
          <nav className="nav-links">
            {navItems.map((item) => (
              <NavLink
                key={item.to}
                to={item.to}
                className={({ isActive }) =>
                  isActive ? 'nav-link nav-link-active' : 'nav-link'
                }
              >
                {item.label}
              </NavLink>
            ))}
          </nav>
        </div>
      </header>
      <main>{children}</main>
      <footer className="site-footer">
        <div className="container footer-grid">
          <div>
            <div className="brand-mark footer-brand">ATELIER</div>
            <p className="muted">
              Boutique hospitality showcase prototype with curated catalog,
              experience zones, and premium storytelling.
            </p>
          </div>
          <div>
            <p className="footer-title">Prototype Scope</p>
            <p className="muted">React · TypeScript · Routing · Reusable UI</p>
          </div>
        </div>
      </footer>
    </div>
  );
}
