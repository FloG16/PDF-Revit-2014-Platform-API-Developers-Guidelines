// Create a Filter to get all the doors in the document
ElementClassFilter familyInstanceFilter = new ElementClassFilter(typeof(FamilyInstance));
ElementCategoryFilter doorsCategoryfilter =
new ElementCategoryFilter(BuiltInCategory.OST_Doors);
LogicalAndFilter doorInstancesFilter =
new LogicalAndFilter(familyInstanceFilter, doorsCategoryfilter);
FilteredElementCollector collector = new FilteredElementCollector(document);
ICollection<ElementId> doors = collector.WherePasses(doorInstancesFilter).ToElementIds();
String prompt = "The ids of the doors in the current document are:";
foreach(ElementId id in doors)
{
prompt += "\n\t" + id.IntegerValue;
}
// Give the user some information
TaskDialog.Show("Revit",prompt);