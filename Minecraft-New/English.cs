﻿using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class English
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                APIError = "API Error",
                NoList = "This community has no servers listed",
                NotVoted = "You have not voted for the bot",
                PlayerNotFound = "Player not found",
                NoAttachFiles = "Bot does not have permission to Attach Files"
            },

            Misc = new TMisc
            {
                Stats = "Stats",
                Software = "Software",
                List = "List",
                Yes = "Yes",
                No = "No",
                Server = "Server",
                Status = "Status",
                Connected = "Connected",
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
                Download = "Download"
            },

            MainCommands = new TMainCommands
            {
                UserCmd = "User profile",
                VerifyCmd = "Verify your Minecraft account",
                BotCmd = "Bot information",
                ColorCmd = "Minecraft color codes",
                QuizCmd = "Minecraft quiz",
                ListCmd = "Community servers",
                UUIDCmd = "Get a players UUID",
                SkinCmd = "Get a players skin",
                NamesCmd = "Get a players name history",
                GetCmd = "Get a Minecraft achievement",
                ChangelogCmd = "Latest Minecraft version",
                GalleryCmd = "Banners and artwork",
                VersionCmd = "Version information",
                RconCmd = "Remote console for your Minecraft server",
                WikiCmd = "Full Minecraft guide",
                AdminCmd = "Discord admin commands",
                InviteCmd = "Invite the bot",
                Footer = "There are some hidden commands aswell",
                MultiMC = "allows you to manage and load diffrent Minecraft versions with easy mod installation"
            },

            Main = new TMain
            {
                HaveIssues = "If you have any issues please contact me on Discord",
                playerstats = "player stats",
                GetStats = "Get player stats from",
                PlayingInfo = "Users playing Minecraft",
                WantListed = "Want your Minecraft server listed here? use"
            },

            Gallery = new TGallery
            {
                BannerRandom = "Get a random banner",
                BannerName = "Get a banner by name",
                ArtRandom = "Get a random artwork",
                WallpaperRandom = "Get a random wallpaper"
            },

            Ping = new TPing
            {
                Java = "Ping a Minecraft server",
                PE = "Ping a pocket edition server",
                Full = "Ping a Minecraft server with player list",
                Banner = "Banner version of ping",
                EnterIP = "Enter an IP address",
                Wait = "Please wait while i ping",
                NoEnableQuery = "Server does not have enable-query set in server.properties",
                InvalidIP = "Invalid IP address",
                InvalidPort = "Invalid server port",
                OnCooldown = "You are on cooldown for 1 minute",
                NoPlayers = "No players online"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey, you found a secret command :D",
                Herobrine = "Always watching you...",
                Notch = "Minecraft was created by Notch aka Markus Persson"
            },

            Rcon = new TRcon
            {
                Title = "Remote console",
                Info = "Allows Minecraft server owners to run commands from Discord with no plugins or mods needed",
                NotSetup = "Remote console has not been setup",
                Execute = "Run console commands using",

                ConfigCmd = "View the config",
                BlacklistCmd = "Blacklist commands for owners only",
                AccessCmd = "Give other users access",
                EnableCmd = "Enable remote console",
                DisableCmd = "Disable remote console",
                FixCmd = "Attempt to fix the connection",
                ResetCmd = "Delete the remote console config",

                AccessList = "Access list",
                AccessOwner = "Full access to commands and config",
                AccessAdmin = "Access to commands that are not blacklisted",
                AccessMod = "Access to ban and kick commands only",
                CommandBlacklist = "Command blacklist",
                BlacklistInfo = "Only owners can use blacklisted commands",
                Enabled = "Remote console has been enabled",
                Disabled = "Remote console has been disabled ",
                FixAttempt = "Attempting to fix remote console connection",
                ResetConfirm = "To confirm reset please use",
                Reset = "Remote console config has been deleted"
            },

            Badges = new TBadges
            {
                Owner = "Owner of the bot",
                MobHunter = "Expert knowledge of monsters",
                Translator = "Helped translate the bot",
                Verified = "Has a verified Minecraft account",
                Voted = "Voted for the bot",
                PlayedOn = "Played on"
            },

            User = new TUser
            {
                NotVerified = "This user has no verified Minecraft account use",
                LastPlayed = "Last played;",
                Badges = "Badges",
                BadgesInfo = "View badges with",
                NoBadges = "You have no badges"
            },

            Verify = new TVerify
            {
                Title = "Minecraft account verification",
                Info = "Verify your Minecraft account for cool features and roles",
                Step1 = "Load Minecraft 1.12.2",
                Step2 = "Join this server",
                Step3 = "Type this in Discord"
            },

            AdminCommands = new TAdminCommands
            {
               AddCmd = "Add a Minecraft server to the list",
               AutopostCmd = "Auto post your Minecraft server status",
               DelCmd = "Remove a Minecraft server from the list",
               LangCmd = "Change community language",
               ResetPrefixCmd = "Remove the custom prefix",
               RoleCmd = "Create a Minecraft role for verified users",
               SetPrefixCmd = "Set a custom prefix"
            },

            Admin = new TAdmin
            {
               NotAdmin = "You are not a server admin",
               LangSet = "Community language set to",
               PrefixSet = "Custom prefix set to",
               ChooseToRemove = "Choose a number to remove a server",
               EnterName = "Enter a name for the server",
               WantToAdd = "Would you like to add a server? yes/no",
               GlobalList = "Apply here to get your Minecraft server listed publicly",
               PrefixReset = "Custom prefix removed use",
               AlreadyAdded = "This server is already listed on",
               ServerAdded = "Server has been added to",
               ServerRemoved = "Server has been removed from",
               WantTranslated = "Want a language translated? contact me on Discord"
            }
        };
    }
}