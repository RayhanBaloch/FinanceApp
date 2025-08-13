CREATE TABLE dbo.Reconciliation(
  ID                INT IDENTITY(1,1) PRIMARY KEY,
  AccountId         INT NOT NULL,
  AsOf              DATE NOT NULL,
  StatementBalance  DECIMAL(18,2) NOT NULL,
  BalanceDifference        DECIMAL(18,2) NOT NULL CONSTRAINT DF_Recon_Diff DEFAULT(0),
  CONSTRAINT FK_Recon_Account FOREIGN KEY (AccountId) REFERENCES dbo.Account(ID)
);
