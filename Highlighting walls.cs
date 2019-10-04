class IExternalcommand_elements : IExternalCommand
{
    public Result Execute(
        Autodesk.Revit.UI.ExternalCommandData commandData, ref string message,
        Autodesk.Revit.DB.ElementSet elements)
    {
        message = "Please note the highlighted Walls.";
        FilteredElementCollector collector = new FilteredElementCollector(commandData.Application.ActiveUIDocument.Document);
        ICollection<Element> collection = collector.OfClass(typeof(Wall)).ToElements();
        foreach (Element e in collection)
        {
            elements.Insert(e);
        }

        return Result.Failed;
    }
}