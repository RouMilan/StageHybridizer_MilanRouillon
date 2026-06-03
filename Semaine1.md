                        Stage Hybridizer
Lecture du GitHub :

Dans les fichiers annexes : On retrouve le Code de Conduite de l'utilisation du Git. Dans ce dernier, on voit qu'il faut rester dans un contexte approprié pour le travail, et rester respectueux envers les autres utilisateurs et dévellopeurs du site web.

On apprends aussi qu'il ne faut que lancer les codes par pull requests, et que seule une personne admin peut accepter le code envoyé. 
Avant de se faire accepter son code, il faut préciser le hardware utilisé par le développeur. 

Question : Quel est mon Hardware ?

Temps Passé : 3 minutes

Réponse : En allant dans le gestionnaire de l'ordinateur, on a accès aux détails techniques du processeur et de la carte graphique de l'ordinateur. Mon ordinateur possède une carte graphique NVIDIA
GEFORCE GTX., et un processeur INTELCORE. 

On nous donne aussi accès à une licence MIT, et je n'ai pas encore compris à quoi elle servait. 

Question : A quoi sert cette licence MIT ?

Réponse : Il s'agit d'une licence très répandue, qui permet d'utiliser le logiciel de Hybridizer, tout en se dédouanant si le code ne fonctionne pas.

Dans le vs.code : On retrouve un fichier de débogage en JSON, qui permet le lancement du programme de deux manières différentes. Les deux font globalement la même chose, sauf que un des lancements se fait depuis la console, et l'autre peut se faire depuis .net.

Dans source : On retrouve pleins d'exemples d'utilisations, formés un peu comme des exercices, qui possèdent toujours une utilisation de cuda.
On retrouve aussi des explications de code dans le wiki, même si pas très détaillés.

Dans issues : On compte 10 erreurs non traitées dans OPEN, avec certaines qui datent de 2017, avec la plus récente en mai 2026
On compte 63 erreurs erreurs traitées dans Closed, avec aucune traitée depuis 12/2025

Dans pull requests : On remarque qu'il ne s'y trouve aucun request ouvert, ce qui veut dire que tout les pulls requests ont été acceptés.
Au total, 41 ont été acceptés, et le plus récent date du 27/01/2026. Le plus actif sur les pulls request semble être le compte JeWave.

Dans Insights : Très utile car on peut voir toutes les informations de l'activité des contributeurs. 
On peut également comparer le github de Hybridizer par rapport aux standards de la communauté.

Selon GitHub, il manque une Security Policy, une Issue Template (pourtant bien integré), une Pull Request Template, et une Repository admin to accept content reports.

Problème rencontré : Dans l'Issue Template, on nous dit qu'il faut un Visual Studio 2017 ou moins, alors que dans le README, il est marqué qu'un Visual Studio de 2022 marche. 

Problème rencontré : Que veut dire generated code or binary ?

Dans la Version gratuite de VS, le dll est généré directement. Alors que dans un VS d'entreprise, le code CUDA peut également être généré, qui permet d'expliquer le code plus facilement.

Question : Qu'est-ce-que dll, et à quoi ça sert ?

Réponse : En anglais, le DLL veut dire Dynamic Link Library. Il s'agit juste du code compilé qui permet de partager le code sans avoir accès à la source.


Blocage : Installation du Markdown

Temps passé : 30 minutes 

Problèmes : réinstallation de visual studio suite à un problème d'ouverture d'une version, puis installation de l'extension Markdown Editor.

Question : Qu'est-ce-que AMD, et à quoi ça sert ?

Réponse : AMD est une autre entreprise, qui vend, comme NVIDIA, des puces de GPU, de CPU, et d'autre hardware.
Il utilise donc un autre langage pas compatible avec Hybridizer. 

Question : Quelle est la différence entre un CPU et un GPU ?

Réponse : un CPU possède quelques coeurs très puissants, mais peut donc traiter que quelques calculs à la fois, mais les calcule très vite.
Quant à lui, le GPU peut traiter beaucoup plus de calculs à la fois, mais ces derniers sont effectués moins rapidement.

