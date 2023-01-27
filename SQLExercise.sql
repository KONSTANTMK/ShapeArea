CREATE TABLE Goods(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(255) NOT NULL);

CREATE TABLE Categories(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(255) NOT NULL);

CREATE TABLE GoodCat(
good_id INT NOT NULL,
cat_id INT,
FOREIGN KEY(good_id) REFERENCES Goods(id) ON DELETE CASCADE,
FOREIGN KEY(cat_id) REFERENCES Categories(id) ON DELETE CASCADE);

CREATE UNIQUE INDEX prod_cat ON GoodCat(good_id, cat_id);

INSERT INTO Goods VALUES('Балалайка'), ('Гитара'), ('Лютня'),('Скрипка'),('Барабан'),('Флейта'),('Струны для флейты'),('Струны для гитары'),('Медиатор');
INSERT INTO Categories VALUES('Духовые инструменты'), ('Акустические инструменты'),('Аксессуары');
INSERT INTO GoodCat VALUES(8, NULL), (6, 2), (9, 3), (5, 2), (5, 3), (4, 1),(3, 2), (2, 1), (1, 1);

SELECT p.name AS good,
c.name AS cat FROM Goods AS p
INNER JOIN GoodCat AS pc ON p.id = pc.good_id
LEFT JOIN Categories AS c ON c.id = pc.cat_id 