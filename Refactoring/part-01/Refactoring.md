# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
    the code used a switch with the carrier names. when i want a new carrier,
    i must change this class.
                  
- What did you change?
    i made an interface called ICarrier. and now each carrier is its own class.
    the calculator gets the carriers and finds the right one by name.

---

## OrderProcessor

- What was the problem?
     the class made SqlOrderRepository and SmtpEmailSender by itself with new.
     So it was stuck with SQL and SMTP. i could not change them easily.

- What did you change?
     i made two interfaces: IOrderRepository and IEmailSender.
     now OrderProcessor gets them from outside in the constructor.
  

---

## Notifications

- What was the problem?
      there were too many classes that inherit from each other.
  for every new mix of channel, urgent, and scheduled, I made a new class.

- What did you change?
     i made one Notification class. it takes a channel, an urgent true/false,
  and an optional time. Email, SMS, and WhatsApp are small channel classes.

---

## Proof

- New carrier file(s):  src/BostaCarrier.cs
- New notification channel file(s): src/WhatsAppChannel.cs
- Existing classes left unchanged? (yes/no): yes