Lecture de la doc :

La page commence avec une définition de Hybridizer; voici une définition simplifiée : 
Hybridizer est un traducteur qui permet d'écrire un code C# compréhensible par le GPU et le CPU.
De base, il faut savoir que le GPU et le CPU ont besoin d'un langage différents, donc à traduire pour travailler ensemble.
Cela rend donc le produit très intéréssant.

On a ensuite deux choix différents afin d'installer Hybridizer sur son ordinateur;

-premier choix : pour les personnes très expérimentés, sans tutoriel, juste avec les prérequis, le code pour installer et la vérification.

-deuxième choix : Passage par tutoriel avec une installation en 15 min: 

On ouvre avec une phrase d'accorche qui dit, qu'en partant de 0, on peut construire un code 
capable d'accélerer les performances de sa carte graphique. De plus, nous avons un tableau des softwares et du hardware prérequis pour l'installation de Hybridizer.

On a ensuite 6 grandes étapes d'installation;

- Installation de Driver NVIDIA : On trouve ici un lien vers le site de NVIDIA.
    Blocage : Sans essayer d'installer le driver, le site renvoie vers la page d'acceuil de NVIDIA, sans qu'il soit précisé 
quel driver il faut télécharger. Quelqu'un de peu renseigné aurait du mal à comprendre ce qu'il faut télécharger et risquerait de se tromper lors de son téléchargement.
    
    Blocage : De la même façon, sans essayer de télécharger ou de faire valider, le 3ème point ne lit que "vérifier :"
avec une petite console, mais on a pas de contexte supplémentaire.
    
    Remarque : On nous montre ensuite un tableau généré par l'IA avec les informations que l'on devrait avoir en compilant le code dans une console. Ce n'est pas très clair et cela pourrait prêter à confusion.

    Solutions : Face à ces problèmes, une bonne solution serait d'ajouter plus de captures d'écran, pour que le nouvel utilisateur puisse comprendre sans trop rélféchir ce qu'il est censé faire.
- Installation CUDA : Grâce au lien donné juste en-dessous du titre, qui mène directement sur la page d'installation, Les points 1. et 2. ont l'air assez simples.
    
    Cependant, de la même façon que dans le point précédent, le point 3. Verify n'est pas clair.
- Installation NET 8.0 : Pour cette installation, sans l'avoir essayée, elle a l'air claire, surtout pour les utilisateurs ayant Visual Studio.

- Installation d'une chaîne d'outil C++ : Facile à comprendre, il manquerait peut être d'une liste ou d'une capture d'écran de ce dont on a besoin d'installer pour le C++.

- Installation Hybridizer : Si Hybridizer est vraiment disponible sous forme de package, alors cette étape semble plutot facile.

- Vérification de l'installation : On nous fournit un texte à copier-coller qui paraît plutôt simple. De plus, on a accès 
à plusieurs cas d'erreur, ce qui est très utile pour un nouvel utilisateur.

À Verifier la semaine prochaine, pendant la tentative d'installation :
- Installation en 15 minutes comme indiqué sur le site. 
- Revenir sur les 3.Verify pour voir si c'est compréhensible si l'on est devant la console.
- Explorer le site de NVIDIA pour vérifier si l'installatation du driver est simple.
- Vérifier si l'installation de NET8.0 est simple.
- Troubleshooting, y'a t-il des failles non ramassées dan sle tableau donné sur le site ?
- Essayer le reste des tutoriels.

Onglet "What is Hybridizer ?" :

De la même facon que sur le premier onglet, on a une définition donnée sous le titre; Si on la simplifie, 
on apprends que le but d'Hybridizer est de faciliter le travail des dévellopeurs. Une fois installé, tu ne te rends même pas compte
que la traduction C#->langage(CPU/GPU) se fait automatiquement. Grâce à cet outil, il est beaucoup plus facile 
d'apprendre à travailler directement sur le CPU/GPU, car il suffit de n'utiliser qu'un langage au lieu d'en apprendre 2
qui ne sont pas très communs (CUDA/AVX par exemple).

