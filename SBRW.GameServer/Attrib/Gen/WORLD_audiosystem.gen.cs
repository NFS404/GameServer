using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_audiosystem : CollectionWrapperBase {
        #region Field Names
        public const string Name_AEMS_RNBanks = "AEMS_RNBanks";
        public const string Name_FESpeech = "FESpeech";
        public const string Name_NIS_BigPath = "NIS_BigPath";
        public const string Name_NIS_ramPath = "NIS_ramPath";
        public const string Name_PATHFINDER_MusFile = "PATHFINDER_MusFile";
        public const string Name_NIS_CSIPath = "NIS_CSIPath";
        public const string Name_EVTPath = "EVTPath";
        public const string Name_EvtSys = "EvtSys";
        public const string Name_NIS_IDXPath = "NIS_IDXPath";
        public const string Name_InGameSpeech = "InGameSpeech";
        public const string Name_NIS_StreamPath = "NIS_StreamPath";
        public const string Name_DemoLicensedMusic = "DemoLicensedMusic";
        public const string Name_LicensedMusic = "LicensedMusic";
        public const string Name_BandAidFiles = "BandAidFiles";
        public const string Name_PFMapping = "PFMapping";
        public const string Name_AEMS_EnvBanks = "AEMS_EnvBanks";
        public const string Name_AEMS_NOSBanks = "AEMS_NOSBanks";
        public const string Name_AEMS_WNBanks = "AEMS_WNBanks";
        public const string Name_AEMS_FEBanks = "AEMS_FEBanks";
        public const string Name_IDXPath = "IDXPath";
        public const string Name_BIGPath = "BIGPath";
        public const string Name_0xAB458147 = "0xAB458147";
        public const string Name_0xAC6B57A1 = "0xAC6B57A1";
        public const string Name_STH_BigPath = "STH_BigPath";
        public const string Name_RwacSampleBanks = "RwacSampleBanks";
        public const string Name_PATHFINDER_MapFile = "PATHFINDER_MapFile";
        public const string Name_SpliceBank_Damage = "SpliceBank_Damage";
        public const string Name_AEMS_SkidBanks = "AEMS_SkidBanks";
        public const string Name_Locales = "Locales";
        public const string Name_HDR_BigPath = "HDR_BigPath";
        public const string Name_SpliceBank_FrontEndSpecial = "SpliceBank_FrontEndSpecial";
        public const string Name_SpliceBank_FrontEndCommon = "SpliceBank_FrontEndCommon";
        public const string Name_NIS_EVTPath = "NIS_EVTPath";
        public const string Name_SpliceBank_RadioChirps = "SpliceBank_RadioChirps";
        public const string Name_SpliceBank_Core = "SpliceBank_Core";
        public const string Name_SpliceBank_Surface = "SpliceBank_Surface";
        public const string Name_AEMS_MiscBanks = "AEMS_MiscBanks";
        public const string Name_nissfxstreams = "nissfxstreams";
        public const string Name_AmbienceStreams = "AmbienceStreams";
        public const string Name_AEMS_StitchBanks = "AEMS_StitchBanks";
        public const string Name_RaceTracks = "RaceTracks";
        public const string Name_SpliceBank_Whoosh = "SpliceBank_Whoosh";
        public const string Name_AEMS_SparkBanks = "AEMS_SparkBanks";
        public const string Name_SpliceBank_Objects = "SpliceBank_Objects";
        public const string Name_CSIPath = "CSIPath";
        public const string Name_DAT_BigPath = "DAT_BigPath";
        public const string Name_0xFEB507BC = "0xFEB507BC";
        #endregion

        public WORLD_audiosystem(VLTCollection collection) : base(collection) {}

        #region Getters
        public VaultLib.ModernBase.StringKey AEMS_EnvBanks() {
            return GetValue<VaultLib.ModernBase.StringKey>("AEMS_EnvBanks");
        }
        public List<VaultLib.ModernBase.StringKey> AEMS_FEBanks() {
            return GetArray<VaultLib.ModernBase.StringKey>("AEMS_FEBanks");
        }
        public List<VaultLib.ModernBase.StringKey> AEMS_MiscBanks() {
            return GetArray<VaultLib.ModernBase.StringKey>("AEMS_MiscBanks");
        }
        public List<VaultLib.ModernBase.StringKey> AEMS_NOSBanks() {
            return GetArray<VaultLib.ModernBase.StringKey>("AEMS_NOSBanks");
        }
        public VaultLib.ModernBase.StringKey AEMS_RNBanks() {
            return GetValue<VaultLib.ModernBase.StringKey>("AEMS_RNBanks");
        }
        public List<VaultLib.ModernBase.StringKey> AEMS_SkidBanks() {
            return GetArray<VaultLib.ModernBase.StringKey>("AEMS_SkidBanks");
        }
        public List<VaultLib.ModernBase.StringKey> AEMS_SparkBanks() {
            return GetArray<VaultLib.ModernBase.StringKey>("AEMS_SparkBanks");
        }
        public List<VaultLib.ModernBase.StringKey> AEMS_StitchBanks() {
            return GetArray<VaultLib.ModernBase.StringKey>("AEMS_StitchBanks");
        }
        public List<VaultLib.ModernBase.StringKey> AEMS_WNBanks() {
            return GetArray<VaultLib.ModernBase.StringKey>("AEMS_WNBanks");
        }
        public List<VaultLib.ModernBase.StringKey> AmbienceStreams() {
            return GetArray<VaultLib.ModernBase.StringKey>("AmbienceStreams");
        }
        public List<VaultLib.ModernBase.StringKey> BandAidFiles() {
            return GetArray<VaultLib.ModernBase.StringKey>("BandAidFiles");
        }
        public VaultLib.ModernBase.StringKey BIGPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("BIGPath");
        }
        public VaultLib.ModernBase.StringKey CSIPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("CSIPath");
        }
        public VaultLib.ModernBase.StringKey DAT_BigPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("DAT_BigPath");
        }
        public VaultLib.CodeGen.RefSpecWrapper DemoLicensedMusic() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("DemoLicensedMusic");
        }
        public VaultLib.ModernBase.StringKey EVTPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("EVTPath");
        }
        public List<VaultLib.ModernBase.StringKey> EvtSys() {
            return GetArray<VaultLib.ModernBase.StringKey>("EvtSys");
        }
        public VaultLib.CodeGen.RefSpecWrapper FESpeech() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("FESpeech");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> field_0xAB458147() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("0xAB458147");
        }
        public VaultLib.ModernBase.StringKey field_0xAC6B57A1() {
            return GetValue<VaultLib.ModernBase.StringKey>("0xAC6B57A1");
        }
        public List<System.Single> field_0xFEB507BC() {
            return GetArray<System.Single>("0xFEB507BC");
        }
        public VaultLib.ModernBase.StringKey HDR_BigPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("HDR_BigPath");
        }
        public VaultLib.ModernBase.StringKey IDXPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("IDXPath");
        }
        public VaultLib.CodeGen.RefSpecWrapper InGameSpeech() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("InGameSpeech");
        }
        public VaultLib.CodeGen.RefSpecWrapper LicensedMusic() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("LicensedMusic");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> Locales() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("Locales");
        }
        public VaultLib.ModernBase.StringKey NIS_BigPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("NIS_BigPath");
        }
        public VaultLib.ModernBase.StringKey NIS_CSIPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("NIS_CSIPath");
        }
        public VaultLib.ModernBase.StringKey NIS_EVTPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("NIS_EVTPath");
        }
        public VaultLib.ModernBase.StringKey NIS_IDXPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("NIS_IDXPath");
        }
        public VaultLib.ModernBase.StringKey NIS_ramPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("NIS_ramPath");
        }
        public VaultLib.ModernBase.StringKey NIS_StreamPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("NIS_StreamPath");
        }
        public VaultLib.CodeGen.RefSpecWrapper nissfxstreams() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("nissfxstreams");
        }
        public List<VaultLib.ModernBase.StringKey> PATHFINDER_MapFile() {
            return GetArray<VaultLib.ModernBase.StringKey>("PATHFINDER_MapFile");
        }
        public List<VaultLib.ModernBase.StringKey> PATHFINDER_MusFile() {
            return GetArray<VaultLib.ModernBase.StringKey>("PATHFINDER_MusFile");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> PFMapping() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("PFMapping");
        }
        // unknown type: PathEventEnum
        public List<VaultLib.Core.Types.VLTUnknown> RaceTracks() {
            return GetArray<VaultLib.Core.Types.VLTUnknown>("RaceTracks");
        }
        public List<VaultLib.ModernBase.StringKey> RwacSampleBanks() {
            return GetArray<VaultLib.ModernBase.StringKey>("RwacSampleBanks");
        }
        public VaultLib.ModernBase.StringKey SpliceBank_Core() {
            return GetValue<VaultLib.ModernBase.StringKey>("SpliceBank_Core");
        }
        public VaultLib.ModernBase.StringKey SpliceBank_Damage() {
            return GetValue<VaultLib.ModernBase.StringKey>("SpliceBank_Damage");
        }
        public VaultLib.ModernBase.StringKey SpliceBank_FrontEndCommon() {
            return GetValue<VaultLib.ModernBase.StringKey>("SpliceBank_FrontEndCommon");
        }
        public VaultLib.ModernBase.StringKey SpliceBank_FrontEndSpecial() {
            return GetValue<VaultLib.ModernBase.StringKey>("SpliceBank_FrontEndSpecial");
        }
        public VaultLib.ModernBase.StringKey SpliceBank_Objects() {
            return GetValue<VaultLib.ModernBase.StringKey>("SpliceBank_Objects");
        }
        public VaultLib.ModernBase.StringKey SpliceBank_RadioChirps() {
            return GetValue<VaultLib.ModernBase.StringKey>("SpliceBank_RadioChirps");
        }
        public VaultLib.ModernBase.StringKey SpliceBank_Surface() {
            return GetValue<VaultLib.ModernBase.StringKey>("SpliceBank_Surface");
        }
        public VaultLib.ModernBase.StringKey SpliceBank_Whoosh() {
            return GetValue<VaultLib.ModernBase.StringKey>("SpliceBank_Whoosh");
        }
        public VaultLib.ModernBase.StringKey STH_BigPath() {
            return GetValue<VaultLib.ModernBase.StringKey>("STH_BigPath");
        }
        #endregion

    }
}
