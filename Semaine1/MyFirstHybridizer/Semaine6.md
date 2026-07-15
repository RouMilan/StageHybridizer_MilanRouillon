
#### Installer Obsidian :

Mon tuteur m'a aussi conseillé d'installer Obsidian, une Open Source pour Markdown.

L'installation s'est faite sans problème, mais je ne sais pas l'utiliser? Je demande à un autre stagiaire de venir m'aider.

à faire : remettre le tab linux dans l'étape 1 et 2, 

Installer WSL : https://learn.microsoft.com/fr-fr/windows/wsl/install

Vaut mieux copier-coller les sorties plutôt que de faire des captures d'écran.

Rajouter l'installation Git pour Linux.

Nuancer le fait que l'on peut que utiliser CUDA 13.0, d'autres sont possibles aussi.

Installation WSL : Très facile à installer, il suffit d'écrire cette commande dans l'invite de commande : 

```wsl --install```

Il faut ensuite ouvrir l'application Ubuntu depuis le menu démarrer, et écrire :
```
Create a default Unix user account: Milan
Invalid username. A valid username must start with a lowercase letter or underscore, and can contain lowercase letters, digits, underscores, and dashes.
Create a default Unix user account: milan
New password:
Retype new password:
passwd: password updated successfully
usermod: no changes
Help improve Ubuntu!

Help us improve Ubuntu features and compatibility by sharing system reports with Canonical.
Reports are sent anonymously and do not contain any personal data.
For legal details, please visit: https://ubuntu.com/legal/systems-information-notice

We will save your answer to Windows and will only ask you once.

Would you like to opt-in to platform metrics collection (Y/n)? To see an example of the data collected, enter 'e'.
[Y/n/e]: y
```

#### A faire : 

- WSL2
- Indiquer les passages de la documentation 
- Savoir comment fabriquer un rapport Context7 : Repository de docs pour le LLM, pour qu'il puisse y accéder en MCP. Il faut que je fasse apprendre à Antoine.
- Ameliorer les README
- Faire tester Hybridizer par Aymen.
- Ameliorer le quickstart -> rajouter depuis le powershell.

Je remplace donc tous les exemples des photos dans la docs par des copiés collés du terminal. En effet, c'est plus pratique à modifier à un autre moment que des images.

J'ai donc ajouté quelques lignes dans la docs, avec la deuxième méthode pour tester l'installation de Hybridizer, 
que j'ai utilisée et qui a fonctionnée.

Définition Context7 : Serveur MCP, qui permet à un assistant IA de se fier uniquement aux infos disponible dans une libraire (repo git, docs , etc..)
au lieu de se fier aux données d'entrainement.

Définition MCP : en anglais, Model Context Protocol. C'est un outil qui permet aux assistants IA de communiquer avec des outils externes plus facilement.

J'ai néanmoins l'impression qu'il va falloir que j'installe une LLM sur mon PC. 

Je reconfirme avec mon agent ia, et il me fait comprendre que je peux normalement tout faire depuis mon navigateur.

étapes à suivre : 
- Va dans Customize > Connectors
- Clique sur "+" puis "Ajouter un connecteur personnalisé"
- Colle l'URL https://mcp.context7.com/mcp
- Valide, puis active le connecteur dans la conversation via le bouton "+"

On me fait ensuite comprendre qu'il est beaucoup plus simples de connecter les repos publiques (basic-samples, les docs) que les repos privés tels que celui que j'utilise pour le stage.

J'essaye tout de même de créer un Context7 pour les deux repos publics.