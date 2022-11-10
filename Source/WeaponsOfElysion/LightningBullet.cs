using RimWorld;
using Verse;
using Verse.Sound;

namespace WeaponsOfElysion;

public class LightningBullet : Projectile
{
    protected override void Impact(Thing hitThing, bool blockedByShield = false)
    {
        var map = Map;
        base.Impact(hitThing, blockedByShield);
        if (hitThing != null)
        {
            var damageAmountBase = def.projectile.GetDamageAmount(launcher);
            var lightning = new LightningBolt(hitThing.Position, origin);
            lightning.CreateLightningBolt();
            var thingDef = equipmentDef;
            var dinfo = new DamageInfo(def.projectile.damageDef, damageAmountBase, ExactRotation.eulerAngles.y, -1f,
                launcher, null, thingDef);
            hitThing.TakeDamage(dinfo);
            var deinfo = new DamageInfo(DamageDefOf.EMP, 15, ExactRotation.eulerAngles.y, -1f, launcher, null,
                thingDef);
            hitThing.TakeDamage(deinfo);
        }
        else
        {
            var lightning = new LightningBolt(Position, origin);
            lightning.CreateLightningBolt();
            SoundDefOf.BulletImpact_Ground.PlayOneShot(new TargetInfo(Position, map));
            FleckMaker.Static(ExactPosition, map, FleckDefOf.ShotHit_Dirt);
        }
    }
}