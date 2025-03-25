// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

namespace FFXIVClientStructs.FFXIV.Client.UI.Misc;

/// <summary>
/// ConfigOption indexes for use with ConfigModule.
/// This enum will be incorrect after any patch that adds or removes any config options.
/// </summary>
public enum ConfigOption : short {
    Invalid = -1,
    None = 0,

    #region System
    // <FINAL FANTASY XIV Config File>
    // <Version>
    GuidVersion = 2,
    ConfigVersion = 3,
    Language = 4,
    Region = 5,
    // <Network Settings>
    UPnP = 7,
    Port = 8,
    LastLogin0 = 9,
    LastLogin1 = 10,
    WorldId = 11,
    ServiceIndex = 12,
    DktSessionId = 13,
    // <Display Settings>
    MainAdapter = 15,
    ScreenLeft = 16,
    ScreenTop = 17,
    ScreenWidth = 18,
    ScreenHeight = 19,
    ScreenMode = 20,
    FullScreenWidth = 21,
    FullScreenHeight = 22,
    Refreshrate = 23,
    Fps = 24,
    AntiAliasing = 25,
    FPSInActive = 26,
    ResoMouseDrag = 27,
    MouseOpeLimit = 28,
    LangSelectSub = 29,
    Gamma = 30,
    UiBaseScale = 31,
    CharaLight = 32,
    UiHighScale = 33,
    // <Graphics Settings>
    TextureFilterQuality = 35,
    TextureAnisotropicQuality = 36,
    SSAO = 37,
    Glare = 38,
    DistortionWater = 39,
    DepthOfField = 40,
    RadialBlur = 42,
    Vignetting = 43,
    GrassQuality = 44,
    TranslucentQuality = 45,
    ShadowVisibilityType = 46,
    ShadowSoftShadowType = 47,
    ShadowTextureSizeType = 48,
    ShadowCascadeCountType = 49,
    LodType = 50,
    StreamingType = 51,
    GeneralQuality = 52,
    OcclusionCulling = 53,
    ShadowLOD = 54,
    PhysicsType = 59,
    MapResolution = 60,
    ShadowVisibilityTypeSelf = 61,
    ShadowVisibilityTypeParty = 62,
    ShadowVisibilityTypeOther = 63,
    ShadowVisibilityTypeEnemy = 64,
    PhysicsTypeSelf = 65,
    PhysicsTypeParty = 66,
    PhysicsTypeOther = 67,
    PhysicsTypeEnemy = 68,
    ReflectionType = 69,
    ScreenShotImageType = 70,
    // <Sound Settings>
    IsSoundDisable = 72,
    IsSoundAlways = 73,
    IsSoundBgmAlways = 74,
    IsSoundSeAlways = 75,
    IsSoundVoiceAlways = 76,
    IsSoundSystemAlways = 77,
    IsSoundEnvAlways = 78,
    IsSoundPerformAlways = 79,
    // <Font Settings>
    // <GamePad Settings>
    PadGuid = 82,
    InstanceGuid = 83,
    ProductGuid = 84,
    DeadArea = 85,
    Alias = 86,
    AlwaysInput = 87,
    ForceFeedBack = 88,
    PadPovInput = 89,
    PadMode = 90,
    PadAvailable = 91,
    PadReverseConfirmCancel = 92,
    PadSelectButtonIcon = 93,
    PadMouseMode = 94,
    TextPasteEnable = 95,
    EnablePsFunction = 96,
    ActiveInstanceGuid = 97,
    ActiveProductGuid = 98,
    WaterWet = 99,
    DisplayObjectLimitType = 100,
    WindowDispNum = 101,
    ScreenShotDir = 102,
    // <Graphics Settings DX11>
    AntiAliasing_DX11 = 104,
    TextureFilterQuality_DX11 = 105,
    TextureAnisotropicQuality_DX11 = 106,
    SSAO_DX11 = 107,
    Glare_DX11 = 108,
    DistortionWater_DX11 = 109,
    DepthOfField_DX11 = 110,
    RadialBlur_DX11 = 111,
    Vignetting_DX11 = 112,
    GrassQuality_DX11 = 113,
    TranslucentQuality_DX11 = 114,
    ShadowSoftShadowType_DX11 = 115,
    ShadowTextureSizeType_DX11 = 116,
    ShadowCascadeCountType_DX11 = 117,
    LodType_DX11 = 118,
    OcclusionCulling_DX11 = 119,
    ShadowLOD_DX11 = 120,
    MapResolution_DX11 = 121,
    ShadowVisibilityTypeSelf_DX11 = 122,
    ShadowVisibilityTypeParty_DX11 = 123,
    ShadowVisibilityTypeOther_DX11 = 124,
    ShadowVisibilityTypeEnemy_DX11 = 125,
    PhysicsTypeSelf_DX11 = 126,
    PhysicsTypeParty_DX11 = 127,
    PhysicsTypeOther_DX11 = 128,
    PhysicsTypeEnemy_DX11 = 129,
    ReflectionType_DX11 = 130,
    WaterWet_DX11 = 131,
    ParallaxOcclusion_DX11 = 132,
    Tessellation_DX11 = 133,
    GlareRepresentation_DX11 = 134,
    DynamicRezoThreshold = 135,
    GraphicsRezoScale = 136,
    GraphicsRezoUpscaleType = 137,
    GrassEnableDynamicInterference = 138,
    ShadowBgLOD = 139,
    TextureRezoType = 140,
    ShadowLightValidType = 141,
    DynamicRezoEnableCutScene = 142,
    UiSystemEnlarge = 143,
    SoundPadSeType = 144,
    SoundPad = 145,
    IsSoundPad = 146,
    TouchPadMouse = 147,
    TouchPadCursorSpeed = 148,
    TouchPadButtonExtension = 149,
    TouchPadButton_Left = 150,
    TouchPadButton_Right = 151,
    RemotePlayRearTouchpadEnable = 152,
    SupportButtonAutorunEnable = 153,
    R3ButtonWindowScalingEnable = 154,
    AutoAfkSwitchingTime = 155,
    AutoChangeCameraMode = 156,
    MsqProgress = 157,
    PromptConfigUpdate = 158,
    TitleScreenType = 159,
    AccessibilitySoundVisualEnable = 160,
    AccessibilitySoundVisualDispSize = 161,
    AccessibilitySoundVisualPermeabilityRate = 162,
    AccessibilityColorBlindFilterEnable = 163,
    AccessibilityColorBlindFilterType = 164,
    AccessibilityColorBlindFilterStrength = 165,
    // <Mouse Settings>
    MouseAutoFocus = 167,
    // <UI Settings>
    FPSDownAFK = 169,
    IdlingCameraAFK = 170,
    FirstConfigBackup = 171,
    MouseSpeed = 192,
    CameraZoom = 214,
    DynamicRezoType = 329,
    // <Move Operation>
    Is3DAudio = 339,
    BattleEffect = 341,
    BGEffect = 342,
    ColorThemeType = 753,
    SystemMouseOperationSoftOn = 842,
    SystemMouseOperationTrajectory = 843,
    SystemMouseOperationCursorScaling = 844,
    HardwareCursorSize = 845,
    UiAssetType = 846,
    FellowshipShowNewNotice = 867,
    // <Cutscene Settings>
    CutsceneMovieVoice = 885,
    CutsceneMovieCaption = 886,
    CutsceneMovieOpening = 887,
    // <SoundPlay Settings>
    SoundMaster = 890,
    SoundBgm = 891,
    SoundSe = 892,
    SoundVoice = 893,
    SoundEnv = 894,
    SoundSystem = 895,
    SoundPerform = 896,
    SoundPlayer = 897,
    SoundParty = 898,
    SoundOther = 899,
    IsSndMaster = 900,
    IsSndBgm = 901,
    IsSndSe = 902,
    IsSndVoice = 903,
    IsSndEnv = 904,
    IsSndSystem = 905,
    IsSndPerform = 906,
    SoundDolby = 907,
    SoundMicpos = 908,
    SoundChocobo = 909,
    SoundFieldBattle = 910,
    SoundCfTimeCount = 911,
    SoundHousing = 912,
    SoundEqualizerType = 913,
    // <GamePad Button Settings>
    PadButton_L2 = 915,
    PadButton_R2 = 916,
    PadButton_L1 = 917,
    PadButton_R1 = 918,
    PadButton_Triangle = 919,
    PadButton_Circle = 920,
    PadButton_Cross = 921,
    PadButton_Square = 922,
    PadButton_Select = 923,
    PadButton_Start = 924,
    PadButton_LS = 925,
    PadButton_RS = 926,
    PadButton_L3 = 927,
    PadButton_R3 = 928,
    // <CUSTOM CONFIGURATION>
    #endregion

