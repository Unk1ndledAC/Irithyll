using UnityEngine;

namespace IrithyllParticles
{
    /// <summary>
    /// Auto-generated particle effect script
    /// Source: f000620322.fxr
    /// Effect ID: 620322
    /// Generated emitters: 1
    /// </summary>
    public class f000620322_fxr : MonoBehaviour
    {
        void Start()
        {
            SetupParticles();
        }

        void SetupParticles()
        {
            // Emitter 1: 
            GameObject emitter1 = new GameObject("Emitter_1");
            emitter1.transform.SetParent(transform);
            emitter1.transform.localPosition = Vector3.zero;

            ParticleSystem ps1 = emitter1.AddComponent<ParticleSystem>();
            var main1 = ps1.main;
            main1.duration = 2.00f;
            main1.startLifetime = 2.00f;
            main1.startSpeed = 1.00f;
            main1.startSize = 0.100f;
            main1.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission1 = ps1.emission;
            emission1.rateOverTime = 50;

            // Shape
            var shape1 = ps1.shape;
            shape1.shapeType = ParticleSystemShapeType.Sphere;
            shape1.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer1 = emitter1.GetComponent<ParticleSystemRenderer>();
            renderer1.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

        }
    }
}
