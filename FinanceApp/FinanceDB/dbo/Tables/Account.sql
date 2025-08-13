CREATE TABLE dbo.Account(
  ID             INT IDENTITY(1,1) PRIMARY KEY,
  AccountName           NVARCHAR(100) NOT NULL UNIQUE,
  AccountType           TINYINT NOT NULL,                  -- 0 Cash, 1 Bank, 2 CreditCard, 3 Savings, 4 Investment, 5 Other
  IsOnBudget     BIT NOT NULL CONSTRAINT DF_Account_IsOnBudget DEFAULT(1),
  OpeningBalance DECIMAL(18,2) NOT NULL CONSTRAINT DF_Account_Opening DEFAULT(0)
);