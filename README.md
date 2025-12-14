# Quadratic_Equation_Solver
# Тоҷикӣ
## Муодилаи квадрати (Quadratic Equation Solver)
 Ин барнома дар забони C# навишта шудааст ва барои ҳалли муодилаҳои квадрати истифода мешавад. Муодила ба шакли умумӣ аст:
``` ax² + bx + c = 0 ```
 Барнома арзишҳои a, b, ва c -ро мегирад ва решаҳои муодиларо ҳисоб мекунад. Барнома метавонад се ҳолатро фаро гирад:
 1. Ду решаи воқеӣ (discriminant > 0)
 2. Як решаи воқеӣ (discriminant = 0)
 3. Муодила ҳали ҳақиқи надорад (discriminant < 0)
## Талабот (Requirements)
### Барои иҷро кардан, ба компютер бояд насб бошад:
1. .NET SDK
 https://dotnet.microsoft.com/download
Санҷед:
```
dotnet --version
```
2. Visual Studio Code
 https://code.visualstudio.com/
3. C# Extension (OmniSharp) дар VS Code
4. Маъмуран: C# Dev Kit ва NuGet Package Manager барои идора кардани пакетҳо
#### Чӣ гуна муҳитро омода кардан (Development Setup)
1. VS Code кушоед
2. Extension → Search → C# → Насб кунед
3. Лоиҳаро кушоед
4. Санҷед:
```
dotnet --version
```
Агар версия нишон дода шавад, ҳама омода аст.
 ### Чӣ гуна истифода бурдан
 1. Репозиторияро clone кунед:
```
https://github.com/azizbekjonsanginov0606-cmd/Quadratic_Equation_Solver.git  
 ```
 2. Ба папкаи репозитория гузаред:
```
cd Quadratic_Equation_Solver
```
 3. Барномаро бо dotnet run иҷро кунед:
 ```
 dotnet run
 ```
 4. Арзишҳои a, b, c-ро ворид кунед.
#### Мисолҳо (Examples)

##### Ду реша (D>0):
```
Enter a: 1
Enter b: -3
Enter c: 2
Result: Roots are x1 = 2, x2 = 1
```
##### Як реша (D=0):
```
Enter a: 1
Enter b: 2
Enter c: 1
Result: Roots are x1 = x2 = -1
```
##### Ҳеҷ решаи воқеӣ (D<0):
```
Enter a: 1
Enter b: 2
Enter c: 5
Result: No real roots (D < 0)
```
# Русский
##  Решение квадратного уравнения (Quadratic Equation Solver)
 Это приложение написано на C# и предназначено для решения квадратных уравнений. Общее уравнение имеет вид:
 ax² + bx + c = 0
 Программа принимает значения a, b и c и вычисляет корни уравнения. Программа учитывает три случая:
 1. Два действительных корня (discriminant > 0)
 2. Один действительный корень (discriminant = 0)
 3. Нет дествителых корней  (discriminant < 0)
## Требования (Requirements)
1. .NET SDK
 https://dotnet.microsoft.com/download
```
dotnet --version
```
2. Visual Studio Code
 https://code.visualstudio.com/
3. C# Extension (OmniSharp)
4. Дополнительно: C# Dev Kit и NuGet Package Manager
#### Настройка среды (Development Setup)
1. Откройте VS Code
2. Extensions → Search → C# → Установите
3. Откройте проект
4. Проверьте:
```
dotnet --version
```
### Как использовать
 1. Клонируйте репозиторий:
```
https://github.com/azizbekjonsanginov0606-cmd/Quadratic_Equation_Solver.git  
 ```
 2. Перейдите в папку с проектом:
 ```
 cd Quadratic_Equation_Solver
```
 3. Запустите программу с помощью dotnet run:
 ```
 dotnet run
 ```
 4. Введите значения a, b, c.
#### Примеры (Examples)

##### Два корня (D>0):
```
Enter a: 1
Enter b: -3
Enter c: 2
Result: Roots are x1 = 2, x2 = 1
```
##### Один корень (D=0):
```
Enter a: 1
Enter b: 2
Enter c: 1
Result: Roots are x1 = x2 = -1
```
##### Нет действительных корней (D<0):
```
Enter a: 1
Enter b: 2
Enter c: 5
Result: No real roots (D < 0)
```
 # English
 ## Quadratic Equation Solver
 This application is written in C# and is used to solve quadratic equations. The general form of the equation is:
```
 ax² + bx + c = 0 
 ```
 The program takes a, b, and c as input and calculates the roots of the equation. It handles three cases:
 1. Two real roots (discriminant > 0)
 2. One real root (discriminant = 0)
 3. No real roots (discriminant < 0)
## Requirements
1. .NET SDK
 https://dotnet.microsoft.com/download
```
dotnet --version
```
2. Visual Studio Code
 https://code.visualstudio.com/
3. C# Extension (OmniSharp)
4. Optionally: C# Dev Kit and NuGet Package Manager
#### Development Setup
1. Open VS Code
2. Extensions → Search → C# → Install
3. Open the project
4. Verify:
```
dotnet --version
```
 ### How to Use
 1. Clone the repository:
```
https://github.com/azizbekjonsanginov0606-cmd/Quadratic_Equation_Solver.git  
 ```
 2. Go to the project folder:
 ```
cd Quadratic_Equation_Solver
```
 3. Run the program using dotnet run:
 ```
 dotnet run
 ```
 4. Enter the values for a, b, and c.
#### Examples

##### Two real roots (D>0):
```
Enter a: 1
Enter b: -3
Enter c: 2
Result: Roots are x1 = 2, x2 = 1
```
##### One real root (D=0):
```
Enter a: 1
Enter b: 2
Enter c: 1
Result: Roots are x1 = x2 = -1
```
##### No real roots (D<0):
```
Enter a: 1
Enter b: 2
Enter c: 5
Result: No real roots (D < 0)
```
 