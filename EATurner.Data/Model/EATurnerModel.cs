namespace EATurner.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class EATurnerModel : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EATurnerModel"/> class.
        /// </summary>
        public EATurnerModel()
            : base("name=EATurnerModel")
        {
          
        }

        /// <summary>
        /// Gets or sets the awards.
        /// </summary>
        /// <value>
        /// The awards.
        /// </value>
        public virtual DbSet<Award> Awards { get; set; }
        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        public virtual DbSet<Genre> Genres { get; set; }
        /// <summary>
        /// Gets or sets the other names.
        /// </summary>
        /// <value>
        /// The other names.
        /// </value>
        public virtual DbSet<OtherName> OtherNames { get; set; }
        /// <summary>
        /// Gets or sets the participants.
        /// </summary>
        /// <value>
        /// The participants.
        /// </value>
        public virtual DbSet<Participant> Participants { get; set; }
        /// <summary>
        /// Gets or sets the story lines.
        /// </summary>
        /// <value>
        /// The story lines.
        /// </value>
        public virtual DbSet<StoryLine> StoryLines { get; set; }
        /// <summary>
        /// Gets or sets the titles.
        /// </summary>
        /// <value>
        /// The titles.
        /// </value>
        public virtual DbSet<Title> Titles { get; set; }
        /// <summary>
        /// Gets or sets the title genres.
        /// </summary>
        /// <value>
        /// The title genres.
        /// </value>
        public virtual DbSet<TitleGenre> TitleGenres { get; set; }
        public virtual DbSet<TitleParticipant> TitleParticipants { get; set; }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.
        /// </remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(e => e.TitleGenres)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Participant>()
                .HasMany(e => e.TitleParticipants)
                .WithRequired(e => e.Participant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.Awards)
                .WithRequired(e => e.Title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.StoryLines)
                .WithRequired(e => e.Title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.TitleGenres)
                .WithRequired(e => e.Title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.TitleParticipants)
                .WithRequired(e => e.Title)
                .WillCascadeOnDelete(false);
        }
    }
}
