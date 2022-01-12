using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Timer;
using System.IO;

namespace MultiCS
{
    //Lawnmower BB
    class Lawnmower
    {
        private static Timer aTimer;//Canabis timer
        private static Timer bTimer;//Cocaine timer
        private static Timer cTimer;//Beat Child timer
        private static Timer dTimer;//Timer for autosave
        private static Timer eTimer;//Timer for Quints Conversion

        //SlaveHolder vars BB
        static class noU
        {
            public static Int64 bal = 10;
            public static Int64 BalQui = 0;//1 quintillion is each 1

            public static bool Abbreviation = false;//wether or not your money is abbreviated
            public static Int64 AbbNumber;//Number changed whilst abbreviation is true and are changing numbers (i.e. shop)
            public static string AbbLetter;//detects and changes for each number(k, m, b, t, q

            public static Int64 CFWins = 0;

            public static string settingsSXC;

            public static int ShopCurrentPage = 1;//Upgrade Shops page
            public static int SettingsCurrentPage = 1;//Settings Page
            public static int WeaponsCurrentPage = 1;//Weapons Shop Page

            public static Int32 lvlup;
            public static Int32 FoundChild;

            public static bool AutosellLock = true;

            public static bool autosave = false;

            public static bool EntryExit = false;
            public static string x = "r";
        }
        static class player
        {
            public static string MenuSel;//in inventory

            public static string BeatWeapon = "[none]";
        }

        //lawnmower vars BB
        static class lm
        {
            public static string LMName;
            public static bool NameReq = false;

            public static int LMLvl = 1;

            public static bool afking = false;
            public static bool autosell = false;

            public static ConsoleKey Afk = ConsoleKey.Enter;

            public static bool JuanCarloPartLock = true;//Upgrade that doubles the cap
        }

        //Canabis vars BB
        static class Canabis
        {
            public static int CanabisStorageContainers = 1;//upgrade
            public static int CanabisStorageSpace = 28;
            public static Int64 CanabisStorage = CanabisStorageContainers * CanabisStorageSpace * CanabisStorageSpace;

            public static Int64 CanabisAmount = 0;//upgrade

            public static int CanabisPlantAmount = 1;//upgrade
            public static int CanabisPlantHarvest = 1;

            public static int CanabisSellValue = 10;
            public static bool CanabisSellingMax = false;

            public static Int64 CanabisHarvested = 0;

            public static int CanabisHarvestTime = 30000;//upgrade

            public static int CanabisLuck = 1;//Upgrade
            public static int CanabisLuckMax = 50;
        }

        //Cocaine vars BB
        static class Cocaine
        {
            public static bool CocaineLock = true;

            public static int CocaineStorageContainers = 1;//upgrade
            public static int CocaineStorageSpace = 100;
            public static Int64 CocaineStorage = CocaineStorageContainers * CocaineStorageSpace * CocaineStorageSpace;

            public static Int64 CocaineAmount = 0;//upgrade

            public static int CocainePlantAmount = 1;//upgrade
            public static int CocainePlantHarvest = 1;

            public static int CocaineSellValue = 60;

            public static bool CocaineSellingMax = false;

            public static Int64 CocaineHarvested = 0;

            public static int CocaineHarvestTime = 300000;//upgrade

            public static int CocaineLuck = 2;//Upgrade
            public static int CocaineLuckMax = 100;
        }

        //Belt vars BB
        static class Child
        {
            public static bool BasementLock = true;//wether or not you have a basement

            public static bool Beating = false;

            public static int BasementStorageContainers = 1;//Cells for the children.
            public static int BasementStorageSpace = 5;
            public static Int64 BasementStorage = BasementStorageContainers * BasementStorageSpace * BasementStorageSpace;

            public static Int64 Children = 0;//how many you have(not beaten)
            public static Int64 ChildrenBeaten = 0;//how many you have beaten ready to sell

            public static Int64 ChildrenSellValue = 1000000000000;//how much children can be sold for when selling corpses

            public static bool ChildrenSellingMax = false; //wether youre storage is full when selling

            public static Int64 ChildrenSold = 0;//How many have been sold

            public static int BeatTime = 600000; //about 10m

            public static int ChildLuck = 100;//1% out of 10000
            public static int ChildLuckMax = 500;//5% out of 10000
        }

        //Weapons
        static class Weapons
        {
            public static string NoWeapon = "[none]";
            public static UInt64 NoWeaponATK = 0;


            public static string ButterKnife = "[Butter Knife]";//kitchen knife lv 5 ||tatical knife lv 15 ||katana lv 30 ||claymore lv 50 ||Hydra dildo lv 100
            public static bool hasButterKnife = true;
            public static UInt64 ButterKnifeATK = 1;

            public static string KitchenKnife = "[Kitchen Knife]";
            public static bool hasKitchenKnife = true;
            public static UInt64 KitchenKnifeATK = 1;

            public static string TacticalKnife = "[Tactical Knife]";
            public static bool hasTacticalKnife = false;
            public static UInt64 TacticalKnifeATK = 1;

            public static string Katana = "[Katana]";
            public static bool hasKatana = false;
            public static UInt64 KatanaATK = 1;

            public static string Claymore = "[Claymore]";
            public static bool hasClaymore = false;
            public static UInt64 ClaymoreATK = 1;

            public static string HydraDildo = "[Hydra D*ldo]";
            public static bool hasHydraDildo = false;
            public static UInt64 HydrawDildoATK = 1;


            public static string BlowPipe = "[Blow Pipe]";//slingshot lv 5 ||BB Gun lv 15, ||Airsoft Rifle lv 30 ||AN-94 lv 50 ||Rocket Launcher lv 100
            public static bool hasBlowPipe = true;
            public static UInt64 BlowPipeATK = 1;

            public static string Slingshot = "[Slingshot]";
            public static bool hasSlignshot = true;
            public static UInt64 SlingshotATK = 1;

            public static string BBGun = "[BB Gun]";
            public static bool hasBBGun = true;
            public static UInt64 BBGunATK = 1;

            public static string AirsoftRifle = "[Airsoft Rifle]";
            public static bool hasAirsoftRifle = true;
            public static UInt64 AirsoftRifleATK = 1;

            public static string AN94 = "[AN-94]";
            public static bool hasAN94 = true;
            public static UInt64 AN94ATK = 1;

            public static string RocketLauncher = "[Rocket Launcher]";
            public static bool hasRocketLauncher = true;
            public static UInt64 RocketLauncherATK = 1;

        }
        public struct Weapon
        {
            public string Name;
            public UInt64 ATK;
            public Weapon(string name, UInt64 atk)
            {
                Name = name;
                ATK = atk;
            }
        }

