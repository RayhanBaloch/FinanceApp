CREATE TABLE dbo.BudgetAllocation(
  ID            INT IDENTITY(1,1) PRIMARY KEY,
  BudgetMonthId INT NOT NULL,
  CategoryId    INT NOT NULL,
  Amount        DECIMAL(18,2) NOT NULL CONSTRAINT DF_BudgetAllocation_Amt DEFAULT(0),
  CONSTRAINT UQ_BudgetAllocation UNIQUE (BudgetMonthId, CategoryId),
  CONSTRAINT FK_BA_Month    FOREIGN KEY (BudgetMonthId) REFERENCES dbo.BudgetMonth(Id) ON DELETE CASCADE,
  CONSTRAINT FK_BA_Category FOREIGN KEY (CategoryId)    REFERENCES dbo.Category(Id)
);