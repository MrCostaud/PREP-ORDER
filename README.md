PREP'ORDER - Une application pour intermarché qui gère les palettes et les commandes pour des magasins.
Table des matières

    Introduction
    Fonctionnalités
    Prérequis
    Installation
    Utilisation

Introduction

PREP'ORDER est une application C# permettant de gérer des commandes et des palettes pour le stockage d'Intermarché. L'application inclut des fonctionnalités pour les utilisateurs et les administrateurs.

Fonctionnalités

    Importation de commandes à l'aide de ficher CSV
    Vue des commandes importées
    Gestion des utilisateurs de leurs rôles
    Ajout d'une nouvelle commande
    Tableau de bord des commandes
    Notification aux caristes si un stock est vide
    Liste des demandes de palettes
    Gestion du stockage en hauteur

Prérequis

Avant d'installer ce projet, assurez-vous d'avoir les éléments suivants :

    Microsoft Visual Studio
    Microsoft SQL Server Management Studio

Installation

Clonez le dépôt :
git clone https://github.com/MrCostaud/PREP-ORDER
Restaurez les dépendances et compilez le projet :
dotnet restore
dotnet build
Lancez l'application :
dotnet run

Utilisation

Lancez l'application et connectez vous avec vos identifiants.

Pour les résponsables :
Vous pouvez ajouter ou modifier un utilisateur.
Vous pouvez visualiser les commandes et leurs états (en cours/terminé)
Vous pouvez importer un fichier CSV pour ajouter une nouvelle commande.

Pour les préparateurs :
Vous pouvez choisir la zone de préparation avec la combo box et quand toute la commande est finie vous pouvez la valider et son statut passe à validé.
Si pour un certain produit la zone est vide, vous pouvez cliquer sur le bouton zone vide et ça affiche au cariste dans la colonne Problem le message erreur pour dire que la zone est vide.

Pour les caristes :
Vous avez accès au tableau de bord des racks, vous pouvez voir le stockage de tous et voir lesquels sont vides.
Vous avez également accès au demandes de remplissage de palettes fait par les préparateurs, vous pouvez choisir la palette et la remplir.

Contribution

Les contributions sont les bienvenues ! Pour contribuer :

    Forkez le projet.
    Créez une branche pour votre fonctionnalité (git checkout -b features/nomDeVotreFeature).
    Commitez vos modifications (git commit -m "Ajout d'une nouvelle fonctionnalité").
    Poussez vos modifications (git push origin features/nomDeVotreFeature).
    Ouvrez une Pull Request.

Licence

Le contenu et le code source de ce site sont la propriété exclusive d'Intermarché. Tous droits réservés.

Aucune partie de ce site, y compris le texte, les images, les fichiers, ou le code source, ne peut être reproduite, distribuée, ou utilisée à des fins commerciales sans l'autorisation écrite préalable d'Intermarché.

L'utilisation de cette application est soumise aux conditions générales définies par Intermarché. Toute tentative d'infraction aux droits de propriété intellectuelle entraînera des poursuites conformément à la législation en vigueur.

Pour toute demande concernant l'utilisation de cette application, veuillez contacter Intermarché.
