﻿using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class French
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot nécessite l'autorisatio \" Liens incrémentés \"",
                AdminOnly = "Vous n'êtes pas un administrateur",
                PlayerNotFound = "Joueur {0} pas trouvé",
                ApiError = "Erreur API",
                UnknownItemID = "",
                UnknownMob = "",
                EnterIP = "Entrez une adresse IP",
                InvalidIP = "",
                Cooldown = "Vous êtes en pause pendant 1 minutes!",
                EnableQuery = "Le serveur Minecraft n'a pas activé la requête dans server.properties",
                ListNoServers = "Cette communauté n'a aucun serveur répertorié",
                UnknownArg = "Argument inconnu",
                TextLimit = "Le texte ne peut pas dépasser 22 lettres/nombres"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Bot Inviter/Info/Stats/Liens )",
                    "[ mc/quiz ]( Essai de Minecraft :D )",
                    "[ mc/colors ]( Codes de couleur MC )",
                    "[ mc/uuid (Joueur) ]( Joueur UUID )",
                    "[ mc/ping (IP) ]( Faire un ping sur un serveur )",
                    "[ mc/list ]( Liste des serveurs communautaires )",
                    "[ mc/wiki ]( Wiki for Items/Mobs/Enchants/Potions )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin (Joueur) ]( Skin du joueur )",
                    "[ mc/names (Joueur) ]( Historique des nom de compte MC )",
                    "[ mc/status ]( Status des serveur de Mojange )",
                    "[ mc/get (Texte) ]( Obtenir une réussite )",
                    "[ mc/minime (Joueur) ]( Minimiser la skin du joueur )",
                    "[ mc/playing ]( Les gens qui jouent à Minecraft )",
                    "[ mc/hypixel (Player) ]( Hypixel player stats )",
                    "[ mc/admin ]( Commandes d'administration de la communauté )",
                    "[ mc/invite ]( Obtenir l'invitation de bot )"
                },
                HelpFooter = "Il y a aussi des commandes cachées ;)",
                MultiMC = "MultiMC vous permet de gérer et de lancer plusieurs versions avec une installation facile de forge / mods",
                SkinEditor = "Éditeur de peau en ligne",
                PleaseWait = "Patientez pendant que je ping",
                ServerAdminUse = "",
                SkinArgs = "(Joueur) | head | cube | full | steal",
                StoleSkin = "Roule une skin",
                NameOnlyOne = "Le joueur {0} n'a qu'un nom sur les enregistrements",
                PlayingMinecraft = "Les gens qui jouent à Minecraft",
                Hi = "salut",
                BotDesc = "Si vous avez un problème, des suggestions ou des traductions linguistiques, contactez-moi"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "",
                MinecraftClassic = "",
                Forgecraft = "",
                Bukkit = "",
                Direwolf20 = "",
                Herobrine = "",
                Entity303 = "",
                Israphel = "",
                Notch = ""
            },

            Wiki = new TWiki
            {
                Blocks = "",
                Unknown = "Inconnu",
                Player = "Joueur",
                Players = "Joueurs",
                Attack = "Attaque",
                Easy = "Facile",
                Hard = "Hard",
                Health = "Santé",
                Height = "la taille",
                Width = "Largeur",
            },

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Définir la langue de la communauté )",
                        "[ mc/addserver ]( Ajouter un serveur MC à cette liste de guilde )",
                        "[ mc/delserver ]( Supprimez un serveur MC de cette liste de guilde )",
                        "[ mc/setprefix ]( Set Custom Prefix )",
                        "[ mc/resetprefix ]( Remove Custom Prefix )"
                },
                WantTranslation = "Vous voulez une langue traduire? Contact",
                ChangeLang = "Changer la langue de la communauté",
                UseList = "Utilisez mc/list pour une liste de ces serveurs minecraft de guilde",
                AddServer = "Entrez une étiquette, un ip et un nom",
                AddServerAdded = "Serveur ajouté {0} à la liste de guilde",
                AddServerAlready = "Ce serveur est déjà sur la liste",
                DelServerEnter = "Supprimer un serveur avec",
                DelServerNone = "Ce serveur n'est pas sur la liste",
                DelServerDeleted = "Serveur supprimé {0} de la liste de guilde",
                PrefixReset = ""
            }

        };
    }
}
