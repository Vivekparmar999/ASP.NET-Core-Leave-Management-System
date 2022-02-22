For Adding Controller
1 controller folder right click add controller-->MVC Controller with views,using ef
2 Model class->leaveType,
3 Data  ->ApplicationDbCOntext
4 Views     GenerateViews-✔
            Reference Script Library-❌
            Use a layout Page-✔


Adding Custom ClientSide Library
1 project rightclick add clientSideLibrary
2 library add  name (eg SweetAlert) & install


Identity
scaffold at project level and click require views & select db context.
It will also create _LoginPartial in sharedFolder

To Pass data from controller to view use 
1)ViewBag
2)Return model in controller eg return View(model);