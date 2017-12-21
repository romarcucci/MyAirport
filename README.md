# MyAirport.Pim - Romain Marcucci & Amarnath Sundaram

## Fonctionnement du projet

<p>L'application que nous avons d�velopp�e permet de g�rer le flux de bagages pour les a�roports. Au d�marrage du projet, deux fen�tres s'ouvrent. La premiere qui s'appelle "Form1" 
permet d'activer les webservices. Il faut pour cela cliquer sur le bouton "Create", l'�tat du webservice est alors � "created" et l'on peut ouvrir la connexion. Il suffit de cliquer 
sur le bouton "Open", l'�tat est alors � "opened".<br><br>
On peut maintenant utiliser la fen�tre "PIM". La fen�tre est compos�e de plusieurs parties. Un menu tout en haut avec les champs "Commandes" et "Etat". "Commandes" contient un champs 
"R�initialiser" qui vide tout les champs de la fen�tre lorsqu'il est activ�. Dans le champ "Etat", on peut choisir le mode de fonctionnement de la fenetre (affichage, cr�ation...). 
Ensuite nous avons deux parties appell�es "Recherche" et "Resultat", la premiere permet de lancer une recherche par code iata. Si le serveur n'est pas disponible, le webservice n'est 
pas activ� ou que le bagage n'existe pas, un message d'erreur s'affichera en bas � gauche. Autrement les informations relatives � ce bagage seront affich�es dans les champs pr�vus pour 
cela. En passant en mode cr�ation, les champs seront activ�s ainsi que le bouton cr�er. Cela permet de cr�er un bagage et de l'ajouter � la base de donn�es 
(cela provoque une exception: System.ServiceModel.EndpointNotFoundException�).
</p>

## Architecture du projet

MyAirport.Pim<br>
|-+Models<br>
| |-+AbstractDefinition<br>
| |-+Factory<br>
| |-+Natif<br>
| |-+Sql<br>
|-+Client.FormIhm<br>
| |-+PimState<br>
| |-+Program<br>
|-+Entities<br>
| |-+BagageDefinition<br>
| |-+MultipleBagageFault<br>
|-+Server.Host<br>
| |-+Program<br>
|-+ServicePim<br>
| |-+IServicePim<br>
| |-+ServicePim<br>

###Projets de demarages
ClientForm
ServerHost
## Questions du TP02
### 1. Qu�elle est l�utilit� de l�utilisation de l�instruction using lors de la cr�ation d�une instance SQLConnection ?

C'est utile pour la gestion des exceptions.

### 2. Que se passe-t-il lors de l�appel de la m�thode close sur l�objet SqlConnection ?

Cela ferme la connexion avec la base de donn�es.

### 3. Quelles sont les avantages � l�utilisation des param�tres dans les commandes SQL ?

Cela permet d'�viter les injections sql et aussi d'utiliser la m�me requ�te � chaque fois.

### 4. Pourquoi les valeurs null SQL sont retourn�es comme des objets de type DBNull et non pas null ?

Car certains types ne sont pas nullables.
