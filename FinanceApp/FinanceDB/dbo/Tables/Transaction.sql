CREATE TABLE dbo.[Transaction](
  ID                 INT IDENTITY(1,1) PRIMARY KEY,
  AccountId          INT NOT NULL,
  [TransactionDate]  DATE NOT NULL,
  PayeeId            INT NULL,
  CategoryId         INT NULL,                     -- NULL for transfers; NULL if using split lines
  Amount             DECIMAL(18,2) NOT NULL,       -- total of splits when split is used
  Memo               NVARCHAR(400) NULL,
  Reconciled         BIT NOT NULL CONSTRAINT DF_Txn_Reconciled DEFAULT(0),
  TransferAccountId  INT NULL,
  CONSTRAINT FK_Txn_Account          FOREIGN KEY (AccountId)         REFERENCES dbo.Account(Id),
  CONSTRAINT FK_Txn_Category         FOREIGN KEY (CategoryId)        REFERENCES dbo.Category(Id),
  CONSTRAINT FK_Txn_Payee            FOREIGN KEY (PayeeId)           REFERENCES dbo.Payee(Id),
  CONSTRAINT FK_Txn_TransferAccount  FOREIGN KEY (TransferAccountId) REFERENCES dbo.Account(Id)
);
