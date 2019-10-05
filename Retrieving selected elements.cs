/* Procédure pas à pas: récupérer des éléments sélectionnés
Cette section présente une application complémentaire qui récupère les éléments sélectionnés de Revit.
Dans les applications complémentaires, vous pouvez effectuer une opération spécifique sur un élément spécifique. Par exemple, vous pouvez obtenir ou modifier la valeur du paramètre d'un élément. Effectuez les étapes suivantes pour obtenir une valeur de paramètre:
1. Créez un nouveau projet et ajoutez les références telles que résumées dans les précédentes procédures pas à pas.
2. Utilisez la propriété UIApplication.ActiveUIDocument.Selection.Elements pour récupérer l'objet sélectionné.
L'objet sélectionné est un Revit SelElementSet. Utilisez l'interface IEnumerator ou la boucle foreach pour rechercher le ElementSet.
Le code suivant illustre comment extraire des éléments sélectionnés.*/

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