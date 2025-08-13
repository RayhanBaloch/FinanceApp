CREATE TABLE dbo.TransactionSplit(
  ID            INT IDENTITY(1,1) PRIMARY KEY,
  TransactionId INT NOT NULL,
  CategoryId    INT NULL,
  Amount        DECIMAL(18,2) NOT NULL,
  Memo          NVARCHAR(400) NULL,
  CONSTRAINT FK_Split_Transaction FOREIGN KEY (TransactionId)
    REFERENCES dbo.[Transaction](Id) ON DELETE CASCADE,
  CONSTRAINT FK_Split_Category FOREIGN KEY (CategoryId)
    REFERENCES dbo.Category(Id)
);
