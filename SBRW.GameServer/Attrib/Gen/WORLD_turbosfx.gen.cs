using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_turbosfx : CollectionWrapperBase {
        #region Field Names
        public const string Name_FlutterAmp = "FlutterAmp";
        public const string Name_BlowoffIntensityThreshold = "BlowoffIntensityThreshold";
        public const string Name_FlutterPeriod = "FlutterPeriod";
        public const string Name_MinRPMThreshold = "MinRPMThreshold";
        public const string Name_SpoolTime = "SpoolTime";
        public const string Name_Volume = "Volume";
        public const string Name_AI_BankName = "AI_BankName";
        public const string Name_LoadThreshold = "LoadThreshold";
        public const string Name_BankName = "BankName";
        public const string Name_ThrottleThreshold = "ThrottleThreshold";
        public const string Name_Lag = "Lag";
        #endregion

        public WORLD_turbosfx(VLTCollection collection) : base(collection) {}

        #region Getters
        public VaultLib.ModernBase.StringKey AI_BankName() {
            return GetValue<VaultLib.ModernBase.StringKey>("AI_BankName");
        }
        public VaultLib.ModernBase.StringKey BankName() {
            return GetValue<VaultLib.ModernBase.StringKey>("BankName");
        }
        public List<System.Single> BlowoffIntensityThreshold() {
            return GetArray<System.Single>("BlowoffIntensityThreshold");
        }
        public System.Int32 FlutterAmp() {
            return GetValue<System.Int32>("FlutterAmp");
        }
        public System.Int32 FlutterPeriod() {
            return GetValue<System.Int32>("FlutterPeriod");
        }
        public List<System.Single> Lag() {
            return GetArray<System.Single>("Lag");
        }
        public List<System.Single> LoadThreshold() {
            return GetArray<System.Single>("LoadThreshold");
        }
        public System.Single MinRPMThreshold() {
            return GetValue<System.Single>("MinRPMThreshold");
        }
        public List<System.Single> SpoolTime() {
            return GetArray<System.Single>("SpoolTime");
        }
        public System.Single ThrottleThreshold() {
            return GetValue<System.Single>("ThrottleThreshold");
        }
        public List<System.Int32> Volume() {
            return GetArray<System.Int32>("Volume");
        }
        #endregion

    }
}