    #region UiConfig
    BattleEffectSelf = 55,
    BattleEffectParty = 56,
    BattleEffectOther = 57,
    BattleEffectPvPEnemyPc = 58,
    // <GamePad Settings>
    // <UI Settings>
    // <Charcter Settings>
    WeaponAutoPutAway = 173,
    WeaponAutoPutAwayTime = 174,
    LipMotionType = 175,
    // <Game Camera Settings>
    FirstPersonDefaultYAngle = 177,
    FirstPersonDefaultZoom = 178,
    FirstPersonDefaultDistance = 179,
    ThirdPersonDefaultYAngle = 180,
    ThirdPersonDefaultZoom = 181,
    ThirdPersonDefaultDistance = 182,
    LockonDefaultYAngle = 183,
    LockonDefaultZoom = 184,
    LockonDefaultZoom_185 = 185,
    CameraProductionOfAction = 209,
    FPSCameraInterpolationType = 210,
    FPSCameraVerticalInterpolation = 211,
    LegacyCameraCorrectionFix = 212,
    LegacyCameraType = 213,
    EventCameraAutoControl = 215,
    CameraLookBlinkType = 216,
    IdleEmoteTime = 217,
    IdleEmoteRandomType = 218,
    CutsceneSkipIsShip = 219,
    CutsceneSkipIsContents = 220,
    CutsceneSkipIsHousing = 221,
    PetTargetOffInCombat = 313,
    GroundTargetFPSPosX = 314,
    GroundTargetFPSPosY = 315,
    GroundTargetTPSPosX = 316,
    GroundTargetTPSPosY = 317,
    TargetDisableAnchor = 318,
    TargetCircleClickFilterEnableNearestCursor = 319,
    TargetEnableMouseOverSelect = 320,
    GroundTargetCursorCorrectType = 321,
    GroundTargetActionExcuteType = 322,
    AutoNearestTarget = 327,
    AutoNearestTargetType = 328,
    RightClickExclusionPC = 330,
    RightClickExclusionBNPC = 331,
    RightClickExclusionMinion = 332,
    EnableMoveTiltCharacter = 333,
    EnableMoveTiltMountGround = 334,
    EnableMoveTiltMountFly = 335,
    TurnSpeed = 338,
    FootEffect = 340,
    LegacySeal = 343,
    GBarrelDisp = 344,
    EgiMirageTypeGaruda = 345,
    EgiMirageTypeTitan = 346,
    EgiMirageTypeIfrit = 347,
    BahamutSize = 348,
    PetMirageTypeCarbuncleSupport = 349,
    PhoenixSize = 350,
    GarudaSize = 351,
    TitanSize = 352,
    IfritSize = 353,
    SolBahamutSize = 354,
    PetMirageTypeFairy = 355,
    TimeMode = 356,
    Time12 = 357,
    TimeEorzea = 358,
    TimeLocal = 359,
    TimeServer = 360,
    ActiveLS_H = 361,
    ActiveLS_L = 362,
    HotbarLock = 364,
    HotbarDispRecastTime = 366,
    HotbarCrossContentsActionEnableInput = 367,
    HotbarDispRecastTimeDispType = 368,
    ExHotbarChangeHotbar1 = 381,
    HotbarCommon01 = 383,
    HotbarCommon02 = 384,
    HotbarCommon03 = 385,
    HotbarCommon04 = 386,
    HotbarCommon05 = 387,
    HotbarCommon06 = 388,
    HotbarCommon07 = 389,
    HotbarCommon08 = 390,
    HotbarCommon09 = 391,
    HotbarCommon10 = 392,
    HotbarCrossCommon01 = 393,
    HotbarCrossCommon02 = 394,
    HotbarCrossCommon03 = 395,
    HotbarCrossCommon04 = 396,
    HotbarCrossCommon05 = 397,
    HotbarCrossCommon06 = 398,
    HotbarCrossCommon07 = 399,
    HotbarCrossCommon08 = 400,
    HotbarCrossHelpDisp = 401,
    HotbarCrossOperation = 402,
    HotbarCrossDisp = 403,
    HotbarCrossLock = 404,
    HotbarCrossUsePadGuide = 407,
    HotbarCrossActiveSet = 408,
    HotbarCrossActiveSetPvP = 409,
    HotbarCrossSetChangeCustomIsAuto = 410,
    HotbarCrossSetChangeCustom = 412,
    HotbarCrossSetChangeCustomSet1 = 413,
    HotbarCrossSetChangeCustomSet2 = 414,
    HotbarCrossSetChangeCustomSet3 = 415,
    HotbarCrossSetChangeCustomSet4 = 416,
    HotbarCrossSetChangeCustomSet5 = 417,
    HotbarCrossSetChangeCustomSet6 = 418,
    HotbarCrossSetChangeCustomSet7 = 419,
    HotbarCrossSetChangeCustomSet8 = 420,
    HotbarCrossSetChangeCustomIsSword = 421,
    HotbarCrossSetChangeCustomIsSwordSet1 = 422,
    HotbarCrossSetChangeCustomIsSwordSet2 = 423,
    HotbarCrossSetChangeCustomIsSwordSet3 = 424,
    HotbarCrossSetChangeCustomIsSwordSet4 = 425,
    HotbarCrossSetChangeCustomIsSwordSet5 = 426,
    HotbarCrossSetChangeCustomIsSwordSet6 = 427,
    HotbarCrossSetChangeCustomIsSwordSet7 = 428,
    HotbarCrossSetChangeCustomIsSwordSet8 = 429,
    HotbarCrossAdvancedSetting = 430,
    HotbarCrossAdvancedSettingLeft = 431,
    HotbarCrossAdvancedSettingRight = 432,
    HotbarCrossSetPvpModeActive = 433,
    HotbarCrossSetChangeCustomPvp = 434,
    HotbarCrossSetChangeCustomIsAutoPvp = 435,
    HotbarCrossSetChangeCustomSet1Pvp = 436,
    HotbarCrossSetChangeCustomSet2Pvp = 437,
    HotbarCrossSetChangeCustomSet3Pvp = 438,
    HotbarCrossSetChangeCustomSet4Pvp = 439,
    HotbarCrossSetChangeCustomSet5Pvp = 440,
    HotbarCrossSetChangeCustomSet6Pvp = 441,
    HotbarCrossSetChangeCustomSet7Pvp = 442,
    HotbarCrossSetChangeCustomSet8Pvp = 443,
    HotbarCrossSetChangeCustomIsSwordPvp = 444,
    HotbarCrossSetChangeCustomIsSwordSet1Pvp = 445,
    HotbarCrossSetChangeCustomIsSwordSet2Pvp = 446,
    HotbarCrossSetChangeCustomIsSwordSet3Pvp = 447,
    HotbarCrossSetChangeCustomIsSwordSet4Pvp = 448,
    HotbarCrossSetChangeCustomIsSwordSet5Pvp = 449,
    HotbarCrossSetChangeCustomIsSwordSet6Pvp = 450,
    HotbarCrossSetChangeCustomIsSwordSet7Pvp = 451,
    HotbarCrossSetChangeCustomIsSwordSet8Pvp = 452,
    HotbarCrossAdvancedSettingPvp = 453,
    HotbarCrossAdvancedSettingLeftPvp = 454,
    HotbarCrossAdvancedSettingRightPvp = 455,
    HotbarWXHBEnable = 456,
    HotbarWXHBSetLeft = 457,
    HotbarWXHBSetRight = 458,
    HotbarWXHBEnablePvP = 459,
    HotbarWXHBSetLeftPvP = 460,
    HotbarWXHBSetRightPvP = 461,
    HotbarWXHB8Button = 462,
    HotbarWXHB8ButtonPvP = 463,
    HotbarWXHBSetInputTime = 464,
    HotbarWXHBDisplay = 465,
    HotbarWXHBFreeLayout = 466,
    HotbarXHBActiveTransmissionAlpha = 467,
    HotbarXHBAlphaDefault = 468,
    HotbarXHBAlphaActiveSet = 469,
    HotbarXHBAlphaInactiveSet = 470,
    HotbarWXHBInputOnce = 471,
    ExHotbarChangeHotbar1IsFashion = 472,
    HotbarCrossUseExDirectionAutoSwitch = 473,
    IdlingCameraSwitchType = 474,
    HotbarXHBEditEnable = 475,
    HotbarContentsAction2ReverseOperation = 476,
    HotbarContentsAction2ReturnInitialSlot = 477,
    HotbarContentsAction2ReverseRotate = 478,
    PlateType = 479,
    PlateDispHPBar = 480,
    PlateDisableMaxHPBar = 481,
    NamePlateHpSizeType = 482,
    NamePlateColorSelf = 483,
    NamePlateEdgeSelf = 484,
    NamePlateDispTypeSelf = 485,
    NamePlateNameTypeSelf = 486,
    NamePlateHpTypeSelf = 487,
    NamePlateColorSelfBuddy = 488,
    NamePlateEdgeSelfBuddy = 489,
    NamePlateDispTypeSelfBuddy = 490,
    NamePlateHpTypeSelfBuddy = 491,
    NamePlateColorSelfPet = 492,
    NamePlateEdgeSelfPet = 493,
    NamePlateDispTypeSelfPet = 494,
    NamePlateHpTypeSelfPet = 495,
    NamePlateColorParty = 496,
    NamePlateEdgeParty = 497,
    NamePlateDispTypeParty = 498,
    NamePlateNameTypeParty = 499,
    NamePlateHpTypeParty = 500,
    NamePlateDispTypePartyPet = 501,
    NamePlateHpTypePartyPet = 502,
    NamePlateDispTypePartyBuddy = 503,
    NamePlateHpTypePartyBuddy = 504,
    NamePlateColorAlliance = 505,
    NamePlateEdgeAlliance = 506,
    NamePlateDispTypeAlliance = 507,
    NamePlateNameTypeAlliance = 508,
    NamePlateHpTypeAlliance = 509,
    NamePlateDispTypeAlliancePet = 510,
    NamePlateHpTypeAlliancePet = 511,
    NamePlateColorOther = 512,
    NamePlateEdgeOther = 513,
    NamePlateDispTypeOther = 514,
    NamePlateNameTypeOther = 515,
    NamePlateHpTypeOther = 516,
    NamePlateDispTypeOtherPet = 517,
    NamePlateHpTypeOtherPet = 518,
    NamePlateDispTypeOtherBuddy = 519,
    NamePlateHpTypeOtherBuddy = 520,
    NamePlateColorUnengagedEnemy = 521,
    NamePlateEdgeUnengagedEnemy = 522,
    NamePlateDispTypeUnengagedEnemy = 523,
    NamePlateHpTypeUnengagedEmemy = 524,
    NamePlateColorEngagedEnemy = 525,
    NamePlateEdgeEngagedEnemy = 526,
    NamePlateDispTypeEngagedEnemy = 527,
    NamePlateHpTypeEngagedEmemy = 528,
    NamePlateColorClaimedEnemy = 529,
    NamePlateEdgeClaimedEnemy = 530,
    NamePlateDispTypeClaimedEnemy = 531,
    NamePlateHpTypeClaimedEmemy = 532,
    NamePlateColorUnclaimedEnemy = 533,
    NamePlateEdgeUnclaimedEnemy = 534,
    NamePlateDispTypeUnclaimedEnemy = 535,
    NamePlateHpTypeUnclaimedEmemy = 536,
    NamePlateColorNpc = 537,
    NamePlateEdgeNpc = 538,
    NamePlateDispTypeNpc = 539,
    NamePlateHpTypeNpc = 540,
    NamePlateColorObject = 541,
    NamePlateEdgeObject = 542,
    NamePlateDispTypeObject = 543,
    NamePlateHpTypeObject = 544,
    NamePlateColorMinion = 545,
    NamePlateEdgeMinion = 546,
    NamePlateDispTypeMinion = 547,
    NamePlateColorOtherBuddy = 548,
    NamePlateEdgeOtherBuddy = 549,
    NamePlateColorOtherPet = 550,
    NamePlateEdgeOtherPet = 551,
    NamePlateNameTitleTypeSelf = 552,
    NamePlateNameTitleTypeParty = 553,
    NamePlateNameTitleTypeAlliance = 554,
    NamePlateNameTitleTypeOther = 555,
    NamePlateNameTitleTypeFriend = 556,
    NamePlateColorFriend = 557,
    NamePlateColorFriendEdge = 558,
    NamePlateDispTypeFriend = 559,
    NamePlateNameTypeFriend = 560,
    NamePlateHpTypeFriend = 561,
    NamePlateDispTypeFriendPet = 562,
    NamePlateHpTypeFriendPet = 563,
    NamePlateDispTypeFriendBuddy = 564,
    NamePlateHpTypeFriendBuddy = 565,
    NamePlateColorLim = 566,
    NamePlateColorLimEdge = 567,
    NamePlateColorGri = 568,
    NamePlateColorGriEdge = 569,
    NamePlateColorUld = 570,
    NamePlateColorUldEdge = 571,
    NamePlateColorHousingFurniture = 572,
    NamePlateColorHousingFurnitureEdge = 573,
    NamePlateDispTypeHousingFurniture = 574,
    NamePlateColorHousingField = 575,
    NamePlateColorHousingFieldEdge = 576,
    NamePlateDispTypeHousingField = 577,
    NamePlateNameTypePvPEnemy = 578,
    NamePlateDispTypeFeast = 579,
    NamePlateNameTypeFeast = 580,
    NamePlateHpTypeFeast = 581,
    NamePlateDispTypeFeastPet = 582,
    NamePlateHpTypeFeastPet = 583,
    NamePlateNameTitleTypeFeast = 584,
    NamePlateDispSize = 585,
    NamePlateDispJobIcon = 586,
    NamePlateDispJobIconType = 587,
    NamePlateSetRoleColor = 588,
    NamePlateColorTank = 589,
    NamePlateEdgeTank = 590,
    NamePlateColorHealer = 591,
    NamePlateEdgeHealer = 592,
    NamePlateColorDps = 593,
    NamePlateEdgeDps = 594,
    NamePlateColorOtherClass = 595,
    NamePlateEdgeOtherClass = 596,
    NamePlateDispWorldTravel = 597,
    NamePlateDispJobIconInPublicParty = 598,
    NamePlateDispJobIconInPublicOther = 599,
    NamePlateDispJobIconInInstanceParty = 600,
    NamePlateDispJobIconInInstanceOther = 601,
    ActiveInfo = 602,
    PartyList = 603,
    PartyListStatus = 604,
    PartyListStatusTimer = 606,
    EnemyList = 607,
    TargetInfo = 608,
    Gil = 609,
    DTR = 610,
    PlayerInfo = 612,
    NaviMap = 613,
    Help = 614,
    CrossMainHelp = 616,
    HousingLocatePreview = 618,
    Log = 619,
    LogTell = 620,
    LogFontSize = 622,
    LogTabName2 = 623,
    LogTabName3 = 624,
    LogTabFilter0 = 625,
    LogTabFilter1 = 626,
    LogTabFilter2 = 627,
    LogTabFilter3 = 628,
    LogChatFilter = 629,
    LogEnableErrMsgLv1 = 630,
    LogNameType = 632,
    LogTimeDisp = 633,
    LogTimeSettingType = 634,
    LogTimeDispType = 635,
    IsLogTell = 636,
    IsLogParty = 637,
    LogParty = 638,
    IsLogAlliance = 639,
    LogAlliance = 640,
    IsLogFc = 641,
    LogFc = 642,
    IsLogPvpTeam = 643,
    LogPvpTeam = 644,
    IsLogLs1 = 645,
    LogLs1 = 646,
    IsLogLs2 = 647,
    LogLs2 = 648,
    IsLogLs3 = 649,
    LogLs3 = 650,
    IsLogLs4 = 651,
    LogLs4 = 652,
    IsLogLs5 = 653,
    LogLs5 = 654,
    IsLogLs6 = 655,
    LogLs6 = 656,
    IsLogLs7 = 657,
    LogLs7 = 658,
    IsLogLs8 = 659,
    LogLs8 = 660,
    IsLogBeginner = 661,
    LogBeginner = 662,
    IsLogCwls = 663,
    IsLogCwls2 = 664,
    IsLogCwls3 = 665,
    IsLogCwls4 = 666,
    IsLogCwls5 = 667,
    IsLogCwls6 = 668,
    IsLogCwls7 = 669,
    IsLogCwls8 = 670,
    LogCwls = 671,
    LogCwls2 = 672,
    LogCwls3 = 673,
    LogCwls4 = 674,
    LogCwls5 = 675,
    LogCwls6 = 676,
    LogCwls7 = 677,
    LogCwls8 = 678,
    LogRecastActionErrDisp = 679,
    LogPermeationRate = 680,
    LogFontSizeForm = 681,
    LogItemLinkEnableType = 682,
    LogFontSizeLog2 = 683,
    LogTimeDispLog2 = 684,
    LogPermeationRateLog2 = 685,
    LogFontSizeLog3 = 686,
    LogTimeDispLog3 = 687,
    LogPermeationRateLog3 = 688,
    LogFontSizeLog4 = 689,
    LogTimeDispLog4 = 690,
    LogPermeationRateLog4 = 691,
    LogFlyingHeightMaxErrDisp = 692,
    LogCrossWorldName = 693,
    LogDragResize = 694,
    LogNameIconType = 695,
    LogDispClassJobName = 696,
    LogSetRoleColor = 697,
    LogColorRoleTank = 698,
    LogColorRoleHealer = 699,
    LogColorRoleDPS = 700,
    LogColorOtherClass = 701,
    ChatType = 702,
    ShopSell = 703,
    ColorSay = 704,
    ColorShout = 705,
    ColorTell = 706,
    ColorParty = 707,
    ColorAlliance = 708,
    ColorLS1 = 709,
    ColorLS2 = 710,
    ColorLS3 = 711,
    ColorLS4 = 712,
    ColorLS5 = 713,
    ColorLS6 = 714,
    ColorLS7 = 715,
    ColorLS8 = 716,
    ColorFCompany = 717,
    ColorPvPGroup = 718,
    ColorPvPGroupAnnounce = 719,
    ColorBeginner = 720,
    ColorEmoteUser = 721,
    ColorEmote = 722,
    ColorYell = 723,
    ColorBeginnerAnnounce = 725,
    ColorCWLS = 726,
    ColorCWLS2 = 727,
    ColorCWLS3 = 728,
    ColorCWLS4 = 729,
    ColorCWLS5 = 730,
    ColorCWLS6 = 731,
    ColorCWLS7 = 732,
    ColorCWLS8 = 733,
    ColorAttackSuccess = 734,
    ColorAttackFailure = 735,
    ColorAction = 736,
    ColorItem = 737,
    ColorCureGive = 738,
    ColorBuffGive = 739,
    ColorDebuffGive = 740,
    ColorEcho = 741,
    ColorSysMsg = 742,
    ColorFCAnnounce = 743,
    ColorSysBattle = 744,
    ColorSysGathering = 745,
    ColorSysErr = 746,
    ColorNpcSay = 747,
    ColorItemNotice = 748,
    ColorGrowup = 749,
    ColorLoot = 750,
    ColorCraft = 751,
    ColorGathering = 752,
    ShopConfirm = 754,
    ShopConfirmMateria = 755,
    ShopConfirmExRare = 756,
    ShopConfirmSpiritBondMax = 757,
    ItemSortItemCategory = 758,
    ItemSortEquipLevel = 759,
    ItemSortItemLevel = 760,
    ItemSortItemStack = 761,
    ItemSortTidyingType = 762,
    ItemNoArmoryMaskOff = 763,
    ItemInventryStoreEnd = 764,
    InfoSettingDispWorldNameType = 777,
    TargetNamePlateNameType = 779,
    FocusTargetNamePlateNameType = 782,
    ItemDetailTemporarilySwitch = 784,
    ItemDetailTemporarilySwitchKey = 785,
    ItemDetailTemporarilyHide = 786,
    ItemDetailTemporarilyHideKey = 787,
    ToolTipDispSize = 797,
    RecommendLoginDisp = 798,
    RecommendAreaChangeDisp = 799,
    PlayGuideLoginDisp = 800,
    PlayGuideAreaChangeDisp = 801,
    MapPadOperationYReverse = 804,
    MapPadOperationXReverse = 805,
    MapDispSize = 807,
    FlyTextDispSize = 808,
    PopUpTextDispSize = 810,
    DetailDispDelayType = 811,
    PartyListSortTypeTank = 812,
    PartyListSortTypeHealer = 813,
    PartyListSortTypeDps = 814,
    PartyListSortTypeOther = 815,
    RatioHpDisp = 816,
    BuffDispType = 817,
    ContentsFinderListSortType = 820,
    ContentsFinderSupplyEnable = 821,
    EnemyListCastbarEnable = 827,
    AchievementAppealLoginDisp = 828,
    ContentsFinderUseLangTypeJA = 829,
    ContentsFinderUseLangTypeEN = 830,
    ContentsFinderUseLangTypeDE = 831,
    ContentsFinderUseLangTypeFR = 832,
    ItemInventryWindowSizeType = 840,
    ItemInventryRetainerWindowSizeType = 841,
    BattleTalkShowFace = 847,
    BannerContentsDispType = 848,
    BannerContentsNotice = 849,
    MipDispType = 850,
    BannerContentsOrderType = 851,
    CCProgressAllyFixLeftSide = 852,
    CCMapAllyFixLeftSide = 853,
    DispCCCountDown = 854,
    EmoteTextType = 855,
    IsEmoteSe = 856,
    EmoteSeType = 857,
    PartyFinderNewArrivalDisp = 858,
    GPoseTargetFilterNPCLookAt = 859,
    GPoseMotionFilterAction = 860,
    LsListSortPriority = 861,
    FriendListSortPriority = 862,
    FriendListFilterType = 863,
    FriendListSortType = 864,
    LetterListFilterType = 865,
    LetterListSortType = 866,
    ContentsReplayEnable = 868,
    MouseWheelOperationUp = 869,
    MouseWheelOperationDown = 870,
    MouseWheelOperationCtrlUp = 871,
    MouseWheelOperationCtrlDown = 872,
    MouseWheelOperationAltUp = 873,
    MouseWheelOperationAltDown = 874,
    MouseWheelOperationShiftUp = 875,
    MouseWheelOperationShiftDown = 876,
    TelepoTicketUseType = 877,
    TelepoTicketGilSetting = 878,
    TelepoCategoryType = 879,
    HidePcAroundQuestProgressNpc = 880,
    HidePcAroundQuestProgressNpcIncludeParty = 881,
    HidePcAroundNpcAccessingQuest = 882,
    HidePcAroundNpcAccessingQuestIncludeParty = 883,
    PvPFrontlinesGCFree = 888,
    #endregion

