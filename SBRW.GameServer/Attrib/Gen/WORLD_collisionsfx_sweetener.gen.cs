using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_collisionsfx_sweetener : CollectionWrapperBase {
        #region Field Names
        public const string Name_VelocityScaler = "VelocityScaler";
        public const string Name_VolMap = "VolMap";
        public const string Name_CollisionPriority = "CollisionPriority";
        public const string Name_LevelMap = "LevelMap";
        public const string Name_CollectionName = "CollectionName";
        public const string Name_Moment = "Moment";
        public const string Name_VelocityRange = "VelocityRange";
        public const string Name_IntensityMap = "IntensityMap";
        #endregion

        public WORLD_collisionsfx_sweetener(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.String CollectionName() {
            return GetValue<System.String>("CollectionName");
        }
        public System.Int32 CollisionPriority() {
            return GetValue<System.Int32>("CollisionPriority");
        }
        public List<System.Single> IntensityMap() {
            return GetArray<System.Single>("IntensityMap");
        }
        public List<System.UInt32> LevelMap() {
            return GetArray<System.UInt32>("LevelMap");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> Moment() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("Moment");
        }
        public List<System.Single> VelocityRange() {
            return GetArray<System.Single>("VelocityRange");
        }
        public List<System.Single> VelocityScaler() {
            return GetArray<System.Single>("VelocityScaler");
        }
        public List<System.UInt32> VolMap() {
            return GetArray<System.UInt32>("VolMap");
        }
        #endregion

    }
}
