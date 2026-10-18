# Part 02 — answers

---

## Reports

- What was the problem?
   CsvReportExporter, JsonReportExporter, and TextReportExporter had thesame code.
   export, Load, Validate, and Save were copied in all 3 classes. Only Format was different.


- What did you change?
    i made an abstract class called ReportExporter. It has Export, Load,
    Validate, and Save, written only once and each exporter class now only has its own Format method.

- Why did you choose that approach?
    i used the Template Method pattern with an abstract class. the interface
    only gives method names and has no code inside. But I needed to share
   real code (Export, Load, Validate, Save) the abstract class can keep the shared code 


---

## Enrollment

- What was the problem?
  Program.cs made all 4 services (PaymentGateway,SeatInventory, InvoiceGenerator, EmailService) 
  and called them one by one in the right order.
  Anyone who wants to enroll a student must know all the steps and the order.

- What did you change?
   i made one class called EnrollmentService it creates the 4 services inside it. It has one method (Enroll)

- Why did you choose that approach?
   I used the Facade pattern. The caller doesn't need to know the 4 services or their order anymore 
   it only calls Enroll with the student, the course, and the amount.