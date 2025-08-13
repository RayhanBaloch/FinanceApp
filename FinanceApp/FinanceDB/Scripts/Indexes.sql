CREATE INDEX IX_Txn_TransactionDate ON dbo.[Transaction]([TransactionDate]);
CREATE INDEX IX_Txn_Account         ON dbo.[Transaction](AccountId);
CREATE INDEX IX_Txn_Category        ON dbo.[Transaction](CategoryId);

CREATE INDEX IX_Split_Txn           ON dbo.TransactionSplit(TransactionId);
CREATE INDEX IX_Split_Category      ON dbo.TransactionSplit(CategoryId);

CREATE INDEX IX_BudgetMove_Month    ON dbo.BudgetMove(BudgetMonthId);
CREATE INDEX IX_BudgetMove_From     ON dbo.BudgetMove(FromCategoryId) WHERE FromCategoryId IS NOT NULL;
CREATE INDEX IX_BudgetMove_To       ON dbo.BudgetMove(ToCategoryId)   WHERE ToCategoryId   IS NOT NULL;
