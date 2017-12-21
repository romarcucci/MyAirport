# MyAirport.Pim - Romain Marcucci & Amarnath Sundaram

## Fonctionnement du projet

<p>L'application que nous avons développée permet de gérer le flux de bagages pour les aéroports. Au démarrage du projet, deux fenêtres s'ouvrent. La premiere qui s'appelle "Form1" 
permet d'activer les webservices. Il faut pour cela cliquer sur le bouton "Create", l'état du webservice est alors à "created" et l'on peut ouvrir la connexion. Il suffit de cliquer 
sur le bouton "Open", l'état est alors à "opened".<br><br>
On peut maintenant utiliser la fenêtre "PIM". La fenêtre est composée de plusieurs parties. Un menu tout en haut avec les champs "Commandes" et "Etat". "Commandes" contient un champs 
"Réinitialiser" qui vide tout les champs de la fenêtre lorsqu'il est activé. Dans le champ "Etat", on peut choisir le mode de fonctionnement de la fenetre (affichage, création...). 
Ensuite nous avons deux parties appellées "Recherche" et "Resultat", la premiere permet de lancer une recherche par code iata. Si le serveur n'est pas disponible, le webservice n'est 
pas activé ou que le bagage n'existe pas, un message d'erreur s'affichera en bas à gauche. Autrement les informations relatives à ce bagage seront affichées dans les champs prévus pour 
cela. En passant en mode création, les champs seront activés ainsi que le bouton créer. Cela permet de créer un bagage et de l'ajouter à la base de données 
(cela provoque une exception: System.ServiceModel.EndpointNotFoundException ).
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
### 1. Qu’elle est l’utilité de l’utilisation de l’instruction using lors de la création d’une instance SQLConnection ?

C'est utile pour la gestion des exceptions.

### 2. Que se passe-t-il lors de l’appel de la méthode close sur l’objet SqlConnection ?

Cela ferme la connexion avec la base de données.

### 3. Quelles sont les avantages à l’utilisation des paramètres dans les commandes SQL ?

Cela permet d'éviter les injections sql et aussi d'utiliser la même requête à chaque fois.

### 4. Pourquoi les valeurs null SQL sont retournées comme des objets de type DBNull et non pas null ?

Car certains types ne sont pas nullables.