Titre Hybridizer en opération : Ici, on nous rapelle que Hybridizer fonctionne sur un langage intermédiaire, 
et on nous présente deux langages qui sont supportés par le compilateur : le MSIL et le LLVM.

Sur le site, nous ne savons pas forcément ce que ces langages veulent dire et ce qu'ils ont de différent. 

Question : C'est quoi le MSIL ?

Réponse : En anglais, il s'écrit Microsoft Intermadiate Language. 
Il s'agit d'un langage intermédiaire qui fonctionne entre le C# et le hardware, en attendant de se faire traduire par le CLR. 
Il est plus adapté pour pouvoir satisfaire plusieurs composants en même temps, 
et est donc moins précis que le LLVM.

Question : C'est quoi le LLVM ?

Réponse : Il s'agit d'un langage intermédiaire qui fonctionne entre le C# et le hardware. 
Il est plus adapté pour pouvoir satisfaire un seul composant
 en même temps, et est donc plus précis que le MSIL, mais est plus compliqué à faire marcher sur plusieurs composants.

Question : C'est quoi le CLR ?

Réponse : En anglais, il s'écrit Common Language Routine. 
Il s'agit également d'un langage intermédiaire qui fonctionne entre le C# et le hardware.
Cependant, il agit après le code et le traduit dans le language du composant. Il a donc un rôle similaire à celui d'Hybridizer, mais est moins efficace.

Idée d'amélioration : Si possible, il serait plus avantageux de créer des liens hypertextes pour mieux expliquer les différentes abréviations.

On nous montre ensuite un schéma qui montre les différents langage d'entrée (comme le C/C++, le JAVA, ou le .Net),
ainsi que les langages sur lesquel Hybridizer marche. On retrouve notamment le OPENCL, le C++, le AVX, le CUDA etc...

On a ensuite le titre "Concepts Clés" :
- Source unique : qui permet de coder sans faire de compromis avec les autres types de langage.
- Possibilité d'avoir plusieurs backend : Donc d'avoir plusieurs sorties pour une entrée, selon le composant.
- Performance : Enlève le retard d'optimisation de backends classiques.
- Possibilité d'apeller ces backends depuis le .NET

Question : C'est quoi un backend ?

Réponse : Il s'agit de la traduction entre le langage intermédiaire et la machine. En sorte, il s'agit donc 
de la sortie du signal après être passé par le langage intermaédiaire.

On a ensuite le titre "Pourquoi Hybridizer ?" :
- On a ici une traduction plus rapide et plus efficace par rapport au CLR. 
- Plus productif, car besoin d'écrire dans un langage précis.
- Diversité; En écrivant un code, on peut l'executer sur plusieurs composants. 
- Moins de limitations par rapport au langage précis du composant, on a donc accès à plus de commandes différentes.
- Confiance : On peut toujours avoir la même chaîne de compilation, et il n'y a pas besoin de coder de manière implicite.

Titre "Limites de l'outil" : 
En effet, le compilateur présente quelques limitations, ces commandes ne sont pas supportées :
- Les instances de classe
- Le type string 
- Les exceptions catch/throw, et donc la commande foreach, qui utilise catch/try
- Utilisation de régions lock
- La récursivité, même s'il y a des moyens de la recréer, présents dans le Git
- Les fonctions génériques et quelques combinaisons de type génériques.

Titre "Prochaines Etapes" :
- Obtenir une vue d'ensemble plus claire sur le produit
- Pouvoir avoir un démarrage plus rapide -> Idée pour avoir une installation plus rapide
- Pouvoir avoir un guide plus global sur le site, pour pouvoir apprendre plus vite.

Onglet "Quand utiliser Hybridizer ?" :

Le compilateur est utile quand : 
- Il y a plusieurs requêtes CPU-GPU à traiter, comme les cellules avec matrices, ou encore l'application d'un filtre sur une image.
- Quand il y a des bouts de code qui sont très utilisés, les "hot chains".
- Quand il y a besoin de faire du cross-platform CUDA/C.

Il possède cependant quelques limitations :
- Le transfert de mémoire CPU <-> GPU est coûteux.
- Les limitations vu auparavant.

