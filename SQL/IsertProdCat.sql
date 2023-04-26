use m9_webshop;

select ProductId, CategoryId from Products p, Categories c where p.Title = "Apple" AND c.Title = "Pome fruit" 
OR p.Title = "Banana" AND c.Title = "Berry fruit"
OR p.Title = "Carrot" AND c.Title = "Root vegetable"
OR p.Title = "Blueberries" AND c.Title = "Berry fruit"
OR p.Title = "Kale" AND c.Title = "Leafy green vegetable"
OR p.Title = "Orange" AND c.Title = "Citrus fruit"
OR p.Title = "Spinach" AND c.Title = "Leafy green vegetable"
OR p.Title = "Watermelon" AND c.Title = "Pepo fruit"
OR p.Title = "Strawberries" AND c.Title = "Berry fruit"
OR p.Title = "Broccoli" AND c.Title = "Brassica vegetable"
OR p.Title = "Cucumber" AND c.Title = "Fruit vegetable"
OR p.Title = "Avocado" AND c.Title = "Berry fruit"
OR p.Title = "Pineapple" AND c.Title = "Tropical fruit"
OR p.Title = "Tomato" AND c.Title = "Fruit vegetable"
OR p.Title = "Mango" AND c.Title = "Stone fruit"
OR p.Title = "Potato" AND c.Title = "Tubers"
OR p.Title = "Grapes" AND c.Title = "Berry fruit"
OR p.Title = "Zucchini" AND c.Title = "Fruit vegetable"
OR p.Title = "Cantaloupe" AND c.Title = "Pepo fruit"
OR p.Title = "Peppers" AND c.Title = "Fruit vegetable"
OR p.Title = "Cauliflower" AND c.Title = "Brassica vegetable"
OR p.Title = "Lemon" AND c.Title = "Citrus fruit"
OR p.Title = "Cherry" AND c.Title = "Stone fruit"
OR p.Title = "Onion" AND c.Title = "Bulb vegetable"
OR p.Title = "Eggplant" AND c.Title = "Fruit vegetable"
OR p.Title = "Peas" AND c.Title = "Legumes"
OR p.Title = "Corn" AND c.Title = "Grain"
OR p.Title = "Asparagus" AND c.Title = "Shoot vegetable"
OR p.Title = "Artichoke" AND c.Title = "Flower bud vegetable"
OR p.Title = "Green beans" AND c.Title = "Legumes"
OR p.Title = "Squash" AND c.Title = "Fruit vegetable"
OR p.Title = "Pumpkin" AND c.Title = "Fruit vegetable"
OR p.Title = "Radish" AND c.Title = "Root vegetable";



INSERT INTO m9_webshop.dbo.ProductCategories ( ProductId, CategoryId) VALUES
(1,24),
(2,25),
(3,30),
(4,25),
(5,34),
(6,26),
(7,34),
(8,28),
(9,25),
(10,31),
(11,32),
(12,25),
(13,27),
(14,32),
(15,29),
(16,33),
(17,25),
(18,32),
(20,32),
(21,31),
(22,26),
(23,29),
(24,35),
(25,32),
(26,36),
(27,37),
(28,38),
(29,39),
(30,36),
(31,32),
(32,32),
(33,30)
;

select ProductId, CategoryId from Products p, Categories c where p.Title = 'Banana' AND c.Title = 'Berry fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Carrot' AND c.Title = 'Root vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Blueberries' AND c.Title = 'Berry fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Kale' AND c.Title = 'Leafy green vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Orange' AND c.Title = 'Citrus fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Spinach' AND c.Title = 'Leafy green vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Watermelon' AND c.Title = 'Pepo fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Strawberries' AND c.Title = 'Berry fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Broccoli' AND c.Title = 'Brassica vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Cucumber' AND c.Title = 'Fruit vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Avocado' AND c.Title = 'Berry fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Pineapple' AND c.Title = 'Tropical fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Tomato' AND c.Title = 'Fruit vegetable'
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Mango' AND c.Title = 'Stone fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Potato' AND c.Title = 'Tubers';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Grapes' AND c.Title = 'Berry fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Zucchini' AND c.Title = 'Fruit vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Cantaloupe' AND c.Title = 'Pepo fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Peppers' AND c.Title = 'Fruit vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Cauliflower' AND c.Title = 'Brassica vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Lemon' AND c.Title = 'Citrus fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Cherry' AND c.Title = 'Stone fruit';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Onion' AND c.Title = 'Bulb vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Eggplant' AND c.Title = 'Fruit vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Peas' AND c.Title = 'Legumes';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Corn' AND c.Title = 'Grain';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Asparagus' AND c.Title = 'Shoot vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Artichoke' AND c.Title = 'Flower bud vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Green beans' AND c.Title = 'Legumes';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Squash' AND c.Title = 'Fruit vegetable'
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Pumpkin' AND c.Title = 'Fruit vegetable';
select ProductId, CategoryId from Products p, Categories c where p.Title = 'Radish' AND c.Title = 'Root vegetable';