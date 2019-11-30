using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_traffic_horn : CollectionWrapperBase {
        #region Field Names
        public const string Name_HornSequence = "HornSequence";
        public const string Name_CollectionName = "CollectionName";
        public const string Name_0xB59141BA = "0xB59141BA";
        #endregion

        public WORLD_traffic_horn(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.String CollectionName() {
            return GetValue<System.String>("CollectionName");
        }
        public VaultLib.Support.World.VLT.Attrib.Query.Static_Inorder_N_to_1 field_0xB59141BA() {
            return GetValue<VaultLib.Support.World.VLT.Attrib.Query.Static_Inorder_N_to_1>("0xB59141BA");
        }
        public List<VaultLib.Support.World.VLT.Sound.BinarySequence> HornSequence() {
            return GetArray<VaultLib.Support.World.VLT.Sound.BinarySequence>("HornSequence");
        }
        #endregion

    }
}
