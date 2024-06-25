<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/233070445/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T848437)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/SchedulerCRUD/SchedulerCRUD/Pages/Index.razor)
* [Model.cs](./CS/SchedulerCRUD/SchedulerCRUD/Data/Model.cs)
* [MedicsController.cs](./CS/DataSourceWebApi/DataSourceWebApi/Controllers/MedicsController.cs)
* [MedicalAppointmentsController.cs](./CS/DataSourceWebApi/DataSourceWebApi/Controllers/MedicalAppointmentsController.cs)
* [MedicsSchedulingContext.cs](./CS/DataSourceWebApi/DataSourceWebApi/Models/MedicsSchedulingContext.cs)
* [script.sql](./CS/DataSourceWebApi/DataSourceWebApi/DataBase/script.sql)
<!-- default file list end -->

### Scheduler for Blazor - How to implement CRUD operations with a Web API Service 

This example contains two projects:

1. **DataSourceWebApi project**
This .NET Core project implements a Web API service with a connection to the **MedicsScheduling** database. The [DataBase folder](./CS/DataSourceWebApi/DataSourceWebApi/DataBase/) contains a script file that generates this database.

2. **SchedulerCRUD project**
This Blazor project illustrates how to use the [AppointmentInserting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentInserting), [AppointmentInserted](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentInserted), [AppointmentUpdated](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxScheduler.AppointmentUpdated), and [AppointmentRemoved](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxScheduler.AppointmentRemoved) events to implement CRUD operations in the [DxScheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler). The *XXX-ing* events fire before the [DxSchedulerDataStorage.AppointmentsSource](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDataStorage.AppointmentsSource) object is changed and allow you to cancel changes. The *XXX-ed* events fire after the *AppointmentsSource* object was changed. You can use this object to update an assigned data source.


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxScheduler-Bind-To-Web-Api-Service&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxScheduler-Bind-To-Web-Api-Service&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
