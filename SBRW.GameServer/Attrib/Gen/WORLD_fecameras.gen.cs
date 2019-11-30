using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_fecameras : CollectionWrapperBase {
        #region Field Names
        public const string Name_cam_roll_angle = "cam_roll_angle";
        public const string Name_0x09741459 = "0x09741459";
        public const string Name_paint_delay = "paint_delay";
        public const string Name_cam_delay = "cam_delay";
        public const string Name_cam_damping = "cam_damping";
        public const string Name_cam_angle = "cam_angle";
        public const string Name_0x39688400 = "0x39688400";
        public const string Name_cam_auto_rotate_speed = "cam_auto_rotate_speed";
        public const string Name_0x4943317C = "0x4943317C";
        public const string Name_0x5381814D = "0x5381814D";
        public const string Name_0x56B86ABB = "0x56B86ABB";
        public const string Name_0x6CF6315E = "0x6CF6315E";
        public const string Name_0x6D7C6074 = "0x6D7C6074";
        public const string Name_dof_focal = "dof_focal";
        public const string Name_cam_periods = "cam_periods";
        public const string Name_cam_orbit_horizontal = "cam_orbit_horizontal";
        public const string Name_cam_user_rotate = "cam_user_rotate";
        public const string Name_cam_car_rotate_speed = "cam_car_rotate_speed";
        public const string Name_cam_orbit_radius = "cam_orbit_radius";
        public const string Name_0xAECF1348 = "0xAECF1348";
        public const string Name_0xB121FB69 = "0xB121FB69";
        public const string Name_0xB12D448A = "0xB12D448A";
        public const string Name_0xB1B3BA0C = "0xB1B3BA0C";
        public const string Name_lightstreak_speed = "lightstreak_speed";
        public const string Name_dof_depth = "dof_depth";
        public const string Name_lightstreak_probability = "lightstreak_probability";
        public const string Name_cam_fov = "cam_fov";
        public const string Name_cam_orbit_vertical = "cam_orbit_vertical";
        public const string Name_0xCAECB37D = "0xCAECB37D";
        public const string Name_0xD6764D8A = "0xD6764D8A";
        public const string Name_0xD85DB850 = "0xD85DB850";
        public const string Name_lightstreaks = "lightstreaks";
        public const string Name_cam_blur = "cam_blur";
        public const string Name_0xF3A18D7A = "0xF3A18D7A";
        public const string Name_cam_anim_speed = "cam_anim_speed";
        #endregion

        public WORLD_fecameras(VLTCollection collection) : base(collection) {}

        #region Getters
        public VaultLib.CodeGen.RefSpecWrapper cam_angle() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("cam_angle");
        }
        public System.Single cam_anim_speed() {
            return GetValue<System.Single>("cam_anim_speed");
        }
        public System.Single cam_auto_rotate_speed() {
            return GetValue<System.Single>("cam_auto_rotate_speed");
        }
        public System.Single cam_blur() {
            return GetValue<System.Single>("cam_blur");
        }
        public System.Single cam_car_rotate_speed() {
            return GetValue<System.Single>("cam_car_rotate_speed");
        }
        public System.Single cam_damping() {
            return GetValue<System.Single>("cam_damping");
        }
        public System.Single cam_delay() {
            return GetValue<System.Single>("cam_delay");
        }
        public System.Single cam_fov() {
            return GetValue<System.Single>("cam_fov");
        }
        public List<System.Single> cam_orbit_horizontal() {
            return GetArray<System.Single>("cam_orbit_horizontal");
        }
        public List<System.Single> cam_orbit_radius() {
            return GetArray<System.Single>("cam_orbit_radius");
        }
        public List<System.Single> cam_orbit_vertical() {
            return GetArray<System.Single>("cam_orbit_vertical");
        }
        public System.Int32 cam_periods() {
            return GetValue<System.Int32>("cam_periods");
        }
        public System.Single cam_roll_angle() {
            return GetValue<System.Single>("cam_roll_angle");
        }
        public System.Boolean cam_user_rotate() {
            return GetValue<System.Boolean>("cam_user_rotate");
        }
        public System.Single dof_depth() {
            return GetValue<System.Single>("dof_depth");
        }
        public System.Single dof_focal() {
            return GetValue<System.Single>("dof_focal");
        }
        public System.Single field_0x09741459() {
            return GetValue<System.Single>("0x09741459");
        }
        public List<System.Single> field_0x39688400() {
            return GetArray<System.Single>("0x39688400");
        }
        public List<System.Single> field_0x4943317C() {
            return GetArray<System.Single>("0x4943317C");
        }
        public List<System.Single> field_0x5381814D() {
            return GetArray<System.Single>("0x5381814D");
        }
        public System.Boolean field_0x56B86ABB() {
            return GetValue<System.Boolean>("0x56B86ABB");
        }
        public List<System.Single> field_0x6CF6315E() {
            return GetArray<System.Single>("0x6CF6315E");
        }
        public List<System.Single> field_0x6D7C6074() {
            return GetArray<System.Single>("0x6D7C6074");
        }
        public List<System.Single> field_0xAECF1348() {
            return GetArray<System.Single>("0xAECF1348");
        }
        public List<System.Single> field_0xB121FB69() {
            return GetArray<System.Single>("0xB121FB69");
        }
        public List<System.Single> field_0xB12D448A() {
            return GetArray<System.Single>("0xB12D448A");
        }
        public List<System.Single> field_0xB1B3BA0C() {
            return GetArray<System.Single>("0xB1B3BA0C");
        }
        public System.Single field_0xCAECB37D() {
            return GetValue<System.Single>("0xCAECB37D");
        }
        public System.Single field_0xD6764D8A() {
            return GetValue<System.Single>("0xD6764D8A");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector2 field_0xD85DB850() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector2>("0xD85DB850");
        }
        public System.Boolean field_0xF3A18D7A() {
            return GetValue<System.Boolean>("0xF3A18D7A");
        }
        public List<System.Int32> lightstreak_probability() {
            return GetArray<System.Int32>("lightstreak_probability");
        }
        public List<System.Single> lightstreak_speed() {
            return GetArray<System.Single>("lightstreak_speed");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> lightstreaks() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("lightstreaks");
        }
        public System.Single paint_delay() {
            return GetValue<System.Single>("paint_delay");
        }
        #endregion

    }
}
