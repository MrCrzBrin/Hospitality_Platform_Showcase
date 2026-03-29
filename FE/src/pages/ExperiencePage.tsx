import { SectionHeader } from '../components/SectionHeader';
import { experiences } from '../data/content';

export function ExperiencePage() {
  return (
    <section className="section container section-top-gap">
      <SectionHeader
        eyebrow="In-Store Experience"
        title="Spaces that turn a visit into a memorable hospitality moment."
        text="Use this page to explain the added value of lounge, social, and entertainment areas in a premium venue concept."
      />
      <div className="stack-list">
        {experiences.map((experience, index) => (
          <article className="experience-row" key={experience.title}>
            <img src={experience.image} alt={experience.title} />
            <div>
              <p className="eyebrow">Zone 0{index + 1}</p>
              <h3>{experience.title}</h3>
              <p className="muted">{experience.text}</p>
            </div>
          </article>
        ))}
      </div>
    </section>
  );
}
