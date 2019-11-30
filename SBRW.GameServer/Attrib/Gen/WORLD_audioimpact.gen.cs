using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_audioimpact : CollectionWrapperBase {
        #region Field Names
        public const string Name_ImpactType = "ImpactType";
        public const string Name_MomentAsset = "MomentAsset";
        public const string Name_VolMap = "VolMap";
        public const string Name_LevelMap = "LevelMap";
        public const string Name_CollectionName = "CollectionName";
        public const string Name_CullDist = "CullDist";
        public const string Name_IntensityMap = "IntensityMap";
        public const string Name_Layers = "Layers";
        #endregion

        public WORLD_audioimpact(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.String CollectionName() {
            return GetValue<System.String>("CollectionName");
        }
        public System.Single CullDist() {
            return GetValue<System.Single>("CullDist");
        }
        public VaultLib.ModernBase.StringKey ImpactType() {
            return GetValue<VaultLib.ModernBase.StringKey>("ImpactType");
        }
        public List<System.Single> IntensityMap() {
            return GetArray<System.Single>("IntensityMap");
        }
        public List<VaultLib.Support.World.VLT.COLLISIONSFX_LAYERS> Layers() {
            return GetArray<VaultLib.Support.World.VLT.COLLISIONSFX_LAYERS>("Layers");
        }
        public List<System.Byte> LevelMap() {
            return GetArray<System.Byte>("LevelMap");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> MomentAsset() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("MomentAsset");
        }
        public List<System.Single> VolMap() {
            return GetArray<System.Single>("VolMap");
        }
        #endregion

    }
}
