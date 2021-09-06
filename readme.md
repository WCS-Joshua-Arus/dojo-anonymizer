# Anonymizer

Créer une méthode qui prend le path d'un fichier csv en argument et affiche son contenu anonymisé dans la console :

- Les colonnes sont séparées par le caractère ','
- Le fichier est constitué d'un nombre variable de colonnes
- La première colonne contient toujours le nom
- Le nom doit être remplacé par une chaine fixe comme "AAAAAA"
- Les autres colonnes doivent être affichées telles quelles
- Chaque colonne doit être séparés par la chaine " - " dans la sortie console
- La 1ère ligne du fichier CSV contient des entêtes à afficher telles quelles (pas de remplacement par "AAAAAA")

### Rappel sur la lecture d'un fichier
> String[] lines = System.IO.File.ReadAllLines("c:\\\file.csv");