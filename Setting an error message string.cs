class IExternalCommand_message : IExternalCommand
{
    public Autodesk.Revit.UI.Result Execute(
        Autodesk.Revit.ExternalCommandData commandData, ref string message,
        Autodesk.Revit.ElementSet elements)
    {
        message = "Could not locate walls for analysis.";
        return Autodesk.Revit.UI.Result.Failed;
    }
}