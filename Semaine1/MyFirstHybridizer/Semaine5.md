# Semaine 5 :

### Réparation des problèmes des exemples :

##### Amelioration SharedMatrix :
Commençons par le fait de rajouter un stopwatch sur le programme suivant : SharedMatrix.

Pour rappel, ce code doit calculer la différence de temps prise par le calcul par le CPU et le GPU des deux matrices qu'il génère, de taille 512x512.

On essaye donc de relancer le code, et on fera des modifications ensuite.

J'ai donc modifié le code en rajoutant de la mise en forme, et en ajoutant des StopWatch
pour mesurer le temps d'execution du calcul sur le CPU et sur le GPU.   

J'ai également pu calculer la proportion de calcul entre les deux calculs, et écrire le résultat.

Voici l'aperçu de la sortie modifiée :

![Modifications Code](AmeliorationSharedMatrix.jpg) 

On essaye de faire un commit, mais il n'y a pas de repo sur lequel ont peut l'envoyer, donc on sauvegarde seulement le code modifié.

##### Amelioration BlackScholes :

De la même manière, il faut modifier les codes de BlackScholes et de BlackScholesFloat4, afin de rajouter un stopwatch.

Pour rappel, ce code montre les différences de calcul entre le CPU et le GPU.

Float4 est censé être plus rapide que la version de base, mais ni l'un ni l'autre n'a un détail
sur le temps d'execution, ce qui est dommage.

En réutilisant les mêmes méthodes que pour SharedMatrix, on peut donc rajouter un stopwatch sur les deux codes.

On fait le test dans le Powershell.

![Modifications Code](AmeliorationBlackScholes.jpg) 

On fait exactement la même chose pour BlackScholesFloat4, et on obtient :

![Modifications Code](AmeliorationBlackScholesFloat4.jpg) 

##### Amelioration SparseMatrix :

On passe maintenant aux codes qui auraient besoin d'un peu plus de contenu dans la sortie

Pour rappel, cette fonction créee une matrice Laplacienne 1D.

Nous allons faire en sorte que le code affiche une plus petite matrice de test, 
et qu'on affiche le temps de calcul de la grande matrice.

On passe un peu de temps à modifier le code, en rajoutant ces méthodes :
 - TestLaplacianSmall
 - PrintSparsematrix
 - GetValue

Voici la sortie améliorée :

![Modifications Code](AmeliorationSparseMatrix.jpg)

#### Résumé de la suite :

- Réussir à commit tous les changements faits sur les programmes suivants :
    - SharedMatrix
    - BlackScholes
    - BlackScholesFloat4
    - 




