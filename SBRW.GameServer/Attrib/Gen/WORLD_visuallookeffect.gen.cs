using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_visuallookeffect : CollectionWrapperBase {
        #region Field Names
        public const string Name_heattrigger = "heattrigger";
        public const string Name__testvalue = "_testvalue";
        public const string Name_graph = "graph";
        public const string Name_radialblur_uvoffset = "radialblur_uvoffset";
        public const string Name_magnitude = "magnitude";
        public const string Name_radialblur_scale = "radialblur_scale";
        public const string Name_length = "length";
        #endregion

        public WORLD_visuallookeffect(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Single _testvalue() {
            return GetValue<System.Single>("_testvalue");
        }
        public VaultLib.Core.Types.Attrib.Types.Matrix graph() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Matrix>("graph");
        }
        public System.Single heattrigger() {
            return GetValue<System.Single>("heattrigger");
        }
        public System.Single length() {
            return GetValue<System.Single>("length");
        }
        public System.Single magnitude() {
            return GetValue<System.Single>("magnitude");
        }
        public System.Single radialblur_scale() {
            return GetValue<System.Single>("radialblur_scale");
        }
        public System.Single radialblur_uvoffset() {
            return GetValue<System.Single>("radialblur_uvoffset");
        }
        #endregion

    }
}
