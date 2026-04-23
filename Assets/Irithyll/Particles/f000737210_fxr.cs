using UnityEngine;

namespace IrithyllParticles
{
    /// <summary>
    /// Auto-generated particle effect script
    /// Source: f000737210.fxr
    /// Effect ID: 737210
    /// Generated emitters: 3
    /// </summary>
    public class f000737210_fxr : MonoBehaviour
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
            main1.duration = 0.20f;
            main1.startLifetime = 0.20f;
            main1.startSpeed = 1.00f;
            main1.startSize = 0.100f;
            main1.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission1 = ps1.emission;
            emission1.rateOverTime = 1000;

            // Shape
            var shape1 = ps1.shape;
            shape1.shapeType = ParticleSystemShapeType.Box;
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
            main2.duration = 0.20f;
            main2.startLifetime = 0.20f;
            main2.startSpeed = 1.00f;
            main2.startSize = 0.100f;
            main2.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission2 = ps2.emission;
            emission2.rateOverTime = 1000;

            // Shape
            var shape2 = ps2.shape;
            shape2.shapeType = ParticleSystemShapeType.Box;
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
            main3.duration = 0.20f;
            main3.startLifetime = 0.20f;
            main3.startSpeed = 1.00f;
            main3.startSize = 0.100f;
            main3.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission3 = ps3.emission;
            emission3.rateOverTime = 1000;

            // Shape
            var shape3 = ps3.shape;
            shape3.shapeType = ParticleSystemShapeType.Box;
            shape3.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer3 = emitter3.GetComponent<ParticleSystemRenderer>();
            renderer3.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

        }
    }
}
