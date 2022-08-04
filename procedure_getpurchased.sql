CREATE PROCEDURE GetTopPurchasedMovies
@fromDate datetime,
@toDate datetime,
@pageSize int,
@pageIndex int
as
BEGIN
	DECLARE @MaxTablePages float;
	SELECT @MaxTablePages=count(*) FROM dbo.Movies;
	SET @MaxTablePages=Ceiling(@maxTablePages/@pageSize);
	SELECT m.Title, count(p.MovieId) as [NumberPurchased]
	FROM Movies m LEFT JOIN Purchases p ON m.Id=p.MovieId
	WHERE p.PurchaseDateTime > @fromDate AND p.PurchaseDateTime < @toDate
	GROUP BY p.MovieId
	ORDER BY count(p.MovieId)
END;