    #region UiControl
    // <Charcter Settings>
    AutoChangePointOfView = 186,
    KeyboardCameraInterpolationType = 187,
    KeyboardCameraVerticalInterpolation = 188,
    TiltOffset = 189,
    KeyboardSpeed = 190,
    PadSpeed = 191,
    PadFpsXReverse = 193,
    PadFpsYReverse = 194,
    PadTpsXReverse = 195,
    PadTpsYReverse = 196,
    MouseFpsXReverse = 197,
    MouseFpsYReverse = 198,
    MouseTpsXReverse = 199,
    MouseTpsYReverse = 200,
    MouseCharaViewRotYReverse = 201,
    MouseCharaViewRotXReverse = 202,
    MouseCharaViewMoveYReverse = 203,
    MouseCharaViewMoveXReverse = 204,
    PADCharaViewRotYReverse = 205,
    PADCharaViewRotXReverse = 206,
    PADCharaViewMoveYReverse = 207,
    PADCharaViewMoveXReverse = 208,
    FlyingControlType = 222,
    FlyingLegacyAutorun = 223,
    // <Target Settings>
    AutoFaceTargetOnAction = 225,
    SelfClick = 226,
    NoTargetClickCancel = 227,
    AutoTarget = 228,
    TargetTypeSelect = 229,
    AutoLockOn = 230,
    CircleBattleModeAutoChange = 232,
    CircleIsCustom = 233,
    CircleSwordDrawnIsActive = 234,
    CircleSwordDrawnNonPartyPc = 235,
    CircleSwordDrawnParty = 236,
    CircleSwordDrawnEnemy = 237,
    CircleSwordDrawnAggro = 238,
    CircleSwordDrawnNpcOrObject = 239,
    CircleSwordDrawnMinion = 240,
    CircleSwordDrawnDutyEnemy = 241,
    CircleSwordDrawnPet = 242,
    CircleSwordDrawnAlliance = 243,
    CircleSwordDrawnMark = 244,
    CircleSheathedIsActive = 245,
    CircleSheathedNonPartyPc = 246,
    CircleSheathedParty = 247,
    CircleSheathedEnemy = 248,
    CircleSheathedAggro = 249,
    CircleSheathedNpcOrObject = 250,
    CircleSheathedMinion = 251,
    CircleSheathedDutyEnemy = 252,
    CircleSheathedPet = 253,
    CircleSheathedAlliance = 254,
    CircleSheathedMark = 255,
    CircleClickIsActive = 256,
    CircleClickNonPartyPc = 257,
    CircleClickParty = 258,
    CircleClickEnemy = 259,
    CircleClickAggro = 260,
    CircleClickNpcOrObject = 261,
    CircleClickMinion = 262,
    CircleClickDutyEnemy = 263,
    CircleClickPet = 264,
    CircleClickAlliance = 265,
    CircleClickMark = 266,
    CircleXButtonIsActive = 267,
    CircleXButtonNonPartyPc = 268,
    CircleXButtonParty = 269,
    CircleXButtonEnemy = 270,
    CircleXButtonAggro = 271,
    CircleXButtonNpcOrObject = 272,
    CircleXButtonMinion = 273,
    CircleXButtonDutyEnemy = 274,
    CircleXButtonPet = 275,
    CircleXButtonAlliance = 276,
    CircleXButtonMark = 277,
    CircleYButtonIsActive = 278,
    CircleYButtonNonPartyPc = 279,
    CircleYButtonParty = 280,
    CircleYButtonEnemy = 281,
    CircleYButtonAggro = 282,
    CircleYButtonNpcOrObject = 283,
    CircleYButtonMinion = 284,
    CircleYButtonDutyEnemy = 285,
    CircleYButtonPet = 286,
    CircleYButtonAlliance = 287,
    CircleYButtonMark = 288,
    CircleBButtonIsActive = 289,
    CircleBButtonNonPartyPc = 290,
    CircleBButtonParty = 291,
    CircleBButtonEnemy = 292,
    CircleBButtonAggro = 293,
    CircleBButtonNpcOrObject = 294,
    CircleBButtonMinion = 295,
    CircleBButtonDutyEnemy = 296,
    CircleBButtonPet = 297,
    CircleBButtonAlliance = 298,
    CircleBButtonMark = 299,
    CircleAButtonIsActive = 300,
    CircleAButtonNonPartyPc = 301,
    CircleAButtonParty = 302,
    CircleAButtonEnemy = 303,
    CircleAButtonAggro = 304,
    CircleAButtonNpcOrObject = 305,
    CircleAButtonMinion = 306,
    CircleAButtonDutyEnemy = 307,
    CircleAButtonPet = 308,
    CircleAButtonAlliance = 309,
    CircleAButtonMark = 310,
    GroundTargetType = 311,
    GroundTargetCursorSpeed = 312,
    TargetCircleType = 323,
    TargetLineType = 324,
    LinkLineType = 325,
    ObjectBorderingType = 326,
    MoveMode = 337,
    HotbarDisp = 363,
    HotbarEmptyVisible = 365,
    HotbarNoneSlotDisp01 = 369,
    HotbarNoneSlotDisp02 = 370,
    HotbarNoneSlotDisp03 = 371,
    HotbarNoneSlotDisp04 = 372,
    HotbarNoneSlotDisp05 = 373,
    HotbarNoneSlotDisp06 = 374,
    HotbarNoneSlotDisp07 = 375,
    HotbarNoneSlotDisp08 = 376,
    HotbarNoneSlotDisp09 = 377,
    HotbarNoneSlotDisp10 = 378,
    HotbarNoneSlotDispEX = 379,
    ExHotbarSetting = 380,
    HotbarExHotbarUseSetting = 382,
    HotbarCrossUseEx = 405,
    HotbarCrossUseExDirection = 406,
    HotbarCrossDispType = 411,
    PartyListSoloOff = 605,
    HowTo = 615,
    HousingFurnitureBindConfirm = 617,
    DirectChat = 631,
    CharaParamDisp = 765,
    LimitBreakGaugeDisp = 766,
    ScenarioTreeDisp = 767,
    ScenarioTreeCompleteDisp = 768,
    HotbarCrossDispAlways = 769,
    ExpDisp = 770,
    InventryStatusDisp = 771,
    DutyListDisp = 772,
    NaviMapDisp = 773,
    GilStatusDisp = 774,
    InfoSettingDisp = 775,
    InfoSettingDispType = 776,
    TargetInfoDisp = 778,
    EnemyListDisp = 780,
    FocusTargetDisp = 781,
    ItemDetailDisp = 783,
    ActionDetailDisp = 788,
    DetailTrackingType = 789,
    ToolTipDisp = 790,
    MapPermeationRate = 791,
    MapOperationType = 792,
    PartyListDisp = 793,
    PartyListNameType = 794,
    FlyTextDisp = 795,
    MapPermeationMode = 796,
    AllianceList1Disp = 802,
    AllianceList2Disp = 803,
    TargetInfoSelfBuff = 806,
    PopUpTextDisp = 809,
    ContentsInfoDisp = 818,
    DutyListHideWhenCntInfoDisp = 819,
    DutyListNumDisp = 822,
    InInstanceContentDutyListDisp = 823,
    InPublicContentDutyListDisp = 824,
    ContentsInfoJoiningRequestDisp = 825,
    ContentsInfoJoiningRequestSituationDisp = 826,
    HotbarDispSetNum = 833,
    HotbarDispSetChangeType = 834,
    HotbarDispSetDragType = 835,
    MainCommandType = 836,
    MainCommandDisp = 837,
    MainCommandDragShortcut = 838,
    HotbarDispLookNum = 839,
    #endregion
}
