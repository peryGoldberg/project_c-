using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Dal_Repository.Model
{
    public partial class LearningPlatformContext : DbContext
    {
        private readonly IConfiguration configuration;

        public LearningPlatformContext(IConfiguration _configuration, DbContextOptions<LearningPlatformContext> options) : base(options)
        {
            configuration = _configuration;
        }
        public LearningPlatformContext()
        {
        }

        public LearningPlatformContext(DbContextOptions<LearningPlatformContext> options)
            : base(options)
        {
        }



        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<LearningMode> LearningModes { get; set; } = null!;
        public virtual DbSet<Lecturer> Lecturers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(configuration.GetConnectionString("myConnection"));
        //    }
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = configuration.GetConnectionString("myConnection");
                // optionsBuilder.UseSqlServer(connectionString);

                optionsBuilder.UseSqlServer("Server=DESKTOP-SI8MC0H;Database=LearningPlatform;Trusted_Connection=True;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.IconPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LecturerId).HasColumnName("LecturerID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Syllabus).HasColumnType("text");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Course__Category__3A81B327");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LecturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Course__Lecturer__3B75D760");

                entity.HasOne(d => d.Mode)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.ModeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Course__ModeId__398D8EEE");
            });

            modelBuilder.Entity<LearningMode>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK__Learning__D83F75C4B9BAF021");

                entity.ToTable("LearningMode");

                entity.Property(e => e.ModeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.ToTable("Lecturer");

                entity.HasIndex(e => e.Email, "UQ__Lecturer__A9D10534A7F638FA")
                    .IsUnique();

                entity.Property(e => e.LecturerId).HasColumnName("LecturerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Users__A9D105346FBECDD6")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
