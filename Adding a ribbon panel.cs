using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.Windows.Media.Imaging;
class CsAddpanel : Autodesk.Revit.UI.IExternalApplication
{
public Autodesk.Revit.UI.Result OnStartup(UIControlledApplication application)
{
// add new ribbon panel
RibbonPanel ribbonPanel = application.CreateRibbonPanel("NewRibbonPanel");
//Create a push button in the ribbon panel "NewRibbonPanel"
//the add-in application "HelloWorld" will be triggered when button is pushed
PushButton pushButton = ribbonPanel.AddItem(new PushButtonData("HelloWorld",
"HelloWorld", @"D:\HelloWorld.dll", "HelloWorld.CsHelloWorld")) as PushButton;
// Set the large image shown on button
Uri uriImage = new Uri(@"D:\Sample\HelloWorld\bin\Debug\39-Globe_32x32.png");
BitmapImage largeImage = new BitmapImage(uriImage);
pushButton.LargeImage = largeImage;
return Result.Succeeded;
}
public Result OnShutdown(UIControlledApplication application)
{
return Result.Succeeded;
}
}