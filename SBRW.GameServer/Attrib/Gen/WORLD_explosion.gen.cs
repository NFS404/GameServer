using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_explosion : CollectionWrapperBase {
        #region Field Names
        public const string Name_explosionForceLimit = "explosionForceLimit";
        public const string Name_fallOffUnit = "fallOffUnit";
        public const string Name_forceMultiplier = "forceMultiplier";
        public const string Name_BaseMaterial = "BaseMaterial";
        public const string Name_triggerThreshold = "triggerThreshold";
        public const string Name_damageMultiplier = "damageMultiplier";
        #endregion

        public WORLD_explosion(VLTCollection collection) : base(collection) {}

        #region Getters
        public VaultLib.CodeGen.RefSpecWrapper BaseMaterial() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("BaseMaterial");
        }
        public System.Single damageMultiplier() {
            return GetValue<System.Single>("damageMultiplier");
        }
        public System.Single explosionForceLimit() {
            return GetValue<System.Single>("explosionForceLimit");
        }
        public System.Single fallOffUnit() {
            return GetValue<System.Single>("fallOffUnit");
        }
        public System.Single forceMultiplier() {
            return GetValue<System.Single>("forceMultiplier");
        }
        public System.Single triggerThreshold() {
            return GetValue<System.Single>("triggerThreshold");
        }
        #endregion

    }
}
