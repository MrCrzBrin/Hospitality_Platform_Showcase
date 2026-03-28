export type Product = {
  id: string;
  name: string;
  category: string;
  profile: string;
  origin: string;
  image: string;
  description: string;
  tags: string[];
};

export const products: Product[] = [
  {
    id: 'amber-reserve',
    name: 'Amber Reserve',
    category: 'Signature Collection',
    profile: 'Warm citrus · floral finish',
    origin: 'Small-batch indoor cultivation',
    image:
      'https://images.unsplash.com/photo-1514933651103-005eec06c04b?auto=format&fit=crop&w=1200&q=80',
    description:
      'A premium showcase item designed to highlight small-batch quality, structure, aroma notes, and visual identity in a refined boutique setting.',
    tags: ['premium', 'small batch', 'featured']
  },
  {
    id: 'velvet-noir',
    name: 'Velvet Noir',
    category: 'Curated Drops',
    profile: 'Deep berry · smooth finish',
    origin: 'Limited presentation series',
    image:
      'https://images.unsplash.com/photo-1504674900247-0877df9cc836?auto=format&fit=crop&w=1200&q=80',
    description:
      'Crafted for a dark, premium mood. Built to represent boutique storytelling, selective drops, and a luxury-forward visual presentation.',
    tags: ['exclusive', 'limited', 'editorial']
  },
  {
    id: 'golden-hour',
    name: 'Golden Hour',
    category: 'House Favorites',
    profile: 'Bright fruit · soft herbal notes',
    origin: 'Designer showcase line',
    image:
      'https://images.unsplash.com/photo-1517248135467-4c7edcad34c4?auto=format&fit=crop&w=1200&q=80',
    description:
      'A lighter, welcoming flagship item used to demonstrate elegant merchandising, feature callouts, and catalog filtering.',
    tags: ['boutique', 'house pick', 'balanced']
  }
];

export const experiences = [
  {
    title: 'Lounge Corner',
    text: 'A soft seating zone with atmospheric lighting, curated décor, and a premium hospitality mood for extended stays.',
    image:
      'https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?auto=format&fit=crop&w=1200&q=80'
  },
  {
    title: 'Gaming Lounge',
    text: 'A modern console area with large display screens, audio setup, and a social entertainment feel for guests.',
    image:
      'https://images.unsplash.com/photo-1542751371-adc38448a05e?auto=format&fit=crop&w=1200&q=80'
  },
  {
    title: 'Signature Ritual Bar',
    text: 'A premium ritual zone for specialty devices, beverages, accessories, and curated table presentation.',
    image:
      'https://images.unsplash.com/photo-1514362545857-3bc16c4c7d1b?auto=format&fit=crop&w=1200&q=80'
  }
];