Prochain Onglet : Install 

Première Option : aller sur le tutoriel d'installation plus guidé.

Ensuite, on a encore une checklist rapide, aves les mêmes outils que sur la page tutoriel. Cette dernière 
est vraiment très peu détaillée, ce qui est normal car elle s'adresse aux personnes déjà expérimentées. 

Les constructeurs et les vérificateurs sont montrés tous d'un coup, et on peut les copier coller dans notre console.
Seule différence de présentation, les vérificateurs ont le contexte ligne par ligne, afin que la personne qui utilise le 
service sache quel est le problème avec son installation. 

Meeting avec Monsieur Ramponi, le tuteur de stage : 

On discute vite fait de l'avancée de la première journée, et on me donne comme tâche de créer un repository Github pour y déposer, 
entre autre, ce fichier Mardown. On pourra utiliser ce repository dans la suite du stage pour y déposer d'autres fichier.

Pendant ce meeting, nous avons aussi discuté du fait qu'il est primordial de vraiment comprendre comment fonctionne 
un CPU et un GPU afin de comprendre comment marche le produit Hybridizer. Il est aussi très important 
de connaître la différence entre les deux.

On m'a également transmis le lien vers l'ancien site : https://docs.altimesh.com/articles/CUDABasicConcepts.html, afin 
que je puisse comprendre mieux le fonctionnement du site actuel, ainsi que le produit.

Première Tâche : Création de repository :

Temps passé : 7 minutes

Tâche réalisée : Depuis Visual Studio, j'ai pu facilement créer un nouveau repository sur le site en ligne GitHub,
grâce à l'onglet Git dans Visual Studio. Le push, donc le fait d'envoyer cette page sur le site web s'est fait
automatiquement et sans soucis.

Question : Que fais concrètement un CPU ?

Réponse : En anglais, le CPU s'appele le Central Processing Unit, aussi appelé microprocesseur.

Physiquement, il s'agit d'une puce qui execute une suite de tâches appelées programmes. Cet dernière est composée de milliers de transistors.
L'architecture sur lequelle cette puce repo se s'appelle l'architecture Von Neuman. 

Si l'on décortique cette puce, elle est composée d'une unité de contrôle, et d'un unité de Logique Arithmétique.
Sur les CPU de base, comme ils étaient au début, on retrouve un Data Bus, un Adress Bus, et un Control Bus.

Question : À quoi sert le Data Bus ?

Réponse : Le Data Bus sert à transférer les données de l'entrée à la sortie.

Question : À quoi sert l'Adress Bus ?

Réponse : L'Adress Bus sert à trouver l'endroit où il faut prendre ou envoyer les données.

Question : À quoi sert le Control Bus ?

Réponse : Le Control Bus sert à aller chercher les données et à les modifier.

Le rôle d'un CPU se résume donc à prendre un Code Machine en entrée, qui, en passant par le CPU, aura une sortie prédéterminée.
Pendant que cette transformation a lieu, le CPU communique toujours à la mémoire qui reste stockée.

Le CPU fonctionne avec le cycle Fetch-Decode-Execute. Si l'on traduit ces trois étapes, on trouve : 

Fetch : Le CPU cherche une instruction de mémoire, qui est sous forme de valeur.

Decode : La valeur cherchée est ensuite traduite.

Execute : La tâche est ensuite efectuée en fonction de la valeur traduite.

Tout CPU fonctionne avec un signal horloge, qui est mesuré en GHz, ce qui lui permet de calculer des millers de fois par seconde.

Pour mieux comprendre concrètement comment tout cela fonctionne, il faut faire un tableau de données présentes dans la RAM :

Question : Qu'est-ce qu'une RAM ?

Réponse : En anglais, on l'appelle la Random Access Memory, qui sert à stocker les données et programmes
des programmes en cours d'utilisation. Le CPU lit et écrit très rapidement dans la RAM. Par exemple, 
en ouvrant un logiciel, on retrouve les données chargées dans la RAM.

Prenons ce tableau comme exemple : On a la RAM à gauche, et le CPU à droite :

