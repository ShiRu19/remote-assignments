/* 1. Write an SQL statement to select all articles with their author¡¦s email. */
SELECT DISTINCT Article.Author, Users.Email
FROM Article
INNER JOIN Users
ON Article.AuthorID = Users.Id;

/* 2. Write another SQL statement to select articles from 7th to 12th sorted by id. */
SELECT t.[rank], Article.Id, Article.AuthorID, Article.Title, Article.Content AS Article
FROM Article
	INNER JOIN (
		SELECT ROW_NUMBER() OVER (ORDER BY ID) AS [rank], id
		FROM Article) AS t
	ON t.Id = Article.Id
WHERE t.[rank] between 7 and 12
ORDER BY (Article.Id)