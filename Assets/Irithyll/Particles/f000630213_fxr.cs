using UnityEngine;

namespace IrithyllParticles
{
    /// <summary>
    /// Auto-generated particle effect script
    /// Source: f000630213.fxr
    /// Effect ID: 630213
    /// Generated emitters: 6
    /// </summary>
    public class f000630213_fxr : MonoBehaviour
    {
        void Start()
        {
            SetupParticles();
        }

        void SetupParticles()
        {
            // Emitter 1: Emitter_1004
            GameObject emitter1 = new GameObject("Emitter_1");
            emitter1.transform.SetParent(transform);
            emitter1.transform.localPosition = Vector3.zero;

            ParticleSystem ps1 = emitter1.AddComponent<ParticleSystem>();
            var main1 = ps1.main;
            main1.duration = 4.00f;
            main1.startLifetime = 4.00f;
            main1.startSpeed = 1.00f;
            main1.startSize = 0.100f;
            main1.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission1 = ps1.emission;
            emission1.rateOverTime = 3;

            // Shape
            var shape1 = ps1.shape;
            shape1.shapeType = ParticleSystemShapeType.Sphere;
            shape1.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer1 = emitter1.GetComponent<ParticleSystemRenderer>();
            renderer1.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 2: Emitter_1004
            GameObject emitter2 = new GameObject("Emitter_2");
            emitter2.transform.SetParent(transform);
            emitter2.transform.localPosition = Vector3.zero;

            ParticleSystem ps2 = emitter2.AddComponent<ParticleSystem>();
            var main2 = ps2.main;
            main2.duration = 2.00f;
            main2.startLifetime = 2.00f;
            main2.startSpeed = 1.00f;
            main2.startSize = 0.100f;
            main2.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission2 = ps2.emission;
            emission2.rateOverTime = 3;

            // Shape
            var shape2 = ps2.shape;
            shape2.shapeType = ParticleSystemShapeType.Sphere;
            shape2.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer2 = emitter2.GetComponent<ParticleSystemRenderer>();
            renderer2.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 3: Emitter_1004
            GameObject emitter3 = new GameObject("Emitter_3");
            emitter3.transform.SetParent(transform);
            emitter3.transform.localPosition = Vector3.zero;

            ParticleSystem ps3 = emitter3.AddComponent<ParticleSystem>();
            var main3 = ps3.main;
            main3.duration = 4.00f;
            main3.startLifetime = 4.00f;
            main3.startSpeed = 1.00f;
            main3.startSize = 0.100f;
            main3.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission3 = ps3.emission;
            emission3.rateOverTime = 3;

            // Shape
            var shape3 = ps3.shape;
            shape3.shapeType = ParticleSystemShapeType.Sphere;
            shape3.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer3 = emitter3.GetComponent<ParticleSystemRenderer>();
            renderer3.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 4: Emitter_1004
            GameObject emitter4 = new GameObject("Emitter_4");
            emitter4.transform.SetParent(transform);
            emitter4.transform.localPosition = Vector3.zero;

            ParticleSystem ps4 = emitter4.AddComponent<ParticleSystem>();
            var main4 = ps4.main;
            main4.duration = 2.00f;
            main4.startLifetime = 2.00f;
            main4.startSpeed = 1.00f;
            main4.startSize = 0.100f;
            main4.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission4 = ps4.emission;
            emission4.rateOverTime = 3;

            // Shape
            var shape4 = ps4.shape;
            shape4.shapeType = ParticleSystemShapeType.Sphere;
            shape4.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer4 = emitter4.GetComponent<ParticleSystemRenderer>();
            renderer4.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 5: Emitter_1004
            GameObject emitter5 = new GameObject("Emitter_5");
            emitter5.transform.SetParent(transform);
            emitter5.transform.localPosition = Vector3.zero;

            ParticleSystem ps5 = emitter5.AddComponent<ParticleSystem>();
            var main5 = ps5.main;
            main5.duration = 4.00f;
            main5.startLifetime = 4.00f;
            main5.startSpeed = 1.00f;
            main5.startSize = 0.100f;
            main5.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission5 = ps5.emission;
            emission5.rateOverTime = 3;

            // Shape
            var shape5 = ps5.shape;
            shape5.shapeType = ParticleSystemShapeType.Sphere;
            shape5.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer5 = emitter5.GetComponent<ParticleSystemRenderer>();
            renderer5.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 6: Emitter_1004
            GameObject emitter6 = new GameObject("Emitter_6");
            emitter6.transform.SetParent(transform);
            emitter6.transform.localPosition = Vector3.zero;

            ParticleSystem ps6 = emitter6.AddComponent<ParticleSystem>();
            var main6 = ps6.main;
            main6.duration = 2.00f;
            main6.startLifetime = 2.00f;
            main6.startSpeed = 1.00f;
            main6.startSize = 0.100f;
            main6.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission6 = ps6.emission;
            emission6.rateOverTime = 3;

            // Shape
            var shape6 = ps6.shape;
            shape6.shapeType = ParticleSystemShapeType.Sphere;
            shape6.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer6 = emitter6.GetComponent<ParticleSystemRenderer>();
            renderer6.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

        }
    }
}
