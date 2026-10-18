# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n*m)
- Time (ms) before:  13 ms
- What did you change?
    i put the blocked ids in HashSet. The HashSet finds an item fast and i don't search the whole list for every request.
- Time complexity after: O(n+m)
- Time (ms) after: about 0 to 2 ms

---

## Students

- What was the problem?
   GetAllStudents make one million student in alist but program.cs used only 3
- What did you change?
    i used yield return, so now a student is make only when the loop asks for it.

