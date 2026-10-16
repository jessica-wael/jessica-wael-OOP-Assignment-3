## Task Generics — One Store for Every Type:

step 2:
 what is the same between the Student store and Course store?? 
      
      the same is both stores keep their items in a List , and both stores the same 4 methods (Add, GetById, GetAll, and Remove)
 
  what is the different?

      the difference between two stores is the types they store are different: StudentStore stores Student,
      and CourseStore stores Course. And the properties are different: Student has Name, while Course has Title and Price.


step 3:
 GetById will not compile!!
 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of 
   type 'T' could be found (are you missing a using directive or an assembly reference?)

        T can be any type , so T can be Student , Course , string or int .
        So the compiler sees that (item.Id) might not work for some types, so it stops us before the program runs.