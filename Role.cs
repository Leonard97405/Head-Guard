using LabApi.Features.Wrappers;
using NetRoleManager;
using PlayerRoles;
using UnityEngine;

namespace HeadGuard
{
    public class Role : CustomRole
    {
        public override string RoleId { get; set; } = "headguard";
        public override string Name { get; set; } = "Head Guard";
        public override string Description { get; set; } = "Sei il capo delle guardie, hai una keycard migliore";
        public override RoleTypeId RoleTypeId { get; set; } = RoleTypeId.FacilityGuard;
        public override int SpawnChance { get; set; } = 0;
        public override string Color { get; set; } = "grey";

        public override ItemType[] Inventory { get; set; } = new[]
        {
            ItemType.ArmorHeavy,
            ItemType.KeycardMTFPrivate,
            ItemType.GunCOM18,
            ItemType.Painkillers,
        };

        public override void OnRoleAdded(Player player)
        {
            player.MaxHealth = Plugin.Singleton.Config?.maxhp ?? 120;
            player.Heal(1000);
            player.Scale = new Vector3(1.1f, 1.1f, 1.1f);
            player.AddAmmo(ItemType.Ammo9x19,90);
        }
    }
}