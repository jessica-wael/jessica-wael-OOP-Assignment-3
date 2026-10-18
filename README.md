OOP Assignment 3:

👩‍💻 Student Information

Student Name: Jessica Wael Khalaf
Cohort: Groub 3 
Assignment: Refactoring, Collections & Generics

📌 Project Overview

This assignment is a set of C# projects about refactoring, collections, and generics.

Refactoring Lab: three console projects that worked but were badly designed. I fixed them with OCP, DIP, composition, Template Method, and Facade. I also made CountBlocked faster with a HashSet, and used yield return in StudentCatalog.
Collections: research answers about collection types, a table that picks the right collection for each case, and Egyptian phone and national ID checks with Regex extension methods.
Generics: a Store<T> built step by step, with IHasId, a generic constraint, and extension methods (Page, FindById, ToIdDictionary).
LinkedIn: links to my 4 posts.

📂 Project Structure
README.md
Refactoring/
  part-01/   Task 1.1 + Refactoring.md
  part-02/   Tasks 1.2, 1.3 + Answers.md
  part-03/   Task 1.4 + Answers.md
Collections/
  Answers.md
  src/
    StringValidationExtensions.cs
    Program.cs
Generics/
  Answers.md
  src/
LinkedIn/
  linked.md


▶️ How to Run
Clone the repository.
Open the folder in Visual Studio.
Build the project.
Run the project you want to check:
Refactoring: Refactoring/part-01, part-02, or part-03
Collections: Collections/src
Generics: Generics/src
Or run it from the terminal inside the project folder:
bash
dotnet run

📝 Notes
Needs the .NET SDK (.NET 8 or newer).
Task 1.2 asks for an abstract class, so ReportExporter is abstract.
Run times can change a little between runs. The numbers in the answers files are from my machine.
