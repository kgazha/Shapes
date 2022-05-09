SELECT "Products"."Name" as "ProductName", "Categories"."Name" as "CategoryName"
FROM "Products"
LEFT JOIN "ProductCategories" ON
"Products"."Id" = "ProductCategories"."ProductId"
LEFT JOIN "Categories" ON
"ProductCategories"."CategoryId" = "Categories"."Id"