# LeapTest

LeapTest project is the test automation project developed with c#, Selenium Web Driver and Specflow to test the LeapApp employee salary calculation application.

This consists with 2 featurs and each feature covering 2 tests.

 * Employee details feature is to test the presence of validation messages for the Name and Rate fields in the Employee data page. When user enters empty / wrong values to the fields the validation message displays and this test verify the presence of the validation messages.
 * Salary calculate feature will test the accuracy of calculated values. The 2 tests verify the total hours and calculated salary for 2 different inputs.

Tests are written in BDD fashion using Specflow, where as non technical users also can understand and contribute to the tests.
While implementing this framework, Page Object Pattern was used so that to maximize the maintanability and code reuse.

After successful test execution, user can see a summary report similar to given below. This was generated with the help of Extent report library. 

![alt text](https://github.com/dcar2018/LeapTest/blob/master/TestResults/ReportSample.JPG)

