using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_rigidbodyspecs : CollectionWrapperBase {
        #region Field Names
        public const string Name_WORLD_MOMENT_SCALE = "WORLD_MOMENT_SCALE";
        public const string Name_GRAVITY = "GRAVITY";
        public const string Name_DRAG_ANGULAR = "DRAG_ANGULAR";
        public const string Name_NO_WORLD_COLLISIONS = "NO_WORLD_COLLISIONS";
        public const string Name_INSTANCE_COLLISIONS_3D = "INSTANCE_COLLISIONS_3D";
        public const string Name_GROUND_FRICTION = "GROUND_FRICTION";
        public const string Name_BASE_MATERIAL = "BASE_MATERIAL";
        public const string Name_NO_GROUND_COLLISIONS = "NO_GROUND_COLLISIONS";
        public const string Name_NO_OBJ_COLLISIONS = "NO_OBJ_COLLISIONS";
        public const string Name_IMMOBILE_OBJECT_COLLISIONS = "IMMOBILE_OBJECT_COLLISIONS";
        public const string Name_WALL_FRICTION = "WALL_FRICTION";
        public const string Name_DEFAULT_COL_BOX = "DEFAULT_COL_BOX";
        public const string Name_COLLISION_BOX_PAD = "COLLISION_BOX_PAD";
        public const string Name_CG = "CG";
        public const string Name_GROUND_ELASTICITY = "GROUND_ELASTICITY";
        public const string Name_OBJ_ELASTICITY = "OBJ_ELASTICITY";
        public const string Name_SLEEP_VELOCITY = "SLEEP_VELOCITY";
        public const string Name_NATURAL_ANGULAR_DAMPING = "NATURAL_ANGULAR_DAMPING";
        public const string Name_GROUND_MOMENT_SCALE = "GROUND_MOMENT_SCALE";
        public const string Name_WALL_ELASTICITY = "WALL_ELASTICITY";
        public const string Name_OBJ_MOMENT_SCALE = "OBJ_MOMENT_SCALE";
        public const string Name_OBJ_FRICTION = "OBJ_FRICTION";
        public const string Name_DRAG = "DRAG";
        #endregion

        public WORLD_rigidbodyspecs(VLTCollection collection) : base(collection) {}

        #region Getters
        public VaultLib.ModernBase.StringKey BASE_MATERIAL() {
            return GetValue<VaultLib.ModernBase.StringKey>("BASE_MATERIAL");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 CG() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("CG");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 COLLISION_BOX_PAD() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("COLLISION_BOX_PAD");
        }
        public VaultLib.ModernBase.StringKey DEFAULT_COL_BOX() {
            return GetValue<VaultLib.ModernBase.StringKey>("DEFAULT_COL_BOX");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 DRAG() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("DRAG");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 DRAG_ANGULAR() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("DRAG_ANGULAR");
        }
        public System.Single GRAVITY() {
            return GetValue<System.Single>("GRAVITY");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 GROUND_ELASTICITY() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("GROUND_ELASTICITY");
        }
        public List<System.Single> GROUND_FRICTION() {
            return GetArray<System.Single>("GROUND_FRICTION");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 GROUND_MOMENT_SCALE() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("GROUND_MOMENT_SCALE");
        }
        public System.Boolean IMMOBILE_OBJECT_COLLISIONS() {
            return GetValue<System.Boolean>("IMMOBILE_OBJECT_COLLISIONS");
        }
        public System.Boolean INSTANCE_COLLISIONS_3D() {
            return GetValue<System.Boolean>("INSTANCE_COLLISIONS_3D");
        }
        public System.Single NATURAL_ANGULAR_DAMPING() {
            return GetValue<System.Single>("NATURAL_ANGULAR_DAMPING");
        }
        public System.Boolean NO_GROUND_COLLISIONS() {
            return GetValue<System.Boolean>("NO_GROUND_COLLISIONS");
        }
        public System.Boolean NO_OBJ_COLLISIONS() {
            return GetValue<System.Boolean>("NO_OBJ_COLLISIONS");
        }
        public System.Boolean NO_WORLD_COLLISIONS() {
            return GetValue<System.Boolean>("NO_WORLD_COLLISIONS");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 OBJ_ELASTICITY() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("OBJ_ELASTICITY");
        }
        public List<System.Single> OBJ_FRICTION() {
            return GetArray<System.Single>("OBJ_FRICTION");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 OBJ_MOMENT_SCALE() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("OBJ_MOMENT_SCALE");
        }
        public System.Single SLEEP_VELOCITY() {
            return GetValue<System.Single>("SLEEP_VELOCITY");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 WALL_ELASTICITY() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("WALL_ELASTICITY");
        }
        public List<System.Single> WALL_FRICTION() {
            return GetArray<System.Single>("WALL_FRICTION");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 WORLD_MOMENT_SCALE() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("WORLD_MOMENT_SCALE");
        }
        #endregion

    }
}