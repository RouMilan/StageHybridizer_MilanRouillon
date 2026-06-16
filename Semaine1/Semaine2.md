Installation du produit Hybridizer :

Première page : 

Sur le site .io, qui est assez facile d'accès depuis une barre de recherche classique, 
on peut facilement trouver le bouton pour installer la version gratuite.

On va ensuite avoir le choix de remplir un formulaire pour se présenter à l'entreprise, et laisser une petit
message pour expliquer son interêt pour l'entreprise. On peut également sauter cette étape en cliquant sur
le lien pour les utilisateurs pressés.

Problème 1 : En renseignant les champs et en cliquant sur "Download", le lien ne fonctionne pas. 

En cliquant sur le lien pour installer sans se renseigner, on est redirigés vers l'installation de 
"Altimesh Hybridizer Essentials" depuis la marketplace de visual studio. 

Installation :

Premier problème : Mon pare-feu Windows n'a pas reconnu l'application et m'a empêché d'ouvrir l'installateur.
Je me suis quand même débrouillé pour l'ouvrir.

Pendant l'installation :

Important de se rappeler de bien fermer Visual Studio, mais une fenêtre s'ouvre pour nous le rappeler.

Une fois Visual Studio relancé, une fenêtre inaccessible appelée Hybridizer Essentials s'ouvre.

Sur la page d'installation, pas d'informations sur comment tester l'installation du compilateur.

D'ailleurs, sur tout le site.io, on ne trouve aucune information directement sur site.

On peut accéder ensuite à la documentation depuis l'onglet disponible en haut. En revanche, il n'est indiqué
nulle part qu'il y a plus d'aide pour l'installation sur la documentation.

Point à améliorer : Au lieu d'ouvrir un nouvel onglet, la redirection change l'onglet actuel. 
Cela rends donc difficile la navigation entre sites web.

Dans la doc, étape 1 : Installation des drivers NVIDIA : 

Comme indiqué lors de la première semaine, il y a très peu d'indications sur comment faire, et on se retrouve 
vite bloqués sur le site de NVIDIA. Il y a plusieurs types de drivers (Security Update, Game Ready driver), 
et nous n'avons aucun moyen de savoir lequel il faut installer.

J'essaye donc depuis NVIDIA GeForce Experience. Je n'ai jamais essayé d'ouvrir cette application, donc il fallait que je me 
crée un compte. Depuis l'onlet pilotes (drivers en français), on peut installer le plus récent.

Temps d'installation : 10mins

J'en profite aussi pour installer la NVIDIA App.

Une fois le pilote installé, on nous dit sur la doc qu'il faut maintenant vérifier : nvidia-smi

Nous n'avons pas plus d'informations, je fais mes propres recherches.

En demandant à un agent IA, on apprends que cette commande doit être effectuée dans l'invite de commande, 
présente dans le menu démarrer de son PC. En effectuant cette commande dans le terminal, on trouve bien 
le résultat souhaité, avec beaucoup d'informations complémentaires inutiles pour l'instant. 

étape 2 : Installation de la boîte à outils CUDA :

Cette fois-ci, le lien vers le site est beaucoup plus direct et facile à comprendre, il sufit de suivre les instruction dans la doc.

Problème personnel : Espace insuffisant sur le disque. J'y remédie en faisant vite fait le tri. 

On peut tout de même noter qu'il y avait marqué qu'il faut 10GB de libre pour pourvoir tout installer, 
c'est donc une erreur de ma part. 

Espace libre post-tri : 50 GB

On réessaye l'installation; En passant par la voie Express.

On fait le test dans l'invite de commande. Tout se passe bien. Voici ce qu'il se trouve dans la console : 

nvcc: NVIDIA (R) Cuda compiler driver

Copyright (c) 2005-2026 NVIDIA Corporation

Built on Fri_Apr_24_19:26:09_Pacific_Daylight_Time_2026

Cuda compilation tools, release 13.3, V13.3.33

Build cuda_13.3.r13.3/compiler.37862127_0

étape 3 : Installation du .NET 8 SDK. 

Sur mon PC, j'utilise la version 2022 de Visual Studio, donc si on suit ce que dit la doc, pas besoin 
d'installer le .NET depuis microsoft. Il faut donc que j'installe le .NET desktop development workload.

Je ne savais pas comment installer une development workload, j'ai donc demander à un agent IA de m'expliquer comment faire:

Dans Visual Studio 2022 :

Visual Studio Installer → cherche-le dans le menu Démarrer
Clique sur Modifier (à côté de ta version de VS)
Dans l'onglet Charges de travail, coche "Développement .NET Desktop"
Clique sur Modifier en bas à droite pour lancer l'installation

En suivant ces étapes, je me rends compte que j'avais déjà installé ce qu'il faut.

étape 4 : Installation d'une chaîne à tâches C++ : 

Se fait avec les mêmes étapes que le .NET Desktop, donc assez facile à faire, une fois qu'on sait faire.

Remarque : Depuis le site, il n'y a que très peu d'indications précises avec ce qu'il faut faire depuis Visual Studio Installer.

