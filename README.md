Библиотека имеет два класса Circle и Triangle, которые наследуются от интерфейса IShape.

## IShape
Реализован метод **CalcArea** для вычисления площади.

## Circle
Переопределяет метод **CalcArea** для вычисления площади круга по радиусу. В случае передачи в конструктор отрицательного радиуса выбрасывает исключение.

## Triangle
Переопределяет метод **CalcArea** для вычисления площади треугольника по трем сторонам. Если треугольник невозможно создать из этих сторон, выбрасывается исключение.
В случае, если треугольник прямоугольный, площадь расчитывается по формуле : 

![](https://sun9-25.userapi.com/impg/LsfOJBFzlLnhVrQP7f22ZIpeitsTQNPDkjV5-A/S3ZwWsbXB5c.jpg?size=456x237&quality=96&sign=d56e06c7c2b92e5510273b742657590e&type=album)

Где a и b - катеты прямоугольника.


----------------------------------------------------------------------
# Ответ на второе задание

 Я вижу структуру таблиц так
 
 **TABLE Categorys  
 (  
  Id INT PRIMORY KEY IDNTITY,  
  Name NVARCHAR(max)  
 )**  
 
 **TABLE Products  
 (  
  Id INT PRIMORY KEY IDENTITY,  
  Name NVarchar,  
  Id_Category INT REFERENCES Categorys (Id)  
 )**  
 
 Запрос:
 
 ` SELECT Products.Name Categorys.Name FROM Products
 LEFT JOIN Categorys ON Categorys.Id = Products.Id `
 
