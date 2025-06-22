using RimWorld;
using Verse;
using Verse.Sound;

namespace WeaponsOfElysion;

public class ExplodingBullet : Projectile
{
    protected override void Impact(Thing hitThing, bool blockedByShield = false)
    {
        var map = Map;
        base.Impact(hitThing, blockedByShield);
        var damageAmountBase = def.projectile.GetDamageAmount(launcher);
        if (hitThing != null)
        {
            GenExplosion.DoExplosion(hitThing.Position, map, 0.2f, DamageDefOf.Bomb, null, damageAmountBase);
            var thingDef = equipmentDef;
            hitThing.TakeDamage(new DamageInfo(def.projectile.damageDef, damageAmountBase, ExactRotation.eulerAngles.y,
                -1f,
                launcher, null, thingDef));
            return;
        }

        GenExplosion.DoExplosion(Position, map, 0.2f, DamageDefOf.Bomb, null, damageAmountBase);
        SoundDefOf.BulletImpact_Ground.PlayOneShot(new TargetInfo(Position, map));
        FleckMaker.Static(ExactPosition, map, FleckDefOf.ShotHit_Dirt);
    }
}