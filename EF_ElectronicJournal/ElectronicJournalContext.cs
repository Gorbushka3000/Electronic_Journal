using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EF_ElectronicJournal
{
    public partial class ElectronicJournalContext : DbContext
    {
        public ElectronicJournalContext()
        {
        }

        public ElectronicJournalContext(DbContextOptions<ElectronicJournalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClassNumber> ClassNumbers { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Lesson> Lessons { get; set; } = null!;
        public virtual DbSet<Pass> Passes { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local);Database=ElectronicJournal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasIndex(e => e.LessonId, "IX_Grades_LessonId");

                entity.HasIndex(e => e.StudentId, "IX_Grades_StudentId");

                entity.HasIndex(e => e.TeacherId, "IX_Grades_TeacherId");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.LessonId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentId);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.TeacherId);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Pass>(entity =>
            {
                entity.HasIndex(e => e.LessonId, "IX_Passes_LessonId");

                entity.HasIndex(e => e.StudentId, "IX_Passes_StudentId");

                entity.HasIndex(e => e.TeacherId, "IX_Passes_TeacherId");

                entity.Property(e => e.Pass1)
                    .HasMaxLength(1)
                    .HasColumnName("Pass");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.Passes)
                    .HasForeignKey(d => d.LessonId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Passes)
                    .HasForeignKey(d => d.StudentId);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Passes)
                    .HasForeignKey(d => d.TeacherId);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.HasIndex(e => e.ClassNumberId, "IX_Student_ClassNumberId");

                entity.HasIndex(e => e.TeacherId, "IX_Student_TeacherId");

                entity.HasOne(d => d.ClassNumber)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassNumberId);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.TeacherId);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
