# Algorithmes de Tri en C#

Ce projet contient une implémentation de six algorithmes de tri classiques en C#. Il est conçu comme un outil éducatif pour comprendre le fonctionnement de ces algorithmes et leur utilisation pratique.

## Contenu

Le projet comprend les algorithmes de tri suivants :

1. Tri à bulles (Bubble Sort)
2. Tri par sélection (Selection Sort)
3. Tri par insertion (Insertion Sort)
4. Tri rapide (Quicksort)
5. Tri fusion (Merge Sort)
6. Tri par tas (Heap Sort)

## Structure du Projet

Le projet est contenu dans un seul fichier C# (`SortingAlgorithms.cs`) qui inclut :

- Une classe `SortingAlgorithms` contenant toutes les implémentations des algorithmes de tri.
- Une méthode `Main` qui démontre l'utilisation de chaque algorithme.
- Une méthode utilitaire `PrintArray` pour afficher les tableaux.

## Utilisation

Pour utiliser ces algorithmes dans votre propre projet :

1. Copiez la classe `SortingAlgorithms` dans votre projet.
2. Appelez la méthode de tri souhaitée en passant votre tableau d'entiers.

Exemple :

```csharp
int[] myArray = { 64, 34, 25, 12, 22, 11, 90 };
SortingAlgorithms.BubbleSort(myArray);
```

## Exécution de la Démonstration

Pour exécuter la démonstration incluse :

1. Compilez le fichier `SortingAlgorithms.cs`.
2. Exécutez le programme résultant.

Vous verrez la sortie montrant chaque algorithme triant un tableau d'exemple.

## Complexité des Algorithmes

- Tri à bulles : O(n^2)
- Tri par sélection : O(n^2)
- Tri par insertion : O(n^2)
- Tri rapide : O(n log n) en moyenne, O(n^2) dans le pire des cas
- Tri fusion : O(n log n)
- Tri par tas : O(n log n)

## Contribution

N'hésitez pas à contribuer à ce projet en proposant des améliorations, des optimisations ou en ajoutant de nouveaux algorithmes de tri.

## Licence

Ce projet est sous licence MIT. Vous êtes libre de l'utiliser, de le modifier et de le distribuer selon les termes de cette licence.