Adresse | Valeur      | |   Compteur Programme   | Instruction Retenue
-----|--------        | |            
0000 |  1010          | |                   0000 | 1010
0001 |  1110          | |                   1010 | 0001
0010 |  1000          | |                   0001 | 1110  
1010 |  0001          | |                   1110 | XXXX

Le compteur programme retient donc qu'à l'adresse 0000, il faut executer la valeur de 1010, et ainsi de suite. 
Chaque valeur binaire comprends sa propre instruction, comme dit auparavant.

Pour coder sur un CPU, il faut pouvoir lui donne run code qu'il comprends.
De base, on a un fonctionnement qui ressemble à peu près à ça :

                       Language assemblé 

    Compréhensible par l'humain car composé de chiffres en base 10 et de lettres
                                |
                                v
                            Frontend 
                                |
                                v
                            Compilateur 
        Traduit le langage assemblé en Code Machine, Binaire
                                |
                                v
                              Backend
                                |
                                v
                               CPU

On peut maintenant s'intéresser au CPU modernes, qui sont beaucoup plus complexes. En effet, certains
peuvent avoir plusieurs cores, qui peuvent chercher entres elles le cylce Fetch-Decode-Execute.
Or, maintenant, ces cores peuvent maintenant se diviser en 2 pour créer des threads. Donc pour un 
processeur à 4 cores, il peut maintenant s'occuper de 8 tâches à la fois.

On peut maintenant aussi introduire la notion de Cache; ce sont des éléments de mémoire très faciles à atteindre 
par le CPU, contenant des informations ou instructions réutilisables.

Les processeurs d'aujourd'hui contiennent aussi des algorithmes qui peuvent anticiper la taille de mémoire 
nécessaire qu'une certaine tâche pourrait prendre. Cela permet en avance de chercher plus vite les informations contenues
dans la RAM.

Un CPU peut également maintenant contenir des FPU, ou Floating Point Unit, qui permettent de faire des calculs mathématiques 
très puissants.

On peut maintenant également y trouver des IPU (Intelligence Processing Units), permettant de mieux comprendre
lors du Machine Learning.

Un élément très important que l'on retrouve dedans aujourd'hui sont les GPU.

Question : Qu'est-ce donc un GPU ?

En anglais, un GPU s'appelle un Graphics Processing Unit. 

Pour faire simple, un GPU possède des milliers de coeurs plutot simples. Cela permet au GPU de calculer 
une multitude de tâches à la fois. 

Le GPU est surtout utile pour tout ce qui touche à la génération 3D, comme les jeux vidéos ou le montage vidéo.
Récemment, on peut beaucoup l'utiliser pour l'intelligence artificielle ou les simulations scientifiques. 

Dans son fonctionnement de base, le CPU prépare les informations avant de les envoyer au GPU, qui calculera 
le reste des informations, avant de les envoyer sur l'écran.

Par exemple, dans un jeu vidéo, le CPU prépare les objets, les positions ou encore la physique, et les
envoie au GPU calcule l'éclairage et les textures, avant d'envoyer l'image finale qui sera montrée sur l'écran.

Comme pour le CPU, le GPU possède une entité mémoire qui s'apelle la VRAM. 

Question : Quelle est la différence entre la VRAM et la RAM ?

Réponse : Un peu comme la différence basique entre le CPU et le GPU, la VRAM contient beaucoup plus de places 
pour contenir beaucoup plus de données. 

En effet, comme le GPU doit déplacer beaucoup plus de quantité de données graphiques chaque seconde, 
il a besoin d'une mémoire différentes de celle du CPU. 

Imaginons encore qu'on lance un jeu. Voici le chemin entier pour pouvoir afficher le jeu à l'écran :

Les données du jeu sont en premier stockés sur le SSD. 

Question : Quel est le rôle du SSD ?

Réponse : En anglais, SSD veut dire Solid State Drive. C'est le composant qui sert à stocker toutes les données
de manière permanentes. Contrairement à la RAM ou la VRAM, ces données restent présentes même lorsque l'ordinateur 
est éteint. 

