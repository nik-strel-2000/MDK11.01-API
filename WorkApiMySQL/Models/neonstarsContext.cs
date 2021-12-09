using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkApiMySQL.Models
{
    public partial class neonstarsContext : DbContext
    {
        public neonstarsContext()
        {
        }

        public neonstarsContext(DbContextOptions<neonstarsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<HibernateSequence> HibernateSequence { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<TRole> TRole { get; set; }
        public virtual DbSet<TUser> TUser { get; set; }
        public virtual DbSet<TUserRoles> TUserRoles { get; set; }
        public virtual DbSet<TypeProduct> TypeProduct { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=Ratatar2002;database=neonstars");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PRIMARY");

                entity.ToTable("employee");

                entity.HasIndex(e => e.PositionIdPosition)
                    .HasName("FK5ixaatsk14tl1iou19kihhmta");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(255);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasMaxLength(255);

                entity.Property(e => e.NumberPhone)
                    .HasColumnName("number_phone")
                    .HasMaxLength(255);

                entity.Property(e => e.PositionIdPosition).HasColumnName("position_id_position");

              
            });

            modelBuilder.Entity<HibernateSequence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hibernate_sequence");

                entity.Property(e => e.NextVal).HasColumnName("next_val");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.IdPosition)
                    .HasName("PRIMARY");

                entity.ToTable("post");

                entity.Property(e => e.IdPosition).HasColumnName("id_position");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PRIMARY");

                entity.ToTable("products");

                entity.HasIndex(e => e.TypeProductIdTypeProduct)
                    .HasName("FK85bpj14wso5hpjqmevv4xofgo");

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeMaterial)
                    .HasColumnName("type_material")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeProductIdTypeProduct).HasColumnName("type_product_id_type_product");

                entity.HasOne(d => d.TypeProductIdTypeProductNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.TypeProductIdTypeProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK85bpj14wso5hpjqmevv4xofgo");
            });

            modelBuilder.Entity<TRole>(entity =>
            {
                entity.ToTable("t_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.ToTable("t_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RolesId })
                    .HasName("PRIMARY");

                entity.ToTable("t_user_roles");

                entity.HasIndex(e => e.RolesId)
                    .HasName("FKj47yp3hhtsoajht9793tbdrp4");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.RolesId).HasColumnName("roles_id");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.TUserRoles)
                    .HasForeignKey(d => d.RolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKj47yp3hhtsoajht9793tbdrp4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpqntgokae5e703qb206xvfdk3");
            });

            modelBuilder.Entity<TypeProduct>(entity =>
            {
                entity.HasKey(e => e.IdTypeProduct)
                    .HasName("PRIMARY");

                entity.ToTable("type_product");

                entity.Property(e => e.IdTypeProduct).HasColumnName("id_type_product");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
