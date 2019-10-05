/*Procédure pas à pas: Ajouter un groupe de rubans Hello World
Dans la section Procédure pas à pas: Bonjour tout le monde, vous apprendrez à créer une application de complément et à l'invoquer dans Revit. Vous apprendrez également à créer un fichier manifeste .addin pour enregistrer l'application de complément en tant qu'outil externe. Un autre moyen d'appeler l'application de complément dans Revit consiste à utiliser un panneau de ruban personnalisé.
Créer un nouveau projet
Effectuez les étapes suivantes pour créer un nouveau projet:
1. Créez un projet C # dans Visual Studio à l'aide du modèle de bibliothèque de classes.
2. Tapez AddPanel comme nom de projet.
3. Ajoutez des références à RevitAPI.dll et RevitAPIUI.dll en suivant les instructions de la procédure précédente, Procédure pas à pas: Hello World.
4. Ajoutez la référence PresentationCore:
o Dans l'Explorateur de solutions, cliquez avec le bouton droit sur Références pour afficher un menu contextuel.
o Dans le menu contextuel, cliquez sur Ajouter une référence. La boîte de dialogue Ajouter une référence apparaît.
o Dans la boîte de dialogue Ajouter une référence, cliquez sur l'onglet .NET.
o Dans la liste Nom du composant, sélectionnez PresentationCore.
o Cliquez sur OK pour fermer la boîte de dialogue. PresentationCore apparaît dans l'arborescence de référence de l'Explorateur de solutions.
5. Ajoutez la référence WindowsBase ainsi que System.Xaml en suivant les étapes ci-dessus.
Changer le nom de la classe
Pour modifier le nom de la classe, procédez comme suit:
1. Dans la fenêtre d'affichage des classes, cliquez avec le bouton droit sur Class1 pour afficher un menu contextuel.
2. Dans le menu contextuel, sélectionnez Renommer et remplacez le nom de la classe par CsAddPanel.
3. Dans l'Explorateur de solutions, cliquez avec le bouton droit sur le fichier Class1.cs pour afficher un contexte.
4. Dans le menu contextuel, sélectionnez Renommer et remplacez le nom du fichier par CsAddPanel.cs.
5. Double-cliquez sur CsAddPanel.cs pour l'ouvrir pour le modifier.
Ajouter un code
Le projet Ajouter un panneau est différent de Hello World car il est automatiquement appelé lors de l'exécution de Revit. 
Utilisez l'interface IExternalApplication pour ce projet. L'interface IExternalApplication contient deux méthodes abstraites, OnStartup () et OnShutdown (). 
Pour plus d'informations sur IExternalApplication, voir Intégration de complément.
Ajoutez le code suivant pour le panneau du ruban:*/


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