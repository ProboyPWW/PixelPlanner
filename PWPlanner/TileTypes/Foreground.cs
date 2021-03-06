﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;

namespace PWPlanner.TileTypes
{
    public class Foreground : Tile
    {
        public override int ZIndex
        {
            get { return 5; }
        }

        public Foreground() { }

        public Foreground(Image image)
        {
            Image = image;
        }

        public static ForegroundName GetForegroundNameByString(string fileName)
        {
            fileName = Path.GetFileNameWithoutExtension(fileName);

            if (Enum.TryParse(fileName, out ForegroundName name))
            {
                return name;
            }
            else
            {
                return ForegroundName.NONE;
            }

        }

        public override Tile Clone(Image image)
        {
            var fg = new Foreground();
            fg.Image = image;
            fg.TileName = this.TileName;
            return fg;
        }

        public enum ForegroundName
        {
            AlienEye,
            AnniversaryCake,
            AnniversaryPortal,
            AquaCandyBlock,
            ArmChair,
            ArrowSign1,
            ArrowSign2,
            ArrowSign3,
            ArrowSign4,
            Balloons,
            Bamboo,
            BarStool,
            Bat,
            Bathtub,
            BattleGateDisabled,
            BattleGateEnabled,
            BattleLock,
            BattleScoreboard,
            Bed,
            Bedrock,
            BedrockFlat,
            BedrockLava,
            BlackBlock,
            BlackBrick,
            BlackCandles,
            BlackPennant,
            BlingBlingBlock,
            BlueBlock,
            BlueCandyBlock,
            BlueEasterBlock,
            BlueEasterEgg,
            BlueGlowBlock,
            BlueJelly,
            BlueMetalChair,
            BlueRunestone,
            BlueSunUmbrella,
            BoomBox,
            BoneGate,
            Bonfire,
            BookPodium,
            Bookshelf,
            BowlOfJellyBeans,
            Bush,
            Brazier,
            BrownBlock,
            Bumper,
            Bushes,
            Buzzsaw,
            Cabinet,
            Cactus,
            Cake,
            CandleStand,
            CandyCaneBlock,
            CandyPipe,
            CandySiphon,
            CandyWatermelonBlock,
            CastleBrick,
            CastleDoor,
            CelticCross,
            CookieBlock,
            Chains,
            Chandelier,
            Checkpoint,
            CheeseBlock,
            CherryBonsai,
            ChurchBell,
            CircuitBoard,
            ClassicPainting,
            ClassicSculpture,
            ClassicSculpture2,
            ClayPot,
            ClearJelly,
            CloudPlatform,
            CloverleafBlock,
            Coffin,
            ConcreteBlock1x1,
            ConcreteBlock2x1,
            ConcreteBlock2x2,
            Corn,
            CupidStatue,
            DaHoodSign,
            DarkChocolateBlock,
            DarkWorldLock,
            DeathCounter,
            DecorativeSword,
            DemonAltar,
            DesktopPC,
            DiscoBall,
            Door,
            DottedPinkBlock,
            DungeonDoor,
            EasterBasket,
            ElectricChair,
            Evolverator,
            FamiliarFoodMachine,
            FinishLine,
            FINPennant,
            Fireplace,
            FireTrap,
            FireTrap2,
            FireTrap3,
            FireTrap4,
            Fishbowl,
            FishTank,
            Flame1,
            Flame2,
            Flame3,
            Flame4,
            FlatScreenTV,
            FloorLamp,
            FrankensteinBlock,
            Fridge,
            FruitTray,
            GardenGnome,
            Gargoyle,
            GhostTrap,
            GiantEasterEgg,
            GingerbreadBlock,
            GingerbreadFence,
            GingerbreadSign,
            GlassBlock,
            GlassCabinet,
            GlassDoor,
            GlowingContainer,
            GlueBlock,
            GlueBlock2,
            GoldenConeStatue,
            GoldenHorseshoe,
            GoldenToilet,
            Gramophone,
            Granite,
            Grass,
            GraveSlant,
            Gravestone,
            GreenBlock,
            GreenCandyBlock,
            GreenEasterBlock,
            GreenGlowBlock,
            GreenGummyBear,
            GreenJelly,
            GreenMetalChair,
            GreenMushroom,
            GreenPennant,
            GreenRibbon,
            GreenRunestone,
            GreyBlock,
            GreyBrick,
            KatanaDecoration,
            HamRadio,
            HangingLeaves,
            HauntedMirror,
            HazardBlock,
            Headstone,
            HeartDecoration,
            HeavyMetalPoster,
            Hokora,
            HollyWreath,
            HousePlant,
            HugeMetalFan,
            HugeMetalFan2,
            IceBlock,
            Icicles,
            IrishString,
            IronBlock,
            IronFence,
            JackoLantern,
            JungleGrass,
            KiddieRide,
            KiwiBlock,
            Lantern,
            LargeBush,
            LargeLock,
            LargeSandCastle,
            Lava,
            LavaLamp,
            LEDSign,
            LegendarySoilBlock,
            LeopardArmchair,
            LeprechaunGnome,
            Lifebuoy,
            LightBlueBlock,
            LightBlueJelly,
            Lily,
            LuckyCloverleaf,
            LuckyHorseshoe,
            MagicStuff,
            MagLift,
            MakeupTable,
            ManekiNekoL,
            Marble,
            MarbleFireplace,
            MediumLock,
            MediumSandCastle,
            MetalBarrel,
            MetalHatch,
            MetalPlate,
            MetalPlatform,
            MetalTrapDoor,
            Microwave,
            MilkChocolateBlock,
            Mimic,
            MinatureSpaceship,
            ModernPainting,
            Mushroom,
            NeonHeart,
            NoteBoard,
            Obisidian,
            OldTV,
            OldWallLamp,
            OrangeBlock,
            OrangeEasterEgg,
            OrangeGlowBlock,
            OrangeRunestone,
            OuijaBoard,
            Oven,
            PileOfMoney,
            Pineapple,
            Pineapple2,
            PinkBlock,
            PinkCandyBlock,
            PinkJelly,
            PinkMetalChair,
            PinkRose,
            PlatinumLock,
            PoisonGas1,
            PoisonGas2,
            PoisonGas3,
            PoisonGas4,
            PoisonTrap,
            PoisonTrap1,
            PoisonTrap2,
            PoisonTrap3,
            Portal,
            PortalDoor,
            PotofGold,
            PottedPlant,
            PrizeBox,
            PurpleBlock,
            PurpleEasterBlock,
            PurpleJelly,
            PurpleSunUmbrella,
            RatingBoard,
            RavenTree,
            RedBlock,
            RedBrick,
            RedCandyBlock,
            RedEasterBlock,
            RedGlowBlock,
            RedGummyBear,
            RedJelly,
            RedMetalChair,
            RedRibbon,
            RedRunestone,
            RedSunUmbrella,
            ReindeerLights,
            Replicator,
            Rocks,
            Rose,
            RoundMetalTable,
            RubberDuck,
            SamuraiBlock,
            Sand,
            Sand2,
            Sandstone,
            ScifiArrow1,
            ScifiArrow2,
            ScifiArrow3,
            ScifiArrow4,
            ScifiBlock1,
            ScifiBlock2,
            ScifiBlock3,
            ScifiBlock4,
            ScifiBlock5,
            ScifiComputer,
            ScifiCrate,
            ScifiCratePile,
            ScifiDoor,
            ScifiGenerator,
            ScifiGenerator2,
            ScifiInterface1,
            ScifiLights,
            ScifiPanel1,
            ScifiPanel2,
            ScifiPanel3,
            ScifiPillar1,
            ScifiTable,
            Scoreboard,
            Serpentine,
            SerpentineAndEggs,
            Sign,
            SkullBlock,
            SmallBush,
            SmallChest,
            SmallLock,
            SmallRocks,
            SmallSandCastle,
            SnowBlock,
            Snowman,
            SnowLantern,
            SnowyFence,
            Soil,
            Soil2,
            Spider,
            SpiderWeb,
            SpiralPillar,
            Spike1,
            Spike2,
            Spike3,
            Spike4,
            SpikeBall,
            SpikeTrap,
            SpikeTrap2,
            SpikeTrap3,
            SpikeTrap4,
            Spotlight,
            SpringBoard,
            SpringBoard2,
            SpringBoard3,
            SpringBoard4,
            StartLine,
            SteelSpikes1,
            SteelSpikes2,
            SteelSpikes3,
            SteelSpikes4,
            Stereo,
            StonePlatform,
            Strawberry,
            Strawberry2,
            StuddedMetal,
            Sunflower,
            Sushi,
            TaikoDrum,
            TallGrass,
            Tapestry,
            TeaSet,
            TeslaSphere,
            Throne,
            TintedGlassDoor,
            ToiletSeat,
            TombStone,
            Torch,
            Torii,
            ToyBunny,
            ToyChick,
            TreeStump,
            TreeTrunk,
            TVChair,
            VegetationBlock,
            Vine,
            VioletEasterEgg,
            VortexPortal,
            VikingArmorBlock,
            VikingBlock,
            VikingFigureHead,
            VikingShieldDecoration,
            VikingWall,
            VikingWall2,
            VikingWall3,
            VikingWall4,
            WallTorch,
            Wardrobe,
            WaterBed,
            WatercolorBlock,
            WaterMelonBlock,
            WeaponRack,
            WhiteBlocks,
            WhiteBrick,
            WinterBells,
            WireFence,
            WoodenBarrel,
            WoodBlock,
            WoodenChair,
            WoodenFence,
            WoodenHatch,
            WoodenPlatform,
            WoodenTable,
            WoodWall,
            WorldLock,
            XmasLights,
            XmasTree,
            YardLamp,
            YellowBlock,
            YellowBrick,
            YellowCandyBlock,
            YellowEasterBlock,
            YellowGummyBear,
            YellowJelly,
            YellowMetalChair,
            YinYangBlock,
            ZombieTrap,
            BeigeBrick,
            BloodClawMarks,
            BloodSplash,
            BlueBrick,
            BrokenRuinWall,
            CoalBlock,
            CobraStatue,
            ConcretePlatform,
            ConstructionBarricade,
            CrackedPottery,
            DarkRedBlock,
            DrippingBlood,
            GluePlatform,
            GreenBrick,
            IcePlatform,
            LeaningPlanks,
            MayanStatue,
            MetalSlant,
            MossyRuinWall,
            OldBrickPile,
            RedJelloPlatform,
            RuinPatternBlock1,
            RuinPatternBlock2,
            RuinSlant,
            RuinsPillar1,
            RuinsPillar2,
            RuinsPillar3,
            RuinsPillar4,
            RuinTiles,
            ShovelInSand,
            Shower,
            TrafficCone,
            TwistedTreePillar1,
            TwistedTreePillar2,
            TwistedTreePillar3,
            TwistedTreePillar4,
            TwistedTreePillar5,
            NONE
        }
    }
}
