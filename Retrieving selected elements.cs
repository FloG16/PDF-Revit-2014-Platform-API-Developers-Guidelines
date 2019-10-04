[Autodesk.Revit.Attributes.Transaction(TransactionMode.ReadOnly)]
public class Document_Selection : IExternalCommand
{
public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData,
ref string message, ElementSet elements)
{
try
{
// Select some elements in Revit before invoking this command
// Get the handle of current document.
UIDocument uidoc = commandData.Application.ActiveUIDocument;
// Get the element selection of current document.
Selection selection = uidoc.Selection;
ElementSet collection = selection.Elements;
if (0 == collection.Size)
{
// If no elements selected.
TaskDialog.Show("Revit","You haven't selected any elements.");
}
else
{
String info = "Ids of selected elements in the document are: ";
foreach (Element elem in collection)
{
info += "\n\t" + elem.Id.IntegerValue;
}
TaskDialog.Show("Revit",info);
}
}
catch (Exception e)
{
message = e.Message;
return Autodesk.Revit.UI.Result.Failed;
}
return Autodesk.Revit.UI.Result.Succeeded;
}
}