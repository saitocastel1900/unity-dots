using Unity.Entities;
using Unity.Physics;

public class MoveSphereSystem : ComponentSystem
{

    protected override void OnUpdate()
    {
       Entities.ForEach((ref PhysicsVelocity physicsVelocity , ref SphereTagComponentData SphereTagComponentData) =>
       {
           physicsVelocity.Linear.x = 1.0f;
       });
    }
}