Le SSD envoie ensuite les données à la RAM, afin que le CPU puisse accéder à ces mêmes données beaucoup plus rapidement, 
Une fois que le CPU reçoit toutes les informations, il prépare une suite de commandes pour le GPU. 

Une fois que le GPU reçoit ces commandes, il stocke les informations importantes dans sa VRAM, afin d'avoir accès aux données plus 
rapidement lors de ces prochains calculs.

Le GPU calcule ensuite l'image, envoie une image intermédiaire à la VRAM, puis envoie l'image à l'écran.
Lors du calcul de l'image, chaque coeur du GPU s'occupe d'un ou de quelques pixels, et calcule par exemple 
sa couleur, son éclairage, ou encore ses ombres.

On a vu tout à l'heure que certains CPU modernes pouvaient contenir un GPU integré. Ceci est vrai, mais ce n'est pas l'architecture
la plus performante. Si le GPU se trouve dans la même puce que le CPU, alors il ne peut pas possèder sa propre VRAM, 
et est donc contraint d'utiliser la RAM. 

C'est donc une solution qui est plus utile si on veut économiser de l'espace par exemple.

Question : C'est quoi une SIMD ?

Réponse : SIMD signifie Single Instruction, Multiple Data. C'est un type d'opération qui permet d'effectuer plusieurs 
changements de données à partir d'une seule instruction. On peut donc voir le GPU comme une grand machine 
SIMD spécialisée.

Question : C'est quoi concrètement CUDA ?

Réponse : Compute Unified Device Architecture. Il s'agit d'un langage qui ressemble à peu près au C,
utilisé pour coder directement sur les carte sgraphiques NVIDIA. On appelle un CUDA core un coeur CUDA, 
qui agit comme un mini-processeur capable de faire des opérations mathématique simple.

On s'interesse maintenant à l'ancien site : https://docs.altimesh.com/articles/CUDABasicConcepts.html.

On nous dit que les coeurs CUDA ne sont pas des coeurs de CPU. Ils agissent plus comme des chemins de
SIMD, donc de systèmes plusieurs sorties pour une instruction.

On nous montre ensuite un tableau sans trop de contexte, comparant les caractéristiques d'une carte graphique 
et d'un micro-processeur. 

Question : C'est quoi le CUDA threading ?

Réponse : Il s'agit d'un modèle d'éxecution permettant de répartir un calcul sur des milliers de threads.
L'idée est donc, au lieu d'avoir quelques gros threads sur le CPU, CUDA les transforme en pleins de petits threads qui traient indépendamment
la requête demandée.

Principe fondammental de CUDA : Organisation par Grid, Block, Warp et Thread. 

On marquera que le signe "<" veut dire dedans. Exemple Volant < Voiture 

Comme expliqué auparavant un thread est donc une tâche exécutée, qui peut agir sur un ou plusieurs coeurs.

On a donc Thread < Warp < Block < Grid. En général, il n'y a qu'une seule Grid.

On peut maintenant expliquer les fonctions threadIdx, blockIdx et BlockDimx;

Sur le site, ce n'est pas très clair car il n'y a pas forcément d'explications sur ce à quoi ces fonctions correspondent.

threadIdx : Numérotation du thread dans le bloc. On peut le retrouver facilement car les cases sont incrémentés dans l'ordre.

blockIdx : Numérotation du Bloc dans la Grid. De la même manière que les threads, ils sont numérotés par ordre croissants donc faciles à retrouver.

blockDim : Taille du bloc en threads. Par exemple, si chaque bloc possède 256 threads, blockDim sera toujours égal à 256.

Logiquement, pour accéder à un thread en particulier, il faut donc utiliser l'opération suivante :
On veut accéder au thread 133 du bloc 3, avec tous les blocs étant de dimension 256.

int id = blockIdx.x * blockDim.x + threadIdx.x;

Avec blockIdx = 3, blockDim = 256, threadIdx = 133. Nous sommes obligés de rajouter le .x après chaque fonction
afin de bien être sûr d'accéder au résultat contenant l'entité x.

Question : Que veut dire SM ?

