SELECT Name AS ProductName, CategoryName
FROM Product LEFT JOIN (
	SELECT ProductId, Name AS CategoryName
	FROM Category JOIN ProductCategory
	ON Id = CategoryId
) AS temp
ON Id = ProductId