using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Core.Data.Generated;

public partial class FinanceDbContext : DbContext
{
    public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Account { get; set; }

    public virtual DbSet<BudgetAllocation> BudgetAllocation { get; set; }

    public virtual DbSet<BudgetMonth> BudgetMonth { get; set; }

    public virtual DbSet<BudgetMove> BudgetMove { get; set; }

    public virtual DbSet<Category> Category { get; set; }

    public virtual DbSet<CategoryGroup> CategoryGroup { get; set; }

    public virtual DbSet<Payee> Payee { get; set; }

    public virtual DbSet<Reconciliation> Reconciliation { get; set; }

    public virtual DbSet<Transaction> Transaction { get; set; }

    public virtual DbSet<TransactionSplit> TransactionSplit { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Account__3214EC272DCEBBAE");

            entity.HasIndex(e => e.AccountName, "UQ__Account__406E0D2E9A39B242").IsUnique();

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.IsOnBudget).HasDefaultValue(true);
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<BudgetAllocation>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__BudgetAl__3214EC27EA1A36DD");

            entity.HasIndex(e => new { e.BudgetMonthId, e.CategoryId }, "UQ_BudgetAllocation").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.BudgetMonth).WithMany(p => p.BudgetAllocation)
                .HasForeignKey(d => d.BudgetMonthId)
                .HasConstraintName("FK_BA_Month");

            entity.HasOne(d => d.Category).WithMany(p => p.BudgetAllocation)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BA_Category");
        });

        modelBuilder.Entity<BudgetMonth>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__BudgetMo__3214EC27064DA53B");

            entity.HasIndex(e => new { e.Year, e.Month }, "UQ_BudgetMonth").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
        });

        modelBuilder.Entity<BudgetMove>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__BudgetMo__3214EC27E07E86C8");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Memo).HasMaxLength(200);

            entity.HasOne(d => d.BudgetMonth).WithMany(p => p.BudgetMove)
                .HasForeignKey(d => d.BudgetMonthId)
                .HasConstraintName("FK_BudgetMove_Month");

            entity.HasOne(d => d.FromCategory).WithMany(p => p.BudgetMoveFromCategory)
                .HasForeignKey(d => d.FromCategoryId)
                .HasConstraintName("FK_BudgetMove_FromCat");

            entity.HasOne(d => d.ToCategory).WithMany(p => p.BudgetMoveToCategory)
                .HasForeignKey(d => d.ToCategoryId)
                .HasConstraintName("FK_BudgetMove_ToCat");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Category__3214EC27B2F0ABAF");

            entity.HasIndex(e => new { e.GroupId, e.CategoryName }, "UQ_Category").IsUnique();

            entity.Property(e => e.CategoryName).HasMaxLength(100);

            entity.HasOne(d => d.Group).WithMany(p => p.Category)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Category_Group");
        });

        modelBuilder.Entity<CategoryGroup>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Category__3214EC2769BCF881");

            entity.HasIndex(e => e.GroupName, "UQ__Category__6EFCD43459992F3B").IsUnique();

            entity.Property(e => e.GroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<Payee>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Payee__3214EC276771C71E");

            entity.HasIndex(e => e.PayeeName, "UQ__Payee__93A5F6A5390F54F4").IsUnique();

            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PayeeName).HasMaxLength(160);
        });

        modelBuilder.Entity<Reconciliation>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Reconcil__3214EC27C0474BE1");

            entity.Property(e => e.BalanceDifference).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StatementBalance).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Account).WithMany(p => p.Reconciliation)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recon_Account");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Transact__3214EC27B7F15357");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Memo).HasMaxLength(400);

            entity.HasOne(d => d.Account).WithMany(p => p.TransactionAccount)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Txn_Account");

            entity.HasOne(d => d.Category).WithMany(p => p.Transaction)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Txn_Category");

            entity.HasOne(d => d.Payee).WithMany(p => p.Transaction)
                .HasForeignKey(d => d.PayeeId)
                .HasConstraintName("FK_Txn_Payee");

            entity.HasOne(d => d.TransferAccount).WithMany(p => p.TransactionTransferAccount)
                .HasForeignKey(d => d.TransferAccountId)
                .HasConstraintName("FK_Txn_TransferAccount");
        });

        modelBuilder.Entity<TransactionSplit>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Transact__3214EC27AAC8A874");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Memo).HasMaxLength(400);

            entity.HasOne(d => d.Category).WithMany(p => p.TransactionSplit)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Split_Category");

            entity.HasOne(d => d.Transaction).WithMany(p => p.TransactionSplit)
                .HasForeignKey(d => d.TransactionId)
                .HasConstraintName("FK_Split_Transaction");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