Réponse : Ce n'est pas précisé sur le site, mais SM signifie le Streaming Multiprocessor. Il s'agit de l'unité principale
de calcul d'un GPU NVIDIA. Chaque GPU en contient plusieurs, et chaque SM contient plusieurs cores NVIDIA.
Sur le site : "1 block run on a single SM", ce qui veut dire que chaque block ne fonctionne qu'avec un SM.
Si j'ai bien commpris, il y a une faute d'orthographe. Sinon cela veut dire que je n'ai pas compris ce qu'est un Block Run.

Problème dans les sites : on explique très brièvement threadIdx et blockIdx, mais jamais blockDim.

Dans l'ancien site, on continu ensuite de nous expliquer le fonctionnement en code CUDA, ce qui nous 
interèsse moins que ce qui se trouve sur le site docs Hybridizer.

En effet,on va maintenant retourner sur l'autre site, dans l'onglet Core Concepts.

Cet onglet décrit donc les concepts fondammentaux. Décortiquons la première phrase du site, qui paraît compliquée à la première lecture.
La présentation se fait en trois parties; 

- Comment les tâches de calcul sont répartis sur les différents composants.
- Le rôle des kernels et des points d'entrée.

Définition Kernels : Fonctions conçues pour s'executer en parrallèle sur un GPU. Ici, la phrase "s'executer en parrallèle" 
se traduit pas le fait d'envoyer une tâche qui est faites plein de fois en simultané. Il s'agit donc d'un système en SIMD.

Définition Points d'entrée : Il ss'agit de l'endroit où le GPU commence son execution du programme.

- On nous explique aussi qu'on trouvera la syntaxe du code, ou les abstractions que le Hybridizer permet de mettre 
- en place pour faciliter son utilisation.

On commence donc avec le moyen avec lequel le travail est distribué aux nombreux composants disponibles :

Le Hybridizer peut donner plusieurs approches avec plusieurs niveaux de contrôle.

Le modèle Work Grid : Comme vu auparavant, il est possible de séparer notre problème en Grid, Blocks, et Threads.
On appele en OpenCL les blocks les Work Groups, et les threads les Work Items. 

Question : C'est quoi OpenCL ?

Réponse : Il s'agit d'un type de langage, qui, comme Hybridizer, peut fonctionner sur plusieurs composants.
La différence reste dans le fait qu'il faut réecrire son code existant pour le faire marcher, Alors qu'avec 
le Hybridizer, il n'y a pas besoin de changer son code pour qu'il soit adapté à tous les composants.

Blocage sur le tableau du passage de CUDA au Vecteur Hybridizer : On ne nous parle jamais de vecteurs auparavant, 
et le terme peut rendre les utilisateurs confus au premier abord.

Question : C'est quoi le Hybridizer Vector ?

Réponse : Il s'agit d'un terme très proche de SIMD, où une entrée vectorielle correspond à une instruction donnée en SIMD.

On a donc les Blocks CUDA qui deviennent des Threads Hybridizer, et les Threads CUDA qui deviennent des Entrées Vectorielles Hybridizer.
Prenons par exemple ce code : 

[EntryPoint]
public void Square(int count, double[] a, double[] b)
{
    for (int k = threadIdx.x + blockDim.x * blockIdx.x; 
         k < count; 
         k += blockDim.x * gridDim.x)
    {
        b[k] = a[k] * a[k];
    }
}

On retrouve ici le [EntryPoint], qui sert à mettre en marche le GPU.
Ensuite, on a une méthode de Void prenant en initialisation deux tableaux.

Intéressons nous à la boucle for du programme; 

Lorsqu'on prends en entrée le thread 0 du block 0, on a threadIdx = blockIdx = 0.

Dans ce cas là, on a k = 0. k est incrémenté de (taille du block)*(taille du thread) afin de bien faire toutes 
les opérations nécessaires en même temps, sans passer deux fois sur le même, ni en en manquant. 

La boucle s'arrête quand k dépasse la valeur count, qui est la taille des tableaux rentrés en paramètre.

Le but de ce code est plutôt facile, car ils'agit uniquement de mettre le tableau au carré le tableau a,
en le transposant dans le tableau b.

