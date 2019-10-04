public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData,
2. ref string message, ElementSet elements)
3. {
4. try
5. {
6. Document doc = commandData.Application.ActiveUIDocument.Document;
7. UIDocument uidoc = commandData.Application.ActiveUIDocument;
8. // Delete selected elements
9. ICollection<Autodesk.Revit.DB.ElementId> ids =
10. doc.Delete(uidoc.Selection.GetElementIds());
11.
12. TaskDialog taskDialog = new TaskDialog("Revit");
13. taskDialog.MainContent =
14. ("Click Yes to return Succeeded. Selected members will be deleted.\n" +
15. "Click No to return Failed. Selected members will not be deleted.\n" +
16. "Click Cancel to return Cancelled. Selected members will not be deleted.");
17. TaskDialogCommonButtons buttons = TaskDialogCommonButtons.Yes |
18. TaskDialogCommonButtons.No | TaskDialogCommonButtons.Cancel;
19. taskDialog.CommonButtons = buttons;
20. TaskDialogResult taskDialogResult = taskDialog.Show();
21.
22. if (taskDialogResult == TaskDialogResult.Yes)
23. {
24. return Autodesk.Revit.UI.Result.Succeeded;
25. }
26. else if (taskDialogResult == TaskDialogResult.No)
27. {
28. elements = uidoc.Selection.Elements;
29. message = "Failed to delete selection.";
30. return Autodesk.Revit.UI.Result.Failed;
31. }
32. else
33. {
34. return Autodesk.Revit.UI.Result.Cancelled;
35. }
36. }
37. catch
38. {
39. message = "Unexpected Exception thrown.";
40. return Autodesk.Revit.UI.Result.Failed;
41. }
42. }