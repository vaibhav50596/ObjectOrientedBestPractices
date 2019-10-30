# Problem Statement:

At NoForRealz pizza chain we have a custom order management program to run day to day sales operation. Our business model is very simple: We sell only one type of pizza with different toppings that all cost the same. This makes price calculation very straightforward limiting the variables to the number of toppings and the amount of tax based on province. Our chain currently operates in Alberta and Ontario. We have the following requirements and ask you to change the code to meet these needs.

# Requirements:
- The chain will start operating in BC and therefore support for tax calculation in BC needs to be added
- The National GST tax will jump to 6% starting Nov 11th 2018. We want to update the code now to use the new GST rate for orders entered after that day and prevent a downtime during the long weekend.

All the code related to these requirements is in one class called Pizza. We know that the code can use some improvement. We grew very fast from a start-up company and have built a lot of technical debt in our codebase over the years. You have time to address some of this debt. Feel free to look for “code smells” and refactor the code to improve quality by applying best practices like SOLID and DRY. After the changes we expect the code to behave exactly as before for old functionality and to support the new requirements.

# Object Oriented Best Practices Description:
This project demonstrates object oriented language's SOLID and DRY principles in C# using .NET Core application.
The application makes use of Factory Design Pattern to create objects of different types (for eg. Objects of different province tax classes - AlbertaTaxCalculator and OntarioTaxCalculator) and Dependency Inversion (D) from SOLID principles to inject dependency of ITaxCalculator in Pizza class. 

# Solution to requirements:
1. Here, when our chain starts operating in BC and it requires tax calculation then we can simply create a class for tax calculation in BC that implements ITaxCalculator interface and we can override GetTotalAfterTax() method that will return price of pizza with tax + national tax.

2. We are adding national gst tax to every province tax calculator files (AlbertaTaxCalculator and OntarioTaxCalculator). so whenever national gst tax changes (jumps to 6%) then we will have to change every province tax calculator file. Instead of that, we can create one generic class "NationalTaxCalculator" which will contain NationalTax value and that class can be used in province tax calculator files. This way we can solve problem by changing only one file.
