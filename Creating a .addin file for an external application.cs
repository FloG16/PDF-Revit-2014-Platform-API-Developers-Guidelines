/*Construire l'application
Après avoir complété le code, générez l'application. Dans le menu Générer, cliquez sur Générer la solution. 
La sortie de la construction apparaît dans la fenêtre Sortie indiquant que le projet a été compilé sans erreur. AddPanel.dll se trouve dans le répertoire de sortie du projet.
Créer le fichier manifeste .addin
Pour appeler l'application dans Revit, créez un fichier manifeste pour l'enregistrer dans Revit.
1. Créez un nouveau fichier texte à l'aide du Bloc-notes.
2. Ajoutez le texte suivant au fichier:*/

<?xml version="1.0" encoding="utf-8" standalone="no"?>
<RevitAddIns>
<AddIn Type="Application">
<Name>SampleApplication</Name>
<Assembly>D:\Sample\AddPanel\AddPanel\bin\Debug\AddPanel.dll</Assembly>
<AddInId>604B1052-F742-4951-8576-C261D1993107</AddInId>
<FullClassName>AddPanel.CsAddPanel</FullClassName>
<VendorId>ADSK</VendorId>
<VendorDescription>Autodesk, www.autodesk.com</VendorDescription>
</AddIn>
</RevitAddIns>

/* 3. Enregistrez le fichier sous le nom HelloWorldRibbon.addin et placez-le à l'emplacement suivant:
o Pour Windows XP - C: \ Documents and Settings \ Tous les utilisateurs \ Application Data \ Autodesk \ Revit \ Addins \ 2012 \
o Pour Vista / Windows 7 - C: \ ProgramData \ Autodesk \ Revit \ Addins \ 2012 \
Remarque le fichier AddPanel.dll se trouve dans le dossier de fichiers par défaut, dans un nouveau dossier appelé Debug (D: \ Sample \ HelloWorld \ bin \ Debug \ AddPanel.dll). 
Utilisez le chemin du fichier pour évaluer l'assemblage.
Reportez-vous à Intégration de complément pour plus d'informations sur les fichiers manifestes .addin.
Débogage
Pour commencer le débogage, générez le projet et exécutez Revit. Un nouveau groupe de ruban apparaît dans l'onglet Compléments, appelé NewRibbonPanel. 
Hello World apparaît en tant que bouton unique du panneau, avec une grande image. */