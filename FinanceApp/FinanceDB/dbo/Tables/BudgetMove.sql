CREATE TABLE dbo.BudgetMove(
  ID             INT IDENTITY(1,1) PRIMARY KEY,
  BudgetMonthId  INT NOT NULL,
  FromCategoryId INT NULL,
  ToCategoryId   INT NULL,
  Amount         DECIMAL(18,2) NOT NULL CHECK (Amount > 0),
  Memo           NVARCHAR(200) NULL,
  CreatedAt      DATETIME2(0) NOT NULL CONSTRAINT DF_BudgetMove_Created DEFAULT (SYSUTCDATETIME()),
  CONSTRAINT CK_BudgetMove_AtLeastOneSide CHECK (FromCategoryId IS NOT NULL OR ToCategoryId IS NOT NULL),
  CONSTRAINT CK_BudgetMove_NotSame        CHECK (FromCategoryId IS NULL OR ToCategoryId IS NULL OR FromCategoryId <> ToCategoryId),
  CONSTRAINT FK_BudgetMove_Month   FOREIGN KEY (BudgetMonthId)  REFERENCES dbo.BudgetMonth(Id) ON DELETE CASCADE,
  CONSTRAINT FK_BudgetMove_FromCat FOREIGN KEY (FromCategoryId) REFERENCES dbo.Category(Id),
  CONSTRAINT FK_BudgetMove_ToCat   FOREIGN KEY (ToCategoryId)   REFERENCES dbo.Category(Id)
);
