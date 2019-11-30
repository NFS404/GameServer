using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_skidaudio : CollectionWrapperBase {
        #region Field Names
        public const string Name_Lat_Rear = "Lat_Rear";
        public const string Name_TrafficScaler = "TrafficScaler";
        public const string Name_Drift_Long_Front = "Drift_Long_Front";
        public const string Name_Drift_Lat_Rear = "Drift_Lat_Rear";
        public const string Name_Long_Rear = "Long_Rear";
        public const string Name_Drift_Long_Rear = "Drift_Long_Rear";
        public const string Name_Long_Front = "Long_Front";
        public const string Name_PlayerScaler = "PlayerScaler";
        public const string Name_Lat_Front = "Lat_Front";
        public const string Name_Drift_Lat_Front = "Drift_Lat_Front";
        public const string Name_CopScaler = "CopScaler";
        public const string Name_AUDIOSYS_libeller = "AUDIOSYS_libeller";
        public const string Name_AIScaler = "AIScaler";
        public const string Name_ShockSqueakThresh = "ShockSqueakThresh";
        #endregion

        public WORLD_skidaudio(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Single AIScaler() {
            return GetValue<System.Single>("AIScaler");
        }
        public List<System.Single> AUDIOSYS_libeller() {
            return GetArray<System.Single>("AUDIOSYS_libeller");
        }
        public System.Single CopScaler() {
            return GetValue<System.Single>("CopScaler");
        }
        public System.Single Drift_Lat_Front() {
            return GetValue<System.Single>("Drift_Lat_Front");
        }
        public System.Single Drift_Lat_Rear() {
            return GetValue<System.Single>("Drift_Lat_Rear");
        }
        public System.Single Drift_Long_Front() {
            return GetValue<System.Single>("Drift_Long_Front");
        }
        public System.Single Drift_Long_Rear() {
            return GetValue<System.Single>("Drift_Long_Rear");
        }
        public System.Single Lat_Front() {
            return GetValue<System.Single>("Lat_Front");
        }
        public System.Single Lat_Rear() {
            return GetValue<System.Single>("Lat_Rear");
        }
        public System.Single Long_Front() {
            return GetValue<System.Single>("Long_Front");
        }
        public System.Single Long_Rear() {
            return GetValue<System.Single>("Long_Rear");
        }
        public System.Single PlayerScaler() {
            return GetValue<System.Single>("PlayerScaler");
        }
        public List<System.Single> ShockSqueakThresh() {
            return GetArray<System.Single>("ShockSqueakThresh");
        }
        public System.Single TrafficScaler() {
            return GetValue<System.Single>("TrafficScaler");
        }
        #endregion

    }
}
