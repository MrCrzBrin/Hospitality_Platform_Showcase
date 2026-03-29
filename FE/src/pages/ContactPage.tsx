export function ContactPage() {
  return (
    <section className="section container section-top-gap">
      <div className="contact-grid">
        <div>
          <p className="eyebrow">Contact</p>
          <h1>Request a concept walkthrough.</h1>
          <p className="section-text">
            Ideal for showcasing how a venue could combine premium product
            presentation with lounge-based hospitality and curated guest
            experiences.
          </p>
        </div>
        <form className="contact-form">
          <label>
            Name
            <input type="text" placeholder="Your name" />
          </label>
          <label>
            Business / Venue
            <input type="text" placeholder="Studio, lounge, or concept brand" />
          </label>
          <label>
            Email
            <input type="email" placeholder="name@example.com" />
          </label>
          <label>
            Message
            <textarea rows={5} placeholder="Tell us about the concept you want to present." />
          </label>
          <button type="button" className="button button-primary">
            Send inquiry
          </button>
        </form>
      </div>
    </section>
  );
}
