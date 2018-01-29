﻿using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Indonesian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot requires permission \" Embed Links \"",
                AdminOnly = "You are not a server admin",
                PlayerNotFound = "Player {0} not found",
                ApiError = "API Error",
                UnknownItemID = "Cannot find item name or ID",
                UnknownMob = "Cannot find mob name",
                EnterIP = "Enter an IP",
                InvalidIP = "Invalid IP",
                Cooldown = "You are on cooldown for 1 mins!",
                EnableQuery = "Minecraft server does not have enable-query set in server.properties",
                ListNoServers = "This community has no servers listed",
                UnknownArg = "Unknown argument do",
                TextLimit = "Text cannot be more than 22 letters/numbers"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Bot Invite/Info/Stats/Links )",
                    "[ mc/quiz ]( Minecraft quiz :D )",
                    "[ mc/colors ]( MC color codes )",
                    "[ mc/uuid (Player) ]( Player UUID )",
                    "[ mc/ping (IP) ]( Ping a server )",
                    "[ mc/list ]( List community servers )",
                    "[ mc/wiki ]( Wiki for Items/Mobs/Enchants/Potions )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin (Player) ]( Player skin )",
                    "[ mc/names (Player) ]( MC account name history )",
                    "[ mc/status ]( Mojang status )",
                    "[ mc/get (Text) ]( Get an achievement )",
                    "[ mc/minime (Player) ]( Minify player skin )",
                    "[ mc/playing ]( People playing Minecraft )",
                    "[ mc/hypixel (Player) ]( Hypixel player stats )",
                    "[ mc/admin ]( Community admin commands )",
                    "[ mc/invite ]( Get the bot invite )"
                },
                HelpFooter = "There are some hidden commands aswell ;)",
                MultiMC = "MultiMC allows you to manage and launch multiple versions with easy forge/mods installation",
                SkinEditor = "Online Skin Editor",
                PleaseWait = "Please wait while I ping",
                ServerAdminUse = "Server admin should use",
                SkinArgs = "(Player) | head | cube | full | steal",
                StoleSkin = "Stole a skin",
                NameOnlyOne = "Player {0} only has 1 name on records",
                PlayingMinecraft = "People playing Minecraft",
                Hi = "Hi",
                BotDesc = "If you have any issue, suggestions or language translations please contact me",
                First = "First"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey, you found a secret command :D",
                Herobrine = "Always watching you...",
                Notch = "Minecraft was created by Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Blocks",
                Unknown = "Unknown",
                Player = "Player",
                Players = "Players",
                Attack = "Attack",
                Easy = "Easy",
                Hard = "Hard",
                Health = "Health",
                Height = "Height",
                Width = "Width",
            },

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Set the community language )",
                    "[ mc/addserver ]( Add a MC server to this guild list )",
                    "[ mc/delserver ]( Remove a MC server from this guild list )",
                    "[ mc/setprefix ]( Set Custom Prefix )",
                    "[ mc/resetprefix ]( Remove Custom Prefix )"
                },
                WantTranslation = "Want a language translates? Contact",
                ChangeLang = "Change Community Language",
                UseList = "Use mc/list for a list of this guilds minecraft servers",
                AddServer = "Enter a tag, ip and name",
                AddServerAdded = "Added server {0} to the guild list",
                AddServerAlready = "This server is already on the list",
                DelServerEnter = "Delete a server with",
                DelServerNone = "This server is not on the list",
                DelServerDeleted = "Removed server {0} from the guild list",
                PrefixReset = "Server prefix reset use mc/"
            }

        };
    }
}