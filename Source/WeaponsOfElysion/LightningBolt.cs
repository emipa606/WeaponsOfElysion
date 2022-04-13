using UnityEngine;
using Verse;

namespace WeaponsOfElysion;

public class LightningBolt : Thing
{
    private static readonly Material LightningMat = MatLoader.LoadMat("Weather/LightningBolt");
    private Mesh boltMesh;
    private Quaternion direction;
    private readonly IntVec3 hitThing;
    private readonly Vector3 origin;

    public LightningBolt(IntVec3 hitThing, Vector3 origin)
    {
        this.hitThing = hitThing;
        this.origin = origin;
    }

    public void CreateLightningBolt()
    {
        Vector3 hitPosition;
        hitPosition.x = hitThing.x;
        hitPosition.y = hitThing.y;
        hitPosition.z = hitThing.z;
        direction = Quaternion.LookRotation((hitPosition - origin).normalized);
        var distance = Vector3.Distance(origin, hitPosition);
        boltMesh = ModLightningBoltMeshMaker.NewBoltMesh(distance);

        Graphics.DrawMesh(
            boltMesh,
            origin,
            direction,
            LightningMat,
            0);
    }
}