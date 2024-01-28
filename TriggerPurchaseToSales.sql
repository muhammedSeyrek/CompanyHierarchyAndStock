CREATE TRIGGER trgUpdateSalesPrice
ON Price
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Eklenen kayıtları seç
    DECLARE @InsertedPrices TABLE (PriceId INT, PurchasePrice MONEY, SalesPrice MONEY);
    INSERT INTO @InsertedPrices (PriceId, PurchasePrice, SalesPrice)
    SELECT PriceId, PurchasePrice, SalesPrice
    FROM INSERTED;

    -- SalesPrice'ları güncelle
    UPDATE p
    SET SalesPrice = i.PurchasePrice * 1.15
    FROM Price p
    INNER JOIN @InsertedPrices i ON p.PriceId = i.PriceId;
END;