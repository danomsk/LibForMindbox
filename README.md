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
  Id INT PRIMORY KEY IDENTITY,  
  Name varchar(150)  
 )**  
 
 **TABLE Products  
 (  
  Id INT PRIMORY KEY IDENTITY,  
  Name varchar(150)  
 )**  

 **TABLE CategorysProducts    
 (   
  IdCategory INT REFERENCES Categorys(Id),
  IdProducts INT REFERENCES Products(Id),
  CONSTRAINS CategoryProductPK PRYMARY KEY(categoryId, productId)   
 )**
 
 Запрос:  

**SELECT  
c.Name [CategoryName],  
p.Name [ProductName]  
FROM Category c  
LEFT JOIN CategoryProduct cp ON cp.IdCategory = c.Id  
LEFT JOIN Product p ON p.Id = cp.IdProduct**