On nous présente ensuite le constructeur Parallel.For. Sur le site, on nous dit que ce constructeur est 
une méthode statique avec une implementation interne. 

Je ne comprends pas le reste des explications. 

Voici le code :

[EntryPoint]
public static void RunParallelFor(int[] input, int[] output, int size)
{
    Parallel.For(0, size, i => output[i] = input[i] + 1);
}

Enfait, la structure du code fais exactement la même chose que le code d'avant, mais est cette fois-ci beaucoup plus facile à écrire.
Cependant, au lieu de mettre tous les éléments du tableau au carré, il rajoute 1 à toutes les cases. 
Si il faisait exactement la même chose que le tableau d'avant, le code aurait prit cette forme :

[EntryPoint]
public static void RunParallelFor(int[] input, int[] output, int size)
{
    Parallel.For(0, size, i => output[i] = input[i] * input[i]);
}
On nous présente ensuite la différence entre SIMD et SIMT. Ces deux concepts sont très similaires, mais 
le SIMT remplace le Data par Threads. On en conclut donc que le SIMT est utilisé surtout sur GPU, 
et le SIMD est utilisé surtout sur les CPU.

Onglet Compilation Pipeline :

On nous explique que le code transformé a besoin de passer par plusieurs étapes, et que ces étapes seront expliqués dans cet onglet.

Remarque : Le Schéma est trop petit et n'est pas lisilbe, sauf en ouvrant l'image dans un autre onglet.

Première partie du schéma : Passage du User Source Code à l'assemblage .NET :

Lorque l'on code en C#, ou en VB.NET, le code est automatiquement téléchargé en fichier de configuration. 
En effet, on apelle le code écrit par l'humain le code source, et la deuxième étape se charge de le transformer 
en fichier de configuration sur lequel le Hybridizer pourra agir.

Deuxième partie du schéma : Passage de l'assemblage .NET à la configuration de base de l'Hybridizer :

Dans cette partie, la configuration Hybridizer prends en compte tous les méthodes ou les types à 
transformer. Ce fichier de configuration est généré depuis les variables dans l'assemblage d'entrée.
On appelle cette étape Le Build Satellite

Troisième partie du Schéma : Configuration de base de l'Hybridizer à la configuration d'Hybridizer :

Ici, Hybridizer transforme les méthodes retenues pendant la configuration de base, et génère le code source 
le plus adapté. Dans le site, on appelle ça le Flavored Code Generation. On imagine donc que le code source
prends sa "saveur" par rapport à ce qu'il a retenu dans sa configuration de base. 

Quatrième partie du schéma : Configuration Hybridizer à la source Généré :

On finit avec la compilation finale, où le code généré par Hybridizer est compilé et est envoyé au 
composant adapté. Hybridizer traduit donc le m^me code pour chaque composant, et ressort donc un backend avec d'autres 
langages, le plus souvent avec des langages qui se rapprochent d'un équivalent du Code Machine.

Finalement, on ressort avec un code hybride qui peut fonctionner sur tout appareil depuis un code C#.

On a ensuite un example de l'étape 2 : les paramètres des constructeurs (Build Parameters) :

Il s'agit d'un code MSBuild (donc en XML) qui est déjà integré dans le package NuGet. 

Remarque : Il n'est jamais écrit clairement qu'il n'y a pas besoin de copier ces programmes, et qu'ils 
seront installés automatiquement en téléchargeant le package NuGet Hybridizer.

Pour l'étape 3 : De la même manière, on nous présente un code XML contenu dans le package NuGet. 

On nous montre ensuite un tableau avec des Options de COnfiguration Clés, qui sont des noms de méthodes. 

Remarque : à part le nom des méthodes et une très petite explication, on nous montre pas du tout comment les integrer
dans le code, car ils ne sont pas du tout inclus dans le code donné en exemple. 

Remarque : On nous dit qu'il existe des tableau de type Hybridizer, mais nous n'en avons jamais entendu parler, 
l'utilisateur peut donc se demander à quoi ces derniers servent-ils.



