## Интерфейсы

### IShape

Интерфейс `IShape` определяет общие методы, которые будут использоваться для всех геометрических фигур.

### ICircle

Интерфейс `ICircle` наследует `IShape` и определяет метод `CalcArea()`, который используется для расчета площади круга.

### ITriangle

Интерфейс `ITriangle` также наследует `IShape` и определяет метод `CalcArea()`, который используется для расчета площади треугольника.

## Классы

### Shape

Класс `Shape` реализует интерфейс `IShape` и предоставляет общие методы, которые могут использоваться для всех геометрических фигур. 

### Circle

Класс `Circle` наследует `Shape` и реализует интерфейс `ICircle`. Он представляет круг и предоставляет метод `CalcArea()`, который рассчитывает площадь круга на основе его радиуса или диаметра.

### Triangle

Класс `Triangle` также наследует `Shape` и реализует интерфейс `ITriangle`. Он представляет треугольник и предоставляет метод `CalcArea()`, который рассчитывает площадь треугольника. Класс также содержит вспомогательные методы для определения, является ли треугольник прямоугольным и для расчета площади прямоугольного треугольника.

## Пример использования

```csharp
// Пример создания круга и расчета его площади
ICircle circle = new Circle(5.0);
double circleArea = circle.CalcArea();

// Пример создания треугольника и расчета его площади
ITriangle triangle = a Triangle(3.0, 4.0, 5.0);
double triangleArea = triangle.CalcArea();
```



----------------------------------------------------------------------
## Ответ на второе задание

Я вижу структуру таблиц так:

**Таблица `Categorys`**
```sql
TABLE Category
(
    Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(150)
)
```

**Таблица `Product`**
```sql
TABLE Product
(
    Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(150)
)
```

**Таблица `CategorysProducts`**
```sql
TABLE CategoryProduct
(
    IdCategory INT REFERENCES Categorys(Id),
    IdProducts INT REFERENCES Products(Id),
    CONSTRAINT CategoryProductPK PRIMARY KEY (categoryId, productId)
)
```

**Запрос**
```sql
SELECT
    c.Name AS [CategoryName],
    p.Name AS [ProductName]
FROM Category c
LEFT JOIN CategoryProduct cp ON cp.IdCategory = c.Id
LEFT JOIN Product p ON p.Id = cp.IdProduct
```