        //Timer Canabis BB
        public static void CanabisHarvestTimer()
        {
            Lawnmower goLM = new Lawnmower();

            aTimer = new Timer();
            aTimer.Interval = Canabis.CanabisHarvestTime;
            aTimer.Elapsed += HarvestCanabis;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void HarvestCanabis(Object source, System.Timers.ElapsedEventArgs e)
        {
            Lawnmower goLM = new Lawnmower();
            Random LU = new Random();

            Canabis.CanabisAmount = Canabis.CanabisAmount + (Canabis.CanabisPlantAmount * Canabis.CanabisPlantHarvest);
            Canabis.CanabisHarvested++;

            noU.lvlup = LU.Next(1, 1000);

            if (noU.lvlup <= Canabis.CanabisLuck)
            {
                lm.LMLvl++;
            }

            noU.FoundChild = LU.Next(1, 10000);

            if (noU.FoundChild <= Child.ChildLuck)
            {
                Child.Children++;
            }

            if (lm.autosell)
            {
                goLM.sell();
            }

            if (Canabis.CanabisAmount >= Canabis.CanabisStorage)
            {
                Canabis.CanabisSellingMax = true;

                aTimer.Stop();
            }

            if (lm.afking)
            {
                Console.Clear();

                if (noU.Abbreviation)
                {
                    noU.AbbNumber = noU.bal;//sets the balance to global int64

                    goLM.Abbreviation();//where its compressed if abbreviation is true

                    Console.WriteLine("$ " + noU.AbbNumber + noU.AbbLetter);//writes the compressed number and lettering
                }
                else
                {
                    Console.WriteLine("$ " + noU.bal);
                }

                Console.WriteLine("Cannabis: " + Canabis.CanabisAmount);

                if (!Cocaine.CocaineLock)
                {
                    Console.WriteLine("Cocaine: " + Cocaine.CocaineAmount);
                }

                if (!Child.BasementLock)
                {
                    Console.WriteLine("Children Unbeaten: " + Child.Children);
                    Console.WriteLine("Children Beaten: " + Child.ChildrenBeaten);
                }

                Console.WriteLine("Hold the " + Convert.ToString(lm.Afk) + " key to stop AFK'ing");
                while (Console.ReadKey().Key != lm.Afk) { }
            }
        }

        //Timer Cocaine BB
        public static void CocaineHarvestTimer()
        {
            Lawnmower goLM = new Lawnmower();

            bTimer = new Timer();
            bTimer.Interval = Cocaine.CocaineHarvestTime;
            bTimer.Elapsed += HarvestCocaine;
            bTimer.AutoReset = true;
            bTimer.Enabled = true;
        }
        private static void HarvestCocaine(Object source, System.Timers.ElapsedEventArgs e)
        {
            Lawnmower goLM = new Lawnmower();
            Random LU = new Random();

            Cocaine.CocaineAmount = Cocaine.CocaineAmount + (Cocaine.CocainePlantAmount * Cocaine.CocainePlantHarvest);
            Cocaine.CocaineHarvested++;

            noU.lvlup = LU.Next(1, 1000);

            if (noU.lvlup <= Cocaine.CocaineLuck)
            {
                lm.LMLvl++;
            }

            noU.FoundChild = LU.Next(1, 10000);

            if (noU.FoundChild <= Child.ChildLuck)
            {
                Child.Children++;
            }

            if (lm.autosell)
            {
                goLM.sell();
            }

            if (Cocaine.CocaineAmount >= Cocaine.CocaineStorage)
            {
                Cocaine.CocaineSellingMax = true;
                bTimer.Stop();
            }

            if (lm.afking)
            {
                Console.Clear();

                if (noU.Abbreviation)
                {
                    noU.AbbNumber = noU.bal;//sets the balance to global int64

                    goLM.Abbreviation();//where its compressed if abbreviation is true

                    Console.WriteLine("$ " + noU.AbbNumber + noU.AbbLetter);//writes the compressed number and lettering
                }
                else
                {
                    Console.WriteLine("$ " + noU.bal);
                }

                Console.WriteLine("Cannabis: " + Canabis.CanabisAmount);

                if (!Cocaine.CocaineLock)
                {
                    Console.WriteLine("Cocaine: " + Cocaine.CocaineAmount);
                }

                if (!Child.BasementLock)
                {
                    Console.WriteLine("Children Unbeaten: " + Child.Children);
                    Console.WriteLine("Children Beaten: " + Child.ChildrenBeaten);
                }

                Console.WriteLine("Hold the " + Convert.ToString(lm.Afk) + " key to stop AFK'ing");
                while (Console.ReadKey().Key != lm.Afk) { }
            }
        }

        //Belt Timer BB
        public static void BeatingChildrenTimer()
        {
            Lawnmower goLM = new Lawnmower();

            cTimer = new Timer();
            cTimer.Interval = Child.BeatTime;
            cTimer.Elapsed += BeatChild;
            cTimer.AutoReset = false;
            cTimer.Enabled = true;
            cTimer.Start();
        }
        private static void BeatChild(Object source, System.Timers.ElapsedEventArgs e)
        {
            Lawnmower goLM = new Lawnmower();
            Random LU = new Random();

            Child.ChildrenBeaten++;
            Child.Children--;

            Child.Beating = false;

            Console.WriteLine("Finished Beating!");

            noU.lvlup = LU.Next(1, 10000);

            if(noU.lvlup <= Child.ChildLuck)
            {
                lm.LMLvl++;
            }

            if(lm.autosell)
            {
                goLM.sell();
            }

            if(Child.Children + Child.ChildrenBeaten >= Child.BasementStorage)
            {
                Child.ChildrenSellingMax = true;
            }

            cTimer.Dispose();

            if(lm.afking)
            {
                Console.Clear();

                if (noU.Abbreviation)
                {
                    noU.AbbNumber = noU.bal;//sets the balance to global int64

                    goLM.Abbreviation();//where its compressed if abbreviation is true

                    Console.WriteLine("$ " + noU.AbbNumber + noU.AbbLetter);//writes the compressed number and lettering
                }
                else
                {
                    Console.WriteLine("$ " + noU.bal);
                }

                Console.WriteLine("Cannabis: " + Canabis.CanabisAmount);

                if (!Cocaine.CocaineLock)
                {
                    Console.WriteLine("Cocaine: " + Cocaine.CocaineAmount);
                }

                if (!Child.BasementLock)
                {
                    Console.WriteLine("Children Unbeaten: " + Child.Children);
                    Console.WriteLine("Children Beaten: " + Child.ChildrenBeaten);
                }

                Console.WriteLine("Hold the " + Convert.ToString(lm.Afk) + " key to stop AFK'ing");
                while (Console.ReadKey().Key != lm.Afk) { }
            }
        }

        //Autosave Timer BB
        public static void AutoSaveTimer()
        {
            Lawnmower goLM = new Lawnmower();

            dTimer = new Timer();
            dTimer.Interval = 300000;
            dTimer.Elapsed += AutoSave;
            dTimer.AutoReset = true;
            dTimer.Enabled = true;
        }
        private static void AutoSave(Object source, System.Timers.ElapsedEventArgs e)
        {
            Lawnmower goLM = new Lawnmower();
            Random LU = new Random();

            goLM.SAVEEXIT();
        }

        //Quints Timer BB
        public static void SetConversionTimer()
        {
            Lawnmower goLM = new Lawnmower();

            dTimer = new Timer();
            dTimer.Interval = 5000;
            dTimer.Elapsed += Conversion;
            dTimer.AutoReset = true;
            dTimer.Enabled = true;
        }
        private static void Conversion(Object source, System.Timers.ElapsedEventArgs e)
        {
            Lawnmower goLM = new Lawnmower();
            Random LU = new Random();

            int x = 0;

            if(noU.bal >= 1000000000000000000)
            {
                do
                {
                    noU.bal = noU.bal - 1000000000000000000;
                    noU.BalQui++;
                    x++;
                }
                while (noU.bal >= 1000000000000000000);
            }
        }

        //Shop costs BB
        static class shopcosts
        {
            public static string selX;//Shop selection
            public static int SXC;//shop selection number (TryPArse)
            public static bool selXChk;//Boolean to check if shop selection is to leave

            //Canabis Upgrades
            public static int CanabisStorageUP = 1;
            public static int CanabisPlantUP = 1;
            public static int CanabisHarvestUP = 1;
            public static int CanabisHarvestAmtUP = 1;
            public static int CanabisLuckUP = 1;
            //Canabis Upgrades

            //Cocaine upgrades
            public static int CocaineStorageUP = 1;
            public static int CocainePlantUP = 1;
            public static int CocaineHarvestUP = 1;
            public static int CocaineHarvestAmtUP = 1;
            public static int CocaineLuckUP = 1;
            //Cocaine upgrades

            //Children upgrades
            public static int ChildStorageUP = 1;
            public static int ChildBeatTimeUP = 1;
            public static int ChildLuckUP = 1;
            //Children upgrades


            //WeaponsShop
            public static bool WeaponShopLock = true;


        }

        //Gamble Vars BB
        static class Gamble
        {
            public static string GambleSel;

            public static Int64 Bet;//How much youre betting

            //blackjack BB
            public static string bjSel;

            public static int bjTurn = 0;

            public static int aCard1, aCard2, aCard3, aCard4, aCard5, aCard6, aCard7, aCard8, aCard9, aCard10, aCard11;//Dealer's possible cards

            public static int bCard1, bCard2, bCard3, bCard4, bCard5, bCard6, bCard7, bCard8, bCard9, bCard10, bCard11;//Your possible cards
            //blackjack EE
        }

        //SAVEPATH BB
        static class SetSavePath
        {
            public static string path;

            public static bool saveexit = true;
        }


        //====================================================================================================



        //PathSET BB
        public void SetPath()
        {
            string aPath = @"A:\Lawnmower\SAVE.txt";
            string bPath = @"B:\Lawnmower\SAVE.txt";
            string cPath = @"C:\Lawnmower\SAVE.txt";
            string dPath = @"D:\Lawnmower\SAVE.txt";
            string ePath = @"E:\Lawnmower\SAVE.txt";
            string fPath = @"F:\Lawnmower\SAVE.txt";
            string gPath = @"G:\Lawnmower\SAVE.txt";
            string hPath = @"H:\Lawnmower\SAVE.txt";
            string iPath = @"I:\Lawnmower\SAVE.txt";
            string jPath = @"J:\Lawnmower\SAVE.txt";
            string kPath = @"K:\Lawnmower\SAVE.txt";
            string lPath = @"L:\Lawnmower\SAVE.txt";
            string mPath = @"M:\Lawnmower\SAVE.txt";
            string nPath = @"N:\Lawnmower\SAVE.txt";
            string oPath = @"O:\Lawnmower\SAVE.txt";
            string pPath = @"P:\Lawnmower\SAVE.txt";
            string qPath = @"Q:\Lawnmower\SAVE.txt";
            string rPath = @"R:\Lawnmower\SAVE.txt";
            string sPath = @"S:\Lawnmower\SAVE.txt";
            string tPath = @"T:\Lawnmower\SAVE.txt";
            string uPath = @"U:\Lawnmower\SAVE.txt";
            string vPath = @"V:\Lawnmower\SAVE.txt";
            string wPath = @"W:\Lawnmower\SAVE.txt";
            string xPath = @"X:\Lawnmower\SAVE.txt";
            string yPath = @"Y:\Lawnmower\SAVE.txt";
            string zPath = @"Z:\Lawnmower\SAVE.txt";

            String[] drivePaths = { aPath, bPath, cPath, dPath, ePath, fPath, gPath, hPath, iPath, jPath, kPath, lPath, mPath, nPath, oPath, pPath, qPath, rPath, sPath, tPath, uPath, vPath, wPath, xPath, yPath, zPath };

            foreach (string path in drivePaths)
            {
                if(File.Exists(path))
                {
                    SetSavePath.path = path;
                }
            }

            Console.WriteLine("The SAVE.txt is in: " + SetSavePath.path);
            string y = Console.ReadLine();
            if (y == "y")
            {
                noU.EntryExit = true;
            }
        }
        //PathSET EE


        //SaveLOAD BB
        public void SAVELOAD()
        {
            string[] SAVE = File.ReadAllLines(SetSavePath.path);// Read each line of the file into a string array. Each element of the array is one line of the file.

            foreach (string val in SAVE)
            {
                //name
                if(val.Substring(0, val.IndexOf(':')).Equals("name", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    if(x != "")
                    {
                        lm.LMName = x;
                    }
                    else
                    {
                        lm.NameReq = true;
                    }
                }
                //lawnmower lvl
                if(val.Substring(0, val.IndexOf(':')).Equals("lmlvl", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    lm.LMLvl = Convert.ToInt16(x);
                }
                //balance
                if (val.Substring(0, val.IndexOf(':')).Equals("bal", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    noU.bal = Convert.ToInt64(x);
                }
                //bal v2
                if (val.Substring(0, val.IndexOf(':')).Equals("qui", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    noU.BalQui = Convert.ToInt64(x);
                }
                //CF Wins
                if (val.Substring(0, val.IndexOf(':')).Equals("cfwins", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    noU.CFWins = Convert.ToInt64(x);
                }
                //canabis amt
                if (val.Substring(0, val.IndexOf(':')).Equals("Can", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    Canabis.CanabisAmount = Convert.ToInt64(x);
                }
                //canabis storage
                if (val.Substring(0, val.IndexOf(':')).Equals("cansup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CanabisStorageUP = Convert.ToInt16(x);

                    Canabis.CanabisStorageContainers = shopcosts.CanabisStorageUP;
                }
                //canabis plants
                if (val.Substring(0, val.IndexOf(':')).Equals("canpup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CanabisPlantUP = Convert.ToInt16(x);

                    Canabis.CanabisPlantAmount = shopcosts.CanabisPlantUP;
                }
                //canabis harvest time
                if (val.Substring(0, val.IndexOf(':')).Equals("canhup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CanabisHarvestUP = Convert.ToInt16(x);

                    Canabis.CanabisHarvestTime = Canabis.CanabisHarvestTime - (shopcosts.CanabisHarvestUP - 1) * 500;
                }
                //canabis harvest amount
                if (val.Substring(0, val.IndexOf(':')).Equals("canhaup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CanabisHarvestAmtUP = Convert.ToInt16(x);

                    Canabis.CanabisPlantHarvest = shopcosts.CanabisHarvestAmtUP;
                }
                //canabis level up chance
                if (val.Substring(0, val.IndexOf(':')).Equals("canlup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CanabisLuckUP = Convert.ToInt16(x);

                    Canabis.CanabisLuck = shopcosts.CanabisLuckUP;
                }
                //cocaine amt
                if (val.Substring(0, val.IndexOf(':')).Equals("Coc", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    Cocaine.CocaineAmount = Convert.ToInt64(x);
                }
                //cocaine storage
                if (val.Substring(0, val.IndexOf(':')).Equals("cocsup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CocaineStorageUP = Convert.ToInt16(x);

                    Cocaine.CocaineStorageContainers = shopcosts.CocaineStorageUP;
                }
                //cocaine plants
                if (val.Substring(0, val.IndexOf(':')).Equals("cocpup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CocainePlantUP = Convert.ToInt16(x);

                    Cocaine.CocainePlantAmount = shopcosts.CocainePlantUP;
                }
                //cocaine harvest time
                if (val.Substring(0, val.IndexOf(':')).Equals("cochup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CocaineHarvestUP = Convert.ToInt16(x);

                    Cocaine.CocaineHarvestTime = Cocaine.CocaineHarvestTime - (shopcosts.CocaineHarvestUP - 1) * 1000;
                }
                //cocaine harvest amount
                if (val.Substring(0, val.IndexOf(':')).Equals("cochaup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CocaineHarvestAmtUP = Convert.ToInt16(x);

                    Cocaine.CocainePlantHarvest = shopcosts.CocaineHarvestAmtUP;
                }
                //cocaine level up chance
                if (val.Substring(0, val.IndexOf(':')).Equals("coclup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.CocaineLuckUP = Convert.ToInt16(x);

                    Cocaine.CocaineLuck = Cocaine.CocaineLuck + (shopcosts.CocaineLuckUP - 1) * 2;
                }
                //child unbeaten amt
                if (val.Substring(0, val.IndexOf(':')).Equals("ChiUnb", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    Child.Children = Convert.ToInt64(x);
                }
                //child beaten amt
                if (val.Substring(0, val.IndexOf(':')).Equals("ChiBea", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    Child.ChildrenBeaten = Convert.ToInt64(x);
                }
                //child storage
                if (val.Substring(0, val.IndexOf(':')).Equals("chisup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.ChildStorageUP = Convert.ToInt16(x);

                    Child.BasementStorageContainers = shopcosts.ChildStorageUP;
                }
                //child beat time
                if (val.Substring(0, val.IndexOf(':')).Equals("chibtup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.ChildBeatTimeUP = Convert.ToInt16(x);

                    Child.BeatTime = Child.BeatTime - (shopcosts.ChildBeatTimeUP - 1) * 3000;
                }
                //child level up chance
                if (val.Substring(0, val.IndexOf(':')).Equals("chilup", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    shopcosts.ChildLuckUP = Convert.ToInt16(x);

                    Child.ChildLuck = Child.ChildLuck + (shopcosts.ChildLuckUP - 1) * 10;
                }
                //cocaine lock
                if (val.Substring(0, val.IndexOf(':')).Equals("cocloc", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    if(Convert.ToInt16(x) == 0)
                    {
                        Cocaine.CocaineLock = false;
                    }
                }
                //lawnmower juan carlos lock
                if (val.Substring(0, val.IndexOf(':')).Equals("lawjuacarloc", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    if (Convert.ToInt16(x) == 0)
                    {
                        lm.JuanCarloPartLock = false;

                        Canabis.CanabisLuckMax = Canabis.CanabisLuckMax * 2;
                        Cocaine.CocaineLuckMax = Cocaine.CocaineLuckMax * 2;
                    }
                }
                //basement lock
                if (val.Substring(0, val.IndexOf(':')).Equals("basloc", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    if (Convert.ToInt16(x) == 0)
                    {
                        Child.BasementLock = false;
                    }
                }
                //autosell lock
                if (val.Substring(0, val.IndexOf(':')).Equals("autselloc", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    if (Convert.ToInt16(x) == 0)
                    {
                        noU.AutosellLock = false;
                    }
                }
                //Weapon License Lock
                if(val.Substring(0, val.IndexOf(':')).Equals("WeaShoLoc", StringComparison.InvariantCultureIgnoreCase))
                {
                    string x = val.Substring(val.IndexOf(':') + 2);

                    if (Convert.ToInt16(x) == 0)
                    {
                        shopcosts.WeaponShopLock = false;
                    }
                }
            }
        }
        //SaveLOAD EE


        //SaveEXIT BB
        public void SAVEEXIT()
        {
            File.Delete(SetSavePath.path);

            //Basics

            string name = "Name: " + lm.LMName;
            string lmlvl = "LMlvl: " + lm.LMLvl;
            string bal = "Bal: " + noU.bal;
            string qui = "Qui: " + noU.BalQui;
            string cfwins = "CFWins: " + noU.CFWins;
            //upgrades

            //Canabis upgrades
            string can = "Can: " + Canabis.CanabisAmount;
            string cas = "CanSUP: " + shopcosts.CanabisStorageUP;
            string cap = "CanPUP: " + shopcosts.CanabisPlantUP;
            string cah = "CanHUP: " + shopcosts.CanabisHarvestUP;
            string caha = "CanHAUP: " + shopcosts.CanabisHarvestAmtUP;
            string cal = "CanLUP: " + shopcosts.CanabisLuckUP;
            //Cocaine upgrades
            string coc = "Coc: " + Cocaine.CocaineAmount;
            string cos = "CocSUP: " + shopcosts.CocaineStorageUP;
            string cop = "CocPUP: " + shopcosts.CocainePlantUP;
            string coh = "CocHUP: " + shopcosts.CocaineHarvestUP;
            string coha = "CocHAUP: " + shopcosts.CocaineHarvestAmtUP;
            string col = "CocLUP: " + shopcosts.CocaineLuckUP;
            //Child upgrades
            string chi = "ChiUnb: " + Child.Children;
            string chb = "ChiBea: " + Child.ChildrenBeaten;
            string chs = "ChiSUP: " + shopcosts.ChildStorageUP;
            string chbt = "ChiBTUP: " + shopcosts.ChildBeatTimeUP;
            string chl = "ChiLUP: " + shopcosts.ChildLuckUP;



            //locks
            string colo, lmpalo, balo, auselo, weshlo;
            //Cocaine
            if(!Cocaine.CocaineLock)
            {
                colo = "CocLoc: 0";
            }
            else
            {
                colo = "CocLoc: 1";
            }
            //Lawnmower Juan Carlos
            if (!lm.JuanCarloPartLock)
            {
                lmpalo = "LawJuaCarLoc: 0";
            }
            else
            {
                lmpalo = "LawJuaCarLoc: 1";
            }
            //Basement
            if(!Child.BasementLock)
            {
                balo = "BasLoc: 0";
            }
            else
            {
                balo = "BasLoc: 1";
            }
            //Autosell
            if(!noU.AutosellLock)
            {
                auselo = "AutSelLoc: 0";
            }
            else
            {
                auselo = "AutSelLoc: 1";
            }
            //Weapon License
            if(!shopcosts.WeaponShopLock)
            {
                weshlo = "WeaShoLoc: 0";
            }
            else
            {
                weshlo = "WeaShoLoc: 1";
            }

            string[] vars = { name, lmlvl, bal, qui, cfwins, can, cas, cap, cah, caha, cal, coc, cos, cop, coh, coha, col, chi, chb, chs, chbt, chl, colo, lmpalo, balo, auselo, weshlo };

            File.WriteAllLines(SetSavePath.path, vars);;

            if(SetSavePath.saveexit)
            {
                noU.x = "a";

                Console.WriteLine("Successfully Saved!");
                Console.ReadLine();
            }
        }
        //SaveEXIT EE


        //Abbreviation Func BB
        public void Abbreviation()
        {
            if(noU.AbbNumber < 1000 && noU.AbbNumber > 0)
            {
                noU.AbbLetter = "";
            }

            if (noU.AbbNumber >= 1000 && noU.AbbNumber < 1000000)
            {
                noU.AbbNumber = noU.AbbNumber / 1000;
                noU.AbbLetter = " k";
            }

            if (noU.AbbNumber >= 1000000 && noU.AbbNumber < 1000000000)
            {
                noU.AbbNumber = noU.AbbNumber / 1000000;
                noU.AbbLetter = " m";
            }

            if (noU.AbbNumber >= 1000000000 && noU.AbbNumber < 1000000000000)
            {
                noU.AbbNumber = noU.AbbNumber / 1000000000;
                noU.AbbLetter = " b";
            }

            if (noU.AbbNumber >= 1000000000000 && noU.AbbNumber < 1000000000000000)
            {
                noU.AbbNumber = noU.AbbNumber / 1000000000000;
                noU.AbbLetter = " t";
            }

            if (noU.AbbNumber >= 1000000000000000 && noU.AbbNumber < 1000000000000000000)
            {
                noU.AbbNumber = noU.AbbNumber / 1000000000000000;
                noU.AbbLetter = " q";
            }

            if (noU.AbbNumber >= 1000000000000000000 && noU.AbbNumber < 9223372036854775807)
            {
                noU.AbbNumber = noU.AbbNumber / 1000000000000000000;
                noU.AbbLetter = " Q";
            }
        }//can abbreviate any number usually $
        //Abbreviation Func EE


        //Welcome void BB
        public void Welcome()
        {
            Lawnmower goLM = new Lawnmower();

            Console.WriteLine("Welcome");
            Console.WriteLine();

            goLM.SetPath();

            if(!noU.EntryExit)
            {
                goLM.SAVELOAD();

                if (lm.NameReq)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome!");
                    Console.WriteLine("I am your Artificially Intelligent Lawnmower!");
                    Console.WriteLine();

                    Console.WriteLine("Enter what you wish to call me: ");
                    lm.LMName = Console.ReadLine();

                    if (lm.LMName == "")
                    {
                        goLM.Welcome();
                    }

                    Console.WriteLine("My name is " + lm.LMName);
                    Console.WriteLine(" I will be your Lawnmower slave and mow down all your cannabis plants for you master!");
                }
                else
                {
                    Console.WriteLine("Loaded previous save file!");
                }

                CanabisHarvestTimer();
                aTimer.Start();
                SetConversionTimer();

                if (!Cocaine.CocaineLock)
                {
                    CocaineHarvestTimer();
                    bTimer.Start();
                    Console.WriteLine("Harvesting Cocaine");
                }

                if (!Child.BasementLock)
                {
                    Console.WriteLine("You can beat children!");
                }

                AutoSaveTimer();
                Console.ReadLine();
                goLM.IdleRedirect();
            }
        }
        //WElcome void EE

        //idle gateway real time updates BB
        public void IdleRedirect()
        {
            Lawnmower goLM = new Lawnmower();

            Console.Clear();

            noU.x = "r";

            do
            {
                goLM.Idle();
            }
            while (noU.x != "a");
        }
        //idle gateway real time updates EE

        //Idle BB
        public void Idle()
        {
            Console.Clear();
            Lawnmower goLM = new Lawnmower();

            Canabis.CanabisStorage = Canabis.CanabisStorageContainers * Canabis.CanabisStorageSpace * Canabis.CanabisStorageSpace;
            lm.afking = false;

            Console.WriteLine("Idle");
            Console.WriteLine();

            Console.WriteLine("Lawnmower Level: " + lm.LMLvl);

            if(noU.Abbreviation)
            {
                noU.AbbNumber = noU.bal;//sets the balance to global int64

                goLM.Abbreviation();//where its compressed if abbreviation is true

                Console.WriteLine("$ " + noU.AbbNumber + noU.AbbLetter);//writes the compressed number and lettering
            }
            else
            {
                Console.WriteLine("$ " + noU.bal);
            }
            Console.WriteLine();

            Console.WriteLine("Cannabis: " + Canabis.CanabisAmount);

            if(!Cocaine.CocaineLock)
            {
                Cocaine.CocaineStorage = Cocaine.CocaineStorageContainers * Cocaine.CocaineStorageSpace * Cocaine.CocaineStorageSpace;
                Console.WriteLine("Cocaine: " + Cocaine.CocaineAmount);
            }

            if(!Child.BasementLock)
            {
                Child.BasementStorage = Child.BasementStorageContainers * Child.BasementStorageSpace * Child.BasementStorageSpace;
                Console.WriteLine("Children Unbeaten: " + Child.Children);
                Console.WriteLine("Children Beaten: " + Child.ChildrenBeaten);

                if(Child.Beating)
                {
                    Console.WriteLine("Child Beating in progress :D");
                }
                else
                {
                    Console.WriteLine("No Child is currently being beaten. ;=;");
                }
            }

            string select = Console.ReadLine();

            if(select.Equals("afk", StringComparison.InvariantCultureIgnoreCase))
            {
                lm.afking = true;

                Console.WriteLine("Enter a key to stop Afking Later!");
                lm.Afk = Console.ReadKey().Key;

                noU.x = "r";

                goLM.AFK();
            }
            else if (select.Equals("lawnmower", StringComparison.InvariantCultureIgnoreCase) || select.Equals("lm", StringComparison.InvariantCultureIgnoreCase))
            {
                goLM.LMStats();
            }
            else if (select.Equals("sell", StringComparison.InvariantCultureIgnoreCase) || select.Equals("s", StringComparison.InvariantCultureIgnoreCase))
            {

                goLM.sell();
            }
            else if(select.Equals("shop", StringComparison.InvariantCultureIgnoreCase) || select.Equals("upgrade", StringComparison.InvariantCultureIgnoreCase) || select.Equals("upgrade shop", StringComparison.InvariantCultureIgnoreCase) || select.Equals("upgrades", StringComparison.InvariantCultureIgnoreCase))
            {
                do
                {
                    if(noU.ShopCurrentPage == 1)
                    {
                        goLM.UpgradeShop();
                    }
                    else if(noU.ShopCurrentPage == 2)
                    {
                        goLM.UpgradeShop2();
                    }
                }
                while(shopcosts.SXC != 0);
            }
            else if (select.Equals("save", StringComparison.InvariantCultureIgnoreCase))
            {
                if(!SetSavePath.saveexit)
                {
                    SetSavePath.saveexit = true;
                }

                goLM.SAVEEXIT();
            }
            else if (select.Equals("beat", StringComparison.InvariantCultureIgnoreCase))
            {
                if(!Child.BasementLock)
                {
                    if (!Child.Beating)
                    {
                        if (Child.Children >= 1)
                        {
                            BeatingChildrenTimer();
                            Child.Beating = true;
                        }
                        else
                        {
                            Console.WriteLine("You have no children to beat! ;=;");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are already beating a child! xD");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You can not do that yet!");
                    Console.ReadLine();
                }
            }
            else if(select.Equals("gamble", StringComparison.InvariantCultureIgnoreCase))
            {
                do
                {
                    goLM.GambleSel();
                }
                while(Convert.ToInt16(Gamble.GambleSel) != 0);
            }
            else if(select.Equals("settings", StringComparison.InvariantCultureIgnoreCase))
            {
                do
                {
                    goLM.Settings();
                }
                while (noU.settingsSXC != "0");
            }
            else if(select.Equals("weapon", StringComparison.InvariantCultureIgnoreCase) || select.Equals("weapons", StringComparison.InvariantCultureIgnoreCase))
            {
                do
                {
                    goLM.WeaponShop();
                }
                while (shopcosts.selX != "0");
            }
            else if(select.Equals("inventory", StringComparison.InvariantCultureIgnoreCase) || select.Equals("inv", StringComparison.InvariantCultureIgnoreCase))
            {
                do
                {
                    goLM.Inventory();
                }
                while (player.MenuSel != "0");
            }
            else if(select.Equals("window", StringComparison.InvariantCultureIgnoreCase))
            {

            }
            else
            {

            }
        }
        //Idle EE

        //afk BB
        public void AFK()
        {
            Lawnmower goLM = new Lawnmower();

            Console.Clear();

            Console.WriteLine("Idle - AFK");
            Console.WriteLine();

            if(noU.Abbreviation)
            {
                noU.AbbNumber = noU.bal;//sets the balance to global int64

                goLM.Abbreviation();//where its compressed if abbreviation is true

                Console.WriteLine("$ " + noU.AbbNumber + noU.AbbLetter);//writes the compressed number and lettering
            }
            else
            {
                Console.WriteLine("$ " + noU.bal);
            }

            Console.WriteLine("Cannabis: " + Canabis.CanabisAmount);

            if(!Cocaine.CocaineLock)
            {
                Console.WriteLine("Cocaine: " + Cocaine.CocaineAmount);
            }

            if (!Child.BasementLock)
            {
                Console.WriteLine("Children Unbeaten: " + Child.Children);
                Console.WriteLine("Children Beaten: " + Child.ChildrenBeaten);
            }

            Console.WriteLine("Hold the " + Convert.ToString(lm.Afk) + " key to stop AFK'ing");
            while (Console.ReadKey().Key != lm.Afk) { }
        }
        //afk EE

        //Lawnmower stats BB
        public void LMStats()
        {
            Console.Clear();
            Lawnmower goLM = new Lawnmower();

            Console.WriteLine("Stats");
            Console.WriteLine();

            Console.WriteLine("Lawnmower name: " + lm.LMName);
            Console.WriteLine("Lawnmower level: " + lm.LMLvl);
            Console.WriteLine();

            Console.WriteLine("Canabis Harvested: " + Canabis.CanabisHarvested);
            Console.WriteLine("Canabis Total Storage: " + Canabis.CanabisStorage);
            Console.WriteLine("Canabis Storage Containers: " + Canabis.CanabisStorageContainers);
            Console.WriteLine("Canabis Plants Amount: " + Canabis.CanabisPlantAmount);
            Console.WriteLine("Canabis Amount per Harvest: " + Canabis.CanabisPlantHarvest);
            Console.WriteLine("Canabis Harvest Time: " + Canabis.CanabisHarvestTime/1000 + " seconds");
            Console.WriteLine("Canabis Level UP: %" + Canabis.CanabisLuck/10);
            Console.WriteLine();

            if(!Cocaine.CocaineLock)
            {
                Console.WriteLine("Cocaine Harvested: " + Cocaine.CocaineHarvested);
                Console.WriteLine("Cocaine Total Storage: " + Cocaine.CocaineStorage);
                Console.WriteLine("Cocaine Storage Containers: " + Cocaine.CocaineStorageContainers);
                Console.WriteLine("Cocaine Plants Amount: " + Cocaine.CocainePlantAmount);
                Console.WriteLine("Cocaine Amount per Harvest: " + Cocaine.CocainePlantHarvest);
                Console.WriteLine("Cocaine Harvest Time: " + Cocaine.CocaineHarvestTime/1000 + " seconds");
                Console.WriteLine("Cocaine Level UP: %" + Cocaine.CocaineLuck/10);
                Console.WriteLine();
            }

            if(!Child.BasementLock)
            {
                Console.WriteLine("Children Total Cells: " + Child.BasementStorageContainers);
                Console.WriteLine("Children Beat Time: " + Child.BeatTime/1000 + " seconds");
                Console.WriteLine("Child Level UP: %" + Child.ChildLuck/100);
            }

            Console.ReadLine();

            goLM.Idle();
        }
        //Lawnmower stats EE

        //sell func BB
        public void sell()
        {
            Lawnmower goLM = new Lawnmower();

            if(Canabis.CanabisSellingMax)
            {
                noU.bal = Convert.ToInt64(noU.bal + (2 * ((0.75 + (0.25 * lm.LMLvl)) * (Canabis.CanabisAmount * Canabis.CanabisSellValue * Canabis.CanabisPlantHarvest))));

                Canabis.CanabisSellingMax = false;
                aTimer.Start();
            }
            else
            {
                noU.bal = Convert.ToInt64(noU.bal + ((0.75 + (0.25 * lm.LMLvl)) * (Canabis.CanabisAmount * Canabis.CanabisSellValue * Canabis.CanabisPlantHarvest)));
            }

            Canabis.CanabisAmount = 0;

            if(!Cocaine.CocaineLock)
            {
                if(Cocaine.CocaineSellingMax)
                {
                    noU.bal = Convert.ToInt64(noU.bal + (2 * ((0.75 + (0.25 * lm.LMLvl)) * (Cocaine.CocaineAmount * Cocaine.CocaineSellValue * Cocaine.CocainePlantHarvest))));

                    Cocaine.CocaineSellingMax = false;
                    bTimer.Start();
                }
                else
                {
                    noU.bal = Convert.ToInt64(noU.bal + ((0.75 + (0.25 * lm.LMLvl)) * (Cocaine.CocaineAmount * Cocaine.CocaineSellValue * Cocaine.CocainePlantHarvest)));
                }

                Cocaine.CocaineAmount = 0;
            }

            if(!Child.BasementLock)
            {
                if(Child.ChildrenSellingMax)
                {
                    noU.bal = Convert.ToInt64(noU.bal + (2 * ((0.75 + (0.25 * lm.LMLvl)) * (Child.ChildrenBeaten * Child.ChildrenSellValue))));

                    Child.ChildrenSellingMax = false;
                }
                else
                {
                    noU.bal = Convert.ToInt64(noU.bal + ((0.75 + (0.25 * lm.LMLvl)) * (Child.ChildrenBeaten * Child.ChildrenSellValue)));
                }

                Child.ChildrenBeaten = 0;
            }
        }
        //sell func EE

        //Upgrade shop BB
        public void UpgradeShop()//first page
        {
            Lawnmower goLM = new Lawnmower();

            Console.Clear();

            Int64 AutosellUnlock = 10000000;
            Int64 CocaineUnlock = 50000000;
            Int64 lmPart = 10000000000;


            double basenum = 1.3788;

            double aSUP;

            Convert.ToInt64(Math.Ceiling(aSUP = Math.Pow(basenum, shopcosts.CanabisStorageUP)));//canabis upgrades
            double aPUP = Math.Pow(basenum, shopcosts.CanabisPlantUP);
            double aHUP = Math.Pow(basenum, shopcosts.CanabisHarvestUP);
            double aHAUP = Math.Pow(basenum, shopcosts.CanabisHarvestAmtUP);
            double aLUP = Math.Pow(basenum, shopcosts.CanabisLuckUP);

            double bSUP = Math.Pow(basenum, shopcosts.CocaineStorageUP);//Cocaine Upgrades
            double bPUP = Math.Pow(basenum, shopcosts.CocainePlantUP);
            double bHUP = Math.Pow(basenum, shopcosts.CocaineHarvestUP);
            double bHAUP = Math.Pow(basenum, shopcosts.CocaineHarvestAmtUP);
            double bLUP = Math.Pow(basenum, shopcosts.CocaineLuckUP);

            Console.WriteLine("Upgrade Shop");
            Console.WriteLine("Page 1.");
            Console.WriteLine();

            Console.WriteLine("Welcome to the Upgrades Shop!");

            Console.WriteLine("");

            if (noU.Abbreviation)
            {
                noU.AbbNumber = noU.bal;//sets the balance to global int64

                goLM.Abbreviation();//where its compressed if abbreviation is true

                Console.WriteLine("$ " + noU.AbbNumber + noU.AbbLetter);//writes the compressed number and lettering
            }
            else
            {
                Console.WriteLine("$ " + noU.bal);
            }

            Console.WriteLine();

            Console.WriteLine(">. Next Page");

            Console.WriteLine("0. Leave Shop");

            if(noU.Abbreviation)
            {
                noU.AbbNumber = Convert.ToInt64(aSUP);

                goLM.Abbreviation();

                Console.WriteLine("1. Canabis Storage Containers: " + shopcosts.CanabisStorageUP + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
            }
            else
            {
                Console.WriteLine("1. Canabis Storage Containers: " + shopcosts.CanabisStorageUP + " Cost: $ " + Convert.ToInt64(aSUP));
            }

            if (noU.Abbreviation)
            {
                noU.AbbNumber = Convert.ToInt64(aPUP);

                goLM.Abbreviation();

                Console.WriteLine("2. Canabis Plants: " + shopcosts.CanabisPlantUP + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
            }
            else
            {
                Console.WriteLine("2. Canabis Plants: " + shopcosts.CanabisPlantUP + " Cost: $ " + Convert.ToInt64(aPUP));
            }

            if(noU.Abbreviation)
            {
                noU.AbbNumber = Convert.ToInt64(aHUP);

                goLM.Abbreviation();

                Console.WriteLine("3. Canabis Harvest Time: " + Convert.ToDouble(Canabis.CanabisHarvestTime / 1000) + " sec. Cost: $ " + noU.AbbNumber + noU.AbbLetter);
            }
            else
            {
                Console.WriteLine("3. Canabis Harvest Time: " + Convert.ToDouble(Canabis.CanabisHarvestTime / 1000) + " sec. Cost: $ " + Convert.ToInt64(aHUP));
            }

            if(noU.Abbreviation)
            {
                noU.AbbNumber = Convert.ToInt64(aHAUP);

                goLM.Abbreviation();

                Console.WriteLine("4. Canabis Harvest Amount: " + shopcosts.CanabisHarvestAmtUP + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
            }
            else
            {
                Console.WriteLine("4. Canabis Harvest Amount: " + shopcosts.CanabisHarvestAmtUP + " Cost: $ " + Convert.ToInt64(aHAUP));
            }

            if(noU.Abbreviation)
            {
                noU.AbbNumber = Convert.ToInt64(aLUP);

                goLM.Abbreviation();

                Console.WriteLine("5. Canabis Level Up Chance: " + Convert.ToDouble(Canabis.CanabisLuck / 10) + "%" + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
            }
            else
            {
                Console.WriteLine("5. Canabis Level Up Chance: " + Convert.ToDouble(Canabis.CanabisLuck / 10) + "%" + " Cost: $ " + Convert.ToInt64(aLUP));
            }


            if (!Cocaine.CocaineLock)
            {
                if(noU.Abbreviation)
                {
                    noU.AbbNumber = Convert.ToInt64(bSUP);

                    goLM.Abbreviation();

                    Console.WriteLine("6. Cocaine Storage Containers: " + shopcosts.CocaineStorageUP + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("6. Cocaine Storage Containers: " + shopcosts.CocaineStorageUP + " Cost: $ " + Convert.ToInt64(bSUP));
                }

                if(noU.Abbreviation)
                {
                    noU.AbbNumber = Convert.ToInt64(bPUP);

                    goLM.Abbreviation();

                    Console.WriteLine("7. Cocaine Plants: " + shopcosts.CocainePlantUP + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("7. Cocaine Plants: " + shopcosts.CocainePlantUP + " Cost: $ " + Convert.ToInt64(bPUP));
                }

                if(noU.Abbreviation)
                {
                    noU.AbbNumber = Convert.ToInt64(bHUP);

                    goLM.Abbreviation();

                    Console.WriteLine("8. Cocaine Harvest Time: " + Convert.ToDouble(Cocaine.CocaineHarvestTime / 1000) + " sec. Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("8. Cocaine Harvest Time: " + Convert.ToDouble(Cocaine.CocaineHarvestTime / 1000) + " sec. Cost: $ " + Convert.ToInt64(bHUP));
                }

                if(noU.Abbreviation)
                {
                    noU.AbbNumber = Convert.ToInt64(bHAUP);

                    goLM.Abbreviation();

                    Console.WriteLine("9. Cocaine Harvest Amount: " + shopcosts.CocaineHarvestAmtUP + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("9. Cocaine Harvest Amount: " + shopcosts.CocaineHarvestAmtUP + " Cost: $ " + Convert.ToInt64(bHAUP));
                }

                if(noU.Abbreviation)
                {
                    noU.AbbNumber = Convert.ToInt64(bLUP);

                    goLM.Abbreviation();

                    Console.WriteLine("10. Cocaine Level Up Chance: " + Convert.ToDouble(Cocaine.CocaineLuck / 10) + "%" + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("10. Cocaine Level Up Chance: " + Convert.ToDouble(Cocaine.CocaineLuck / 10) + "%" + " Cost: $ " + Convert.ToInt64(bLUP));
                }
            }

            if(lm.JuanCarloPartLock)
            {
                if(noU.Abbreviation)
                {
                    noU.AbbNumber = lmPart;

                    goLM.Abbreviation();

                    Console.WriteLine("96. Unlock Juan Carlo Lawnmower Engine. Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("96. Unlock Juan Carlo Lawnmower Engine. Cost: $ " + lmPart);
                }
            }

            if(noU.AutosellLock)
            {
                if(noU.Abbreviation)
                {
                    noU.AbbNumber = AutosellUnlock;

                    goLM.Abbreviation();

                    Console.WriteLine("97. Unlock Autosell. Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("97. Unlock Autosell. Cost: $ " + AutosellUnlock);
                }
            }

            if (Cocaine.CocaineLock)
            {
                if(noU.Abbreviation)
                {
                    noU.AbbNumber = CocaineUnlock;

                    goLM.Abbreviation();

                    Console.WriteLine("98. Unlock Cocaine. Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("98. Unlock Cocaine. Cost: $ " + CocaineUnlock);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Which would you like to upgrade?");
            Console.WriteLine("Choose a number: ");

            shopcosts.selX = Console.ReadLine();

            shopcosts.selXChk = Int32.TryParse(shopcosts.selX, out shopcosts.SXC);//tries to parse input


            if(shopcosts.selX == ">")
            {
                noU.ShopCurrentPage++;
                shopcosts.SXC = 999999999;
            }
            else if (shopcosts.selX == "96")
            {
                if(lm.JuanCarloPartLock)
                {
                    if(lmPart <= noU.bal)
                    {
                        lm.JuanCarloPartLock = false;

                        noU.bal = noU.bal - lmPart;

                        Canabis.CanabisLuckMax = Canabis.CanabisLuckMax * 2;
                        Cocaine.CocaineLuckMax = Cocaine.CocaineLuckMax * 2;
                        Child.ChildLuckMax = Child.ChildLuckMax * 2;
                    }
                }
            }
            else if (shopcosts.selX == "97")
            {
                if(noU.AutosellLock)
                {
                    if (AutosellUnlock <= noU.bal)
                    {
                        noU.AutosellLock = false;

                        noU.bal = noU.bal - AutosellUnlock;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
            }
            else if (shopcosts.selX == "98")
            {
                if (Cocaine.CocaineLock)
                {
                    if (CocaineUnlock <= noU.bal)
                    {
                        Cocaine.CocaineLock = false;

                        noU.bal = noU.bal - CocaineUnlock;

                        CocaineHarvestTimer();
                        bTimer.Start();
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "1")
            {
                if (Convert.ToInt64(aSUP) <= noU.bal)
                {
                    shopcosts.CanabisStorageUP++;
                    Canabis.CanabisStorageContainers = shopcosts.CanabisStorageUP;

                    Canabis.CanabisStorage = Canabis.CanabisStorageContainers * Canabis.CanabisStorageSpace;

                    noU.bal = noU.bal - Convert.ToInt64(aSUP);
                }
                else
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "2")
            {
                if (Convert.ToInt64(aPUP) <= noU.bal)
                {
                    shopcosts.CanabisPlantUP++;
                    Canabis.CanabisPlantAmount = shopcosts.CanabisPlantUP;

                    noU.bal = noU.bal - Convert.ToInt64(aPUP);
                }
                else
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "3")
            {
                if (Convert.ToInt64(aHUP) <= noU.bal)
                {
                    if (Canabis.CanabisHarvestTime > 5000)
                    {
                        shopcosts.CanabisHarvestUP++;
                        noU.bal = noU.bal - Convert.ToInt64(aHUP);

                        Canabis.CanabisHarvestTime = Canabis.CanabisHarvestTime - 500;
                        aTimer.Interval = Canabis.CanabisHarvestTime;
                    }
                    else
                    {
                        Console.WriteLine("Harvest Speed is maxed");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.ReadLine();
                }

            }
            else if (shopcosts.selX == "4")
            {
                if (Convert.ToInt64(aHAUP) <= noU.bal)
                {
                    shopcosts.CanabisHarvestAmtUP++;
                    Canabis.CanabisPlantHarvest = shopcosts.CanabisHarvestAmtUP;

                    noU.bal = noU.bal - Convert.ToInt64(aHAUP);
                }
                else
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "5")
            {
                if(Canabis.CanabisLuck < Canabis.CanabisLuckMax)
                {
                    if (Convert.ToInt64(aLUP) <= noU.bal)
                    {
                        shopcosts.CanabisLuckUP++;

                        noU.bal = noU.bal - Convert.ToInt64(aLUP);

                        Canabis.CanabisLuck = Canabis.CanabisLuck + 1;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Leveling Up Luck is maxed!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "6")
            {
                if (!Cocaine.CocaineLock)
                {
                    if (Convert.ToInt64(bSUP) <= noU.bal)
                    {
                        shopcosts.CocaineStorageUP++;
                        Cocaine.CocaineStorageContainers = shopcosts.CocaineStorageUP;

                        Cocaine.CocaineStorage = Cocaine.CocaineStorageContainers * Cocaine.CocaineStorageSpace;

                        noU.bal = noU.bal - Convert.ToInt64(bSUP);
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Selection!");
                    Console.ReadLine();
                }

            }
            else if (shopcosts.selX == "7")
            {
                if (!Cocaine.CocaineLock)
                {
                    if (Convert.ToInt64(bPUP) <= noU.bal)
                    {
                        shopcosts.CocainePlantUP++;
                        Cocaine.CocainePlantAmount = shopcosts.CocainePlantUP;

                        noU.bal = noU.bal - Convert.ToInt64(bPUP);
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Selection!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "8")
            {
                if (!Cocaine.CocaineLock)
                {
                    if (Convert.ToInt64(bHUP) <= noU.bal)
                    {
                        if (Cocaine.CocaineHarvestTime > 10000)
                        {
                            shopcosts.CocaineHarvestUP++;
                            noU.bal = noU.bal - Convert.ToInt64(bHUP);

                            Cocaine.CocaineHarvestTime = Cocaine.CocaineHarvestTime - 1000;
                            bTimer.Interval = Cocaine.CocaineHarvestTime;
                        }
                        else
                        {
                            Console.WriteLine("Harvest Speed is maxed");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Selection!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "9")
            {
                if (!Cocaine.CocaineLock)
                {
                    if (Convert.ToInt64(bHAUP) <= noU.bal)
                    {
                        shopcosts.CocaineHarvestAmtUP++;
                        Cocaine.CocainePlantHarvest = shopcosts.CocaineHarvestAmtUP;

                        noU.bal = noU.bal - Convert.ToInt64(bHAUP);
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Selection!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "10")
            {
                if (!Cocaine.CocaineLock)
                {
                    if (Convert.ToInt64(bLUP) <= noU.bal)
                    {
                        if (Cocaine.CocaineLuck < Cocaine.CocaineLuckMax)
                        {
                            shopcosts.CocaineLuckUP++;
                            Cocaine.CocaineLuck = Cocaine.CocaineLuck + 2;

                            noU.bal = noU.bal - Convert.ToInt64(bLUP);
                        }
                        else
                        {
                            Console.WriteLine("Leveling Up Luck is maxed!");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Selection!");
                    Console.ReadLine();
                }
            }
            else if (shopcosts.selX == "0")
            {
                Console.WriteLine("Thank you for shopping at walmart!");
                Console.ReadLine();
            }
            else if (!shopcosts.selXChk)//if input was not an option it gets sent to do-while and reenters shop
            {
                shopcosts.SXC = 999999999;
            }
            else
            {
                Console.WriteLine("Invalid Selection!");
                Console.ReadLine();
            }
        }

        public void UpgradeShop2()
        {
            Lawnmower goLM = new Lawnmower();

            Console.Clear();
            Console.WriteLine("Upgrade Shop");
            Console.WriteLine("Page 2.");
            Console.WriteLine();

            Console.WriteLine("Welcome to the Upgrades Shop!");

            Int64 BasementUnlock = 100000000000000;

            double basenum = 1.3788;

            double cSUP = Math.Pow(basenum, shopcosts.ChildStorageUP);
            double cBTUP = Math.Pow(basenum, shopcosts.ChildBeatTimeUP);
            double cLUP = Math.Pow(basenum, shopcosts.ChildLuckUP);

            Console.WriteLine("");

            if (noU.Abbreviation)
            {
                noU.AbbNumber = noU.bal;//sets the balance to global int64

                goLM.Abbreviation();//where its compressed if abbreviation is true

                Console.WriteLine("$ " + noU.AbbNumber + noU.AbbLetter);//writes the compressed number and lettering
            }
            else
            {
                Console.WriteLine("$ " + noU.bal);
            }

            Console.WriteLine();

            Console.WriteLine("<. Previous Page");

            Console.WriteLine("0. Leave Shop");

            Console.WriteLine();

            if(!Child.BasementLock)
            {
                if (noU.Abbreviation)
                {
                    noU.AbbNumber = Convert.ToInt64(cSUP);

                    goLM.Abbreviation();

                    Console.WriteLine("1. Child Cells: " + shopcosts.ChildStorageUP + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("1. Child Cells: " + shopcosts.ChildStorageUP + " Cost: $ " + cSUP);
                }

                if (noU.Abbreviation)
                {
                    noU.AbbNumber = Convert.ToInt64(cBTUP);

                    goLM.Abbreviation();

                    Console.WriteLine("2. Child Beat Time: " + Child.BeatTime / 1000 + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("2. Child Beat Time: " + Child.BeatTime/1000 + " Cost: $ " + cBTUP);
                }

                if (noU.Abbreviation)
                {
                    noU.AbbNumber = Convert.ToInt64(cLUP);

                    goLM.Abbreviation();

                    Console.WriteLine("3. Child Level Up Chance: %" + Child.ChildLuck / 100 + " Cost: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("3. Child Level Up Chance: %" + Child.ChildLuck/100 + " Cost: $ " + cLUP);
                }
            }

            if(Child.BasementLock)
            {
                if (noU.Abbreviation)
                {
                    noU.AbbNumber = BasementUnlock;

                    goLM.Abbreviation();

                    Console.WriteLine("99. Unlock Basement. Cost: $" + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("99. Unlock Basement. Cost: $" + BasementUnlock);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Which would you like to upgrade?");
            Console.WriteLine("Choose a number: ");

            shopcosts.selX = Console.ReadLine();

            shopcosts.selXChk = Int32.TryParse(shopcosts.selX, out shopcosts.SXC);//tries to parse input

            if (shopcosts.selX == "<")
            {
                noU.ShopCurrentPage = noU.ShopCurrentPage - 1;

                shopcosts.SXC = 999999999;
            }
            else if (shopcosts.selX == "99")
            {
                if(Child.BasementLock)
                {
                    if (BasementUnlock <= noU.bal)
                    {
                        noU.bal = noU.bal - BasementUnlock;

                        Console.WriteLine("You can now find children on drugs in your lawn!");

                        Console.ReadLine();

                        Child.BasementLock = false;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
            }
            else if (shopcosts.selX == "0")
            {
                Console.WriteLine("Thank you for shopping at walmart!");
                Console.ReadLine();
            }
            else if (shopcosts.selX == "1")
            {
                if(!Child.BasementLock)
                {
                    if (cSUP <= noU.bal)
                    {
                        shopcosts.ChildStorageUP++;

                        Child.BasementStorageContainers++;

                        noU.bal = noU.bal - Convert.ToInt64(cSUP);

                        Child.BasementStorage = Child.BasementStorageContainers * Child.BasementStorageSpace * Child.BasementStorageSpace;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
            }
            else if (shopcosts.selX == "2")
            {
                if(!Child.BasementLock)
                {
                    if (cBTUP <= noU.bal)
                    {
                        if (Child.BeatTime > 15000)
                        {
                            shopcosts.ChildBeatTimeUP++;

                            Child.BeatTime = Child.BeatTime - 3000;

                            noU.bal = noU.bal - Convert.ToInt64(cBTUP);

                            cTimer.Interval = Child.BeatTime;
                        }
                        else
                        {
                            Console.WriteLine("Child Beat Time is Maxed!");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
            }
            else if (shopcosts.selX == "3")
            {
                if(!Child.BasementLock)
                {
                    if (cLUP <= noU.bal)
                    {
                        if (Child.ChildLuck < 1500)
                        {
                            shopcosts.ChildLuckUP++;

                            Child.ChildLuck = Child.ChildLuck + 10;

                            noU.bal = noU.bal - Convert.ToInt64(cLUP);
                        }
                        else
                        {
                            Console.WriteLine("Level Up Chance is maxed!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        Console.ReadLine();
                    }
                }
            }
            else if (!shopcosts.selXChk)//if input was not an option it gets sent to do-while and reenters shop
            {
                shopcosts.SXC = 999999999;
            }
            else
            {
                Console.WriteLine("Invalid Selection!");
                Console.ReadLine();
            }
        }
        //Upgrade Shop EE

        //Weapons Shop BB
        public void WeaponShop()//first page
        {
            Lawnmower goLM = new Lawnmower();
            Weapon makeWeapon = new Weapon();

            Console.Clear();

            Int64 licenselock = 1000000000000000;

            Console.WriteLine("Welcome to the Weapon Shop!");
            Console.WriteLine("Page: " + noU.WeaponsCurrentPage);
            Console.WriteLine();

            Console.WriteLine("$ " +noU.bal);
            Console.WriteLine("Quintillions: " + noU.BalQui);
            Console.WriteLine();

            Console.WriteLine("0. Leave Weapons Shop");
            if (shopcosts.WeaponShopLock)
            {
                if (noU.Abbreviation)
                {
                    noU.AbbNumber = licenselock;

                    goLM.Abbreviation();

                    Console.WriteLine("99. Get a License: $ " + noU.AbbNumber + noU.AbbLetter);
                }
                else
                {
                    Console.WriteLine("99. Get a License: $ " + licenselock);
                }
            }

            if(!shopcosts.WeaponShopLock)
            {
                if(!Weapons.hasButterKnife)
                {
                    Console.WriteLine("1. Butter Knife : ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Choose: ");

            shopcosts.selX = Console.ReadLine();

            shopcosts.selXChk = Int32.TryParse(shopcosts.selX, out shopcosts.SXC);//tries to parse input

            if(shopcosts.selX == "99")
            {
                if (shopcosts.WeaponShopLock)
                {
                    if (noU.bal >= licenselock)
                    {
                        shopcosts.WeaponShopLock = false;

                        Console.WriteLine("You got your weapons license!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                }
                else
                {

                    Console.WriteLine("You already have a license... :/");
                }
            }
            else
            {
                noU.settingsSXC = "00191919191";
            }
        }
        //Weapons Shop EE

        //Gambling BB
        public void GambleSel()
        {
            Console.Clear();

            Console.WriteLine("Gamble");
            Console.WriteLine();

            Lawnmower goLM = new Lawnmower();

            Console.WriteLine("Welcome to the Casino!");
            Console.WriteLine();

            Console.WriteLine("What game would you like to test your luck in?");
            Console.WriteLine();

            Console.WriteLine("0. Leave Casino");
            Console.WriteLine("1. Coinflip");

            Gamble.GambleSel = Console.ReadLine();

            if (Gamble.GambleSel == "1")
            {
                goLM.CoinFlip();
            }
            else if(Gamble.GambleSel == "0")
            {
                Gamble.GambleSel = "0";
            }
            else
            {
                Gamble.GambleSel = "999";
            }
        }

        public void CoinFlip()
        {
            Console.Clear();

            Lawnmower goLM = new Lawnmower();
            Random flip = new Random();

            Console.WriteLine("Gamble - Coinflip");
            Console.WriteLine();

            Console.WriteLine(noU.bal);
            Console.WriteLine();

            Console.WriteLine("Enter bet amount: ");

            string bet;
            Int64 x = 0;
            bool betValid = false;

            do
            {
                bet = Console.ReadLine();
                Int64.TryParse(bet, out x);

                if (noU.bal >= x)
                {
                    if (x >= 1)
                    {
                        betValid = true;
                    }
                }
                else
                {
                    betValid = false;
                    Console.WriteLine("Not enough money!");
                }

                if(bet.Equals("leave", StringComparison.InvariantCultureIgnoreCase))
                {
                    betValid = true;
                    bet = "1";
                }
            }
            while (betValid == false);

            noU.bal = noU.bal - Convert.ToInt64(bet);

            if(noU.Abbreviation)
            {
                noU.AbbNumber = Convert.ToInt64(bet);

                Console.WriteLine("You've bet: $" + noU.AbbNumber + noU.AbbLetter);
            }
            else
            {
                Console.WriteLine("You've bet $" + bet);
            }

            Console.WriteLine();
            Console.WriteLine("Pick one: Heads(H) or Tails(T)");

            string coinsel = "k";
            coinsel = Console.ReadLine();
            Int64 selection = 2;

            if (coinsel.Equals("heads", StringComparison.InvariantCultureIgnoreCase) || coinsel.Equals("h", StringComparison.InvariantCultureIgnoreCase))
            {
                selection = 0;
            }

            if (coinsel.Equals("tails", StringComparison.InvariantCultureIgnoreCase) || coinsel.Equals("t", StringComparison.InvariantCultureIgnoreCase))
            {
                selection = 1;
            }

            if (!coinsel.Equals("heads", StringComparison.InvariantCultureIgnoreCase) || !coinsel.Equals("h", StringComparison.InvariantCultureIgnoreCase) || !coinsel.Equals("tails", StringComparison.InvariantCultureIgnoreCase) || !coinsel.Equals("t", StringComparison.InvariantCultureIgnoreCase))
            {
                if (selection == Math.Round(flip.NextDouble()))
                {
                    Console.WriteLine();
                    Console.WriteLine(coinsel + "!");

                    Console.WriteLine();
                    if (noU.Abbreviation)
                    {
                        noU.AbbNumber = (Convert.ToInt64(bet) * 10);

                        Console.WriteLine("You won: $" + noU.AbbNumber + noU.AbbLetter);

                        noU.bal = noU.bal + (Convert.ToInt64(bet) * 10);

                        noU.CFWins++;
                    }
                    else
                    {
                        Console.WriteLine("You won: $" + Convert.ToInt64(bet) * 10);

                        noU.bal = noU.bal + (Convert.ToInt64(bet) * 10);

                        noU.CFWins++;
                    }
                    Console.ReadLine();
                }
                else
                {
                    noU.bal = noU.bal - Convert.ToInt64(bet);

                    Console.WriteLine("You lost! Better luck next time!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Selection!");
                Console.ReadLine();
            }
        }

        public void BlackJack()
        {
            Console.Clear();
            Console.WriteLine("Gamble - Blackjack");
            Console.WriteLine();
        }
        //Gamble EE

        //Settings BB
        public void Settings()
        {
            Console.Clear();
            Console.WriteLine("Settings");
            Console.WriteLine("Page 1");
            Console.WriteLine();

            string abb;

            if (noU.Abbreviation)
            {
                abb = "On";
            }
            else
            {
                abb = "Off";
            }

            string autsel;

            if(lm.autosell)
            {
                autsel = "On";
            }
            else
            {
                autsel = "Off";
            }

            string autsav;

            if (noU.autosave)
            {
                autsav = "On";
            }
            else
            {
                autsav = "Off";
            }

            //Console.WriteLine(">. Next Page");//Keeping it off till second page needed
            Console.WriteLine("0. Exit Settings");
            Console.WriteLine("1. Toggle Autosell - " + autsel);
            Console.WriteLine("2. Toggle Autosave - " + autsav);
            Console.WriteLine("3. Toggle Abbreviations - " + abb);

            Console.WriteLine();
            Console.WriteLine("Select an option to toggle/change:");

            noU.settingsSXC = Console.ReadLine();

            if(noU.settingsSXC.Equals(">", StringComparison.InvariantCultureIgnoreCase))
            {
                noU.SettingsCurrentPage++;
            }
            else if (noU.settingsSXC.Equals("autosell", StringComparison.InvariantCultureIgnoreCase) || noU.settingsSXC.Equals("1", StringComparison.InvariantCultureIgnoreCase))
            {
                if (!noU.AutosellLock)
                {
                    lm.autosell = !lm.autosell;
                    if (lm.autosell == false)
                    {
                        Console.WriteLine("Autosell Toggled Off");

                        Console.WriteLine("Press any Key to go back!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Autosell Toggled On");

                        Console.WriteLine("Press any Key to go back!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You haven't bought Autosell from shop!");
                    Console.ReadLine();
                }
            }
            else if (noU.settingsSXC.Equals("autosave", StringComparison.InvariantCultureIgnoreCase) || noU.settingsSXC.Equals("2", StringComparison.InvariantCultureIgnoreCase))
            {
                SetSavePath.saveexit = !SetSavePath.saveexit;

                if (!SetSavePath.saveexit)
                {
                    dTimer.Start();

                    noU.autosave = !noU.autosave;

                    Console.WriteLine("The game will now autosave every 5 minutes!");
                    Console.ReadLine();
                }

                if (SetSavePath.saveexit)
                {
                    dTimer.Stop();
                    dTimer.Interval = 300000;

                    noU.autosave = !noU.autosave;

                    Console.WriteLine("The game will no longer autosave every 5 minutes.");
                    Console.ReadLine();
                }
            }
            else if (noU.settingsSXC.Equals("abbreviation", StringComparison.InvariantCultureIgnoreCase) || noU.settingsSXC.Equals("abb", StringComparison.InvariantCultureIgnoreCase) || noU.settingsSXC.Equals("3", StringComparison.InvariantCultureIgnoreCase))
            {
                noU.Abbreviation = !noU.Abbreviation;

                if (noU.Abbreviation)
                {
                    Console.WriteLine("Your money will be abbreviated");
                }
                else
                {
                    Console.WriteLine("Your money will NOT be abbreviated");
                }

                Console.ReadLine();
            }
        }
        //Settings EE

        //Player BB
        public void Inventory()
        {
            Console.Clear();

            Lawnmower goLM = new Lawnmower();

            Console.WriteLine("Inventory");
            Console.WriteLine();

            Console.WriteLine("0. Leave Inventory");
            Console.WriteLine("1. View Status");
            Console.WriteLine("2. Equipment");
            Console.WriteLine();

            Console.WriteLine("Choose an option:");
            Int64 Selection = 0;
            bool SelChk = false;

            do
            {
                player.MenuSel = Console.ReadLine();

                SelChk = Int64.TryParse(player.MenuSel, out Selection);
            }
            while (SelChk == false);

            if(Selection == 1)
            {
                player.MenuSel = "1";
            }
            else if(Selection == 2)
            {
                player.MenuSel = "2";

                goLM.Equipment();
            }
            else if(Selection == 0)
            {
                player.MenuSel = "0";
            }
            else
            {
                player.MenuSel = "10101010";
            }

        }

        public void Equipment()
        {
            Console.Clear();

            Lawnmower goLM = new Lawnmower();
            Weapon makeWeapon = new Weapon();

            Int32 WeapUnl = 0;
            Int32 Weap = 0;

            Console.WriteLine("Inventory - Equipment");
            Console.WriteLine();

            Console.WriteLine("Beat Weapon: " + player.BeatWeapon);

            Console.WriteLine();
            Console.WriteLine("Equipment - Weapons");
            Console.WriteLine();

            if(Weapons.hasButterKnife)
            {
                makeWeapon.Name = Weapons.ButterKnife;
                makeWeapon.ATK = Weapons.ButterKnifeATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasKitchenKnife)
            {
                makeWeapon.Name = Weapons.KitchenKnife;
                makeWeapon.ATK = Weapons.KitchenKnifeATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasTacticalKnife)
            {
                makeWeapon.Name = Weapons.TacticalKnife;
                makeWeapon.ATK = Weapons.TacticalKnifeATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasKatana)
            {
                makeWeapon.Name = Weapons.Katana;
                makeWeapon.ATK = Weapons.KatanaATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasClaymore)
            {
                makeWeapon.Name = Weapons.Claymore;
                makeWeapon.ATK = Weapons.ClaymoreATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasHydraDildo)
            {
                makeWeapon.Name = Weapons.HydraDildo;
                makeWeapon.ATK = Weapons.HydrawDildoATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            Console.WriteLine();

            if (Weapons.hasBlowPipe)
            {
                makeWeapon.Name = Weapons.BlowPipe;
                makeWeapon.ATK = Weapons.BlowPipeATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasSlignshot)
            {
                makeWeapon.Name = Weapons.Slingshot;
                makeWeapon.ATK = Weapons.SlingshotATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasBBGun)
            {
                makeWeapon.Name = Weapons.BBGun;
                makeWeapon.ATK = Weapons.BBGunATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasAirsoftRifle)
            {
                makeWeapon.Name = Weapons.AirsoftRifle;
                makeWeapon.ATK = Weapons.AirsoftRifleATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasAN94)
            {
                makeWeapon.Name = Weapons.AN94;
                makeWeapon.ATK = Weapons.AN94ATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            if (Weapons.hasRocketLauncher)
            {
                makeWeapon.Name = Weapons.RocketLauncher;
                makeWeapon.ATK = Weapons.RocketLauncherATK;

                Console.WriteLine(makeWeapon.Name + " : " + makeWeapon.ATK);

                Weap++;
                WeapUnl++;
            }
            else
            {
                Weap++;
            }

            Console.WriteLine();
            Console.WriteLine("Weapons Unlock (" + WeapUnl + "/" + Weap + ")");
            Console.WriteLine();

            string equipchk = Console.ReadLine();

            if(equipchk.Equals("eq", StringComparison.InvariantCultureIgnoreCase) || equipchk.Equals("equip", StringComparison.InvariantCultureIgnoreCase))
            {
                goLM.Equip();
            }
        }

        public void Equip()
        {
            Console.Clear();

            Lawnmower goLM = new Lawnmower();

            Console.WriteLine("Inventory - Equipment - Equip");
            Console.WriteLine();

            Console.WriteLine("0. Leave Equip");
            Console.WriteLine("1. Weapon");
            Console.WriteLine();

            Console.WriteLine("Choose a Piece to edit:");
            Console.WriteLine();

            Console.ReadLine();
        }
        //Player EE
    }
}
