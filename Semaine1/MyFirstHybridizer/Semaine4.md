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

On va aujourd'hui continuer les tests des exemples hybridizer :

Test **Printf** : La sortie nous donne une série de "hello", avec chacun d'entre eux venant d'un thread et d'un bloc différent.

On a donc une sortie comme ça : 

