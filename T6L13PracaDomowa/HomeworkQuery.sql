SELECT TOP (1000)[Number]
      ,cli.FirstName
	  ,cli.LastName
  FROM [Invoices] inv
  Left join Clients cli on cli.Id = inv.ClientNumber

  SELECT TOP (1000) inv.Number
      ,pro.Name
      ,pro.Price
  FROM [Enterprise].[dbo].[InvoicePositions] invpos
  Left join Products pro on pro.Id = invpos.ProductId
  Left join Invoices inv on inv.Id = invpos.InvoiceId
  order by inv.Number

SELECT TOP (1000) inv.Number
      ,SUM(Quantity) as [ilość wszystkich produktów]
  FROM [Enterprise].[dbo].[InvoicePositions] invpos
      Left join Invoices inv on inv.Id = invpos.InvoiceId
  group by inv.Number

SELECT TOP (1000) inv.Number
      ,SUM(pro.Price*invpos.Quantity) as [Łączna kwota]
  FROM [Enterprise].[dbo].[InvoicePositions] invpos
  Left join Products pro on pro.Id = invpos.ProductId
  Left join Invoices inv on inv.Id = invpos.InvoiceId
  group by inv.Number