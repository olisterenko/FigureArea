# Задание №3

Всего три таблицы: **Products** (ID и Name), **Categories** (ID и Name) и **Entries** (ProductID и CategoryID) — общая таблица. Получается немного не однозначно. Если общая таблица нужна только для сопоставления продуктов с категориями, то нужно выводить все. Если же это таблица чего-то имеющегося, допустим, на складе, то, конечно, первый Left join некорректен. Эта версия запроса именно про первый случай. Он будет вытаскивать из таблицы Продуктов имена, даже если ID этих продуктов нет в общей таблице.

```
SELECT Products.Name, Categories.Name FROM products
LEFT OUTER JOIN Entries ON (Products.ID = Entries.ProductID)
LEFT OUTER JOIN Categories ON (Entries.CategoryID = Categories.ID);
```
