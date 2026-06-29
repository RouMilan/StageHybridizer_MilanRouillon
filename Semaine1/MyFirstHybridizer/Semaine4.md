Prise en main de Node :
il faut maintenant que j'installe Node. On m'a expliqué que c'etait un un outil très utilisé par les développeurs pour pouvoir mieux coder l'interface des sites.

Malheureusement, l'installation ne s'est pas fait de manière parfaite.

J'ai donc unn problème dans le terminal de Windows Powershell. Il n'arrive pas à éxecuter le fichier npm, alors qu'il devrait pouvoir le faire.

Je continue de chercher une solution.

C'était dû au fait que j'avais changé le dossier nodejs de place, en essayant de réparer une plus petite erreur.

J'ai maintenant une autre erreur, où on me dit que le fichier npm n'est pas signé digitalement.

J'essaye de faire un pull request pour voir si ça change quelque chose.

J'ai finalement réussi à faire marcher depuis le command prompt, et j'ai appris quelques règles de manipulations importantes ; Il faut absolument que les images présentées dans les fichiers soit accessibles, et que le site ne s'ouvrira pas si il y a un problème de compilation.

C'est très pratique node, on peut voir les changements en temps réel comme si c'était un vrai site.

À faire demain : Installer nodejs sur le pc, et faire comme sur ce pc pour le repo du site.

Je n'ai finalement pas fait les installations sur mon PC fixe, car je ne vois pas vraiment l'intérêt.

Pour rappel, voici le chemin exact pour ouvrir node, dans le command prompt : 

cd C:\Users\milan\OneDrive\Documents\A2.2\hybridizer-io.github.io

Puis 

npm run start

## Suite de tests d'exemples : 

On va aujourd'hui continuer les tests des exemples hybridizer :

Test **Printf** : La sortie nous donne une série de "hello", avec chacun d'entre eux venant d'un thread et d'un bloc différent.

On a donc une sortie comme ça : 

![Resultats Tests](Printf.jpg) 

Test **Recursion** : Ce code est censé calculer 33 millions de factorielles sur le GPU
et retourner "OK" si les calculsse sont bien faits. La vérfication est faite par le CPU, une fois
que le GPU a tout calculé.

On lit bien "OK" dans notre terminal.

Test **Reduction** : Ce code est censé calculer la somme d'un très grand tableau (33 millions de cases)
en utilisant une approchge Grid-Stripe loop. 

Le résultat est donc : ![Resultats Tests](Reduction.jpg) 

Définition Grid-Stride loop : Il s'agit d'une boucle où chaque thread GPU traite 
plusieurs éléments du tableau en faisant des bonds en avant. En effet, quand il n'y a pas assez de threads pour faire 
tous les calculs, le code attribue le calcul nunméro X+1 au premier thread. X corresponds au nombres de threads solicités.


### Passage au tests Imaging :

Test **Sobel** : Ce code est censé détecter les contours d'une image, en la mettant en noir et blanc, 
 en observant les variations de couleurs. Il enregistre ensuite l'image suivante :

Résultat : On ne peut savoir, car on a pas de résultats dans le powershell.

Une IA nous dit qu'il faut avoir une image de base, ce qui paraît cohérent.
On essaye en enregistrant une image au bon endroit. 

Malgré le fait que j'enregistre une image PNG au bon endroit, je ne trouve pas une image générée dans le net8.0.

Il faut donc réparer ce code, ou expliciter comment mieux l'utiliser.

/!\ À réparer dans la documentation /!\



 