SELECT 
    p.Name AS 'Имя продукта',
    c.Name AS 'Имя категории'
FROM 
    Products p
LEFT JOIN
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID;
