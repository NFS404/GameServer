using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_nos : CollectionWrapperBase {
        #region Field Names
        public const string Name_RECHARGE_MIN = "RECHARGE_MIN";
        public const string Name_RECHARGE_MAX = "RECHARGE_MAX";
        public const string Name_FLOW_RATE = "FLOW_RATE";
        public const string Name_RECHARGE_MAX_SPEED = "RECHARGE_MAX_SPEED";
        public const string Name_TORQUE_BOOST = "TORQUE_BOOST";
        public const string Name_RECHARGE_MIN_SPEED = "RECHARGE_MIN_SPEED";
        public const string Name_NOS_CAPACITY = "NOS_CAPACITY";
        public const string Name_NOS_DISENGAGE = "NOS_DISENGAGE";
        #endregion

        public WORLD_nos(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Single FLOW_RATE() {
            return GetValue<System.Single>("FLOW_RATE");
        }
        public System.Single NOS_CAPACITY() {
            return GetValue<System.Single>("NOS_CAPACITY");
        }
        public System.Single NOS_DISENGAGE() {
            return GetValue<System.Single>("NOS_DISENGAGE");
        }
        public System.Single RECHARGE_MAX() {
            return GetValue<System.Single>("RECHARGE_MAX");
        }
        public System.Single RECHARGE_MAX_SPEED() {
            return GetValue<System.Single>("RECHARGE_MAX_SPEED");
        }
        public System.Single RECHARGE_MIN() {
            return GetValue<System.Single>("RECHARGE_MIN");
        }
        public System.Single RECHARGE_MIN_SPEED() {
            return GetValue<System.Single>("RECHARGE_MIN_SPEED");
        }
        public System.Single TORQUE_BOOST() {
            return GetValue<System.Single>("TORQUE_BOOST");
        }
        #endregion

    }
}
