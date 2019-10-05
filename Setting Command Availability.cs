public class SampleAccessibilityCheck : IExternalCommandAvailability
{
    public bool IsCommandAvailable(AutodeskAutodesk.Revit.UI.UIApplication applicationData,
        CategorySet selectedCategories)
    {
        // Allow button click if there is no active selection
        if (selectedCategories.IsEmpty)
            return true;
        // Allow button click if there is at least one wall selected
        foreach (Category c in selectedCategories)
        {
            if (c.Id.IntegerValue == (int)BuiltInCategory.OST_Walls)
            return true;
        }
return false;
    }
}
