<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/233070445/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T848437)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

### Scheduler for Blazor - How to implement CRUD operations with a Web API Service 

This example demonstrates how to implement CRUD operations in Blazor Scheduler. The example contains two projects:

* **DataSourceWebApi project**

    This .NET Core project implements a Web API service with a connection to the **MedicsScheduling** database. The [DataBase folder](./CS/DataSourceWebApi/DataSourceWebApi/DataBase/) contains a script file that generates this database.

* **SchedulerCRUD project**

    This Blazor project illustrates how to use [AppointmentInserting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentInserting), [AppointmentUpdating](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxScheduler.AppointmentUpdating), and [AppointmentRemoving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxScheduler.AppointmentRemoving) events to implement CRUD operations in the [DxScheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler). These events fire after the *AppointmentsSource* object is changed. You can use this object to update an assigned data source.


## Files to Review

* [Index.razor](./CS/SchedulerCRUD/SchedulerCRUD/Pages/Index.razor)
* [Model.cs](./CS/SchedulerCRUD/SchedulerCRUD/Data/Model.cs)
* [MedicsController.cs](./CS/DataSourceWebApi/DataSourceWebApi/Controllers/MedicsController.cs)
* [MedicalAppointmentsController.cs](./CS/DataSourceWebApi/DataSourceWebApi/Controllers/MedicalAppointmentsController.cs)
* [MedicsSchedulingContext.cs](./CS/DataSourceWebApi/DataSourceWebApi/Models/MedicsSchedulingContext.cs)
* [script.sql](./CS/DataSourceWebApi/DataSourceWebApi/DataBase/script.sql)

## Documentation

- [Manage Appointments in Code](https://docs.devexpress.com/Blazor/404770/components/scheduler/appointments#manage-appointments-in-code)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxScheduler-Bind-To-Web-Api-Service&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxScheduler-Bind-To-Web-Api-Service&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
