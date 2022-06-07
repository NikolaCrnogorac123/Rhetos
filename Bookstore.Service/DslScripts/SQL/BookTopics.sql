SELECT
    b.ID,
    NumberOfTopics = COUNT(t.ID)
FROM
    Bookstore.Book b
    LEFT JOIN Bookstore.Topic t ON t.ID = b.ID
GROUP BY
    b.ID