CREATE TABLE dbo.Category(
  ID        INT IDENTITY(1,1) PRIMARY KEY,
  GroupId   INT NOT NULL,
  CategoryName      NVARCHAR(100) NOT NULL,
  IsHidden  BIT NOT NULL CONSTRAINT DF_Category_IsHidden DEFAULT(0),
  SortOrder INT NOT NULL CONSTRAINT DF_Category_Sort DEFAULT(0),
  CONSTRAINT UQ_Category UNIQUE (GroupId, CategoryName),
  CONSTRAINT FK_Category_Group FOREIGN KEY (GroupId) REFERENCES dbo.CategoryGroup(Id)
);
