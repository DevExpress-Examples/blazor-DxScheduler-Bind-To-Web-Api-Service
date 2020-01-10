<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/SchedulerCRUD/SchedulerCRUD/Pages/Index.razor)
* [Model.cs](./CS/SchedulerCRUD/SchedulerCRUD/Data/Model.cs)
* [MedicsController.cs](./CS/DataSourceWebApi/DataSourceWebApi/Controllers/MedicsController.cs)
* [MedicalAppointmentsController.cs](./CS/DataSourceWebApi/DataSourceWebApi/Controllers/MedicalAppointmentsController.cs)
* [MedicsSchedulingContext.cs](./CS/MyTestWebService/MyTestWebService/Models/MedicsSchedulingContext.cs)
* [script.sql](./DataSourceWebApi/DataSourceWebApi/DataBase/script.sql)
<!-- default file list end -->

### Scheduler for Blazor - How to implement CRUD operations with a Web API Service 

This example contains two projects:

1. **DataSourceWebApi project**
This .NET Core project implements a Web API service with a connection to the **MedicsScheduling** database. The [DataBase folder](./DataSourceWebApi/DataSourceWebApi/DataBase) contains a script file that generates this database.

2. **SchedulerCRUD project**
This Blazor project illustrates how to use the [AppointmentInserting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerBase.AppointmentInserting), [AppointmentInserted](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerBase.AppointmentInserted), [AppointmentUpdated](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerBase.AppointmentUpdated), and [AppointmentRemoved](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerBase.AppointmentRemoved) events to implement CRUD operations in the [DxScheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler). The *XXX-ing* events fire before the [DxSchedulerDataStorage.AppointmentsSource](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDataStorage.AppointmentsSource) object is changed and allow you to cancel changes. The *XXX-ed* events fire after the *AppointmentsSource* object was changed. You can use this object to update an assigned data source.


