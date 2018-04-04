using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ALFnavobjectpermissionsreportNetCoreWebAPI
{
    public partial class navobjectpermissionsreportsqldatabaseContext : DbContext
    {
        public virtual DbSet<Data> Data { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=tcp:alexef0test0navsqlserverazure.database.windows.net,1433;Initial Catalog=navobjectpermissionsreportsqldatabase;Persist Security Info=False;User ID=finn777;Password=Trantor2050;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>(entity =>
            {
                entity.ToTable("data");

                entity.Property(e => e.Dataid).HasColumnName("dataid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Moduleid).HasColumnName("moduleid");

                entity.Property(e => e.Modulename)
                    .HasColumnName("modulename")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Objecttype)
                    .HasColumnName("objecttype")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Pdelete)
                    .HasColumnName("pdelete")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pexecute)
                    .HasColumnName("pexecute")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pinsert)
                    .HasColumnName("pinsert")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pmodify)
                    .HasColumnName("pmodify")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pread)
                    .HasColumnName("pread")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Productline)
                    .HasColumnName("productline")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Rangefrom).HasColumnName("rangefrom");

                entity.Property(e => e.Rangeto).HasColumnName("rangeto");

                entity.Property(e => e.Versionname)
                    .HasColumnName("versionname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
