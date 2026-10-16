# Collections & Extension Methods  Task 2.1 — Research: IReadOnlyDictionary & SortedDictionary

### IReadOnlyDictionary<TKey, TValue>

What is IReadOnlyDictionary<TKey, TValue> ??

       it's an interface in "System.Collections.Generics" that represent a readonly dictionary.
       you can read key/value pairs ,but you can't add, remove or change any of them 

What is the difference between IReadOnlyDictionary and Dictionary ??

    Dictionary ia a class , you can read ,add, remove or change inside it and modify key/value pairs.
    Dictionary implements IReadOnlyDictionary, so any Dictionary can treated as an IReadOnlyDictionary.

Why a public method return one of them?

    because the callers can only read the data and can't add , remove ,or change entries. 
    this protects the class's internal data from being changed from outside.


### SortedDictionary<TKey, TValue>

What is SortedDictionary<TKey, TValue>??

    it's a collection stores key/value pairs and always keeps them stored by key .


What is the difference between SortedDictionary and Dictionary in ordering??
   
    in Dictionary the items come out in no fixed oredr , but in SortedDictionary the items always come out stored by key.
      

What is the difference between SortedDictionary and Dictionary in speed??
     
     the Dictionary is faster for finding item because it uses a hash table O(1) on average, but SortedDictionary is a bit slower,
       bacause it uses a tree so the same operation takes O(log n) and also using more memory 

When would you choose SortedDictionary?
    
    When we need to keep keys sorted automatically
    When we want to iterate through elements in sorted order
    When the order of keys is important

// Dictionary : سريع بس مش مرتب 
// SortedDictionary:مرتب بس ابطأ شويه    

---

## Task 2.2 — Pick the Collection
List, Dictionary, HashSet,
IEnumerable, IReadOnlyDictionary, SortedDictionary.


 S1: Find a student by national ID — thousands of times a day 
    = Dictionary : finds an item by it's key very fast, so it is good for searching by national ID many times a day.

 S2: Keep the tags of a course. The same tag must never be stored twice 
    = HashSet : does not allow duplicates, so the same tag can never be stored twice

 S3: Keep a student's grades in the order they were entered. The same grade can appear more than once 
    = List : keeps the items in the order they were added and allows the same value more than once

 S4: A public method returns the course price list. Callers can read prices but must not add or change any 
    = IReadOnlyDictionary : lets callers read the prices but not add or change them

 S5: A timetable keyed by session start time. Sessions are added at any moment, and it must always print in time order 
    = SortedDictionary : always stays sorted by key, so the timetable is always in time order, even when new sessions are added

 S6: A method returns results that the caller only loops over once — and may stop early 
    = IEnumerable : is made for looping over the results once, and the caller can stop early