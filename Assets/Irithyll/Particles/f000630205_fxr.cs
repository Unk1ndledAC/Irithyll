using UnityEngine;

namespace IrithyllParticles
{
    /// <summary>
    /// Auto-generated particle effect script
    /// Source: f000630205.fxr
    /// Effect ID: 630205
    /// Generated emitters: 125
    /// </summary>
    public class f000630205_fxr : MonoBehaviour
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

            // Emitter 2: Emitter_1005
            GameObject emitter2 = new GameObject("Emitter_2");
            emitter2.transform.SetParent(transform);
            emitter2.transform.localPosition = Vector3.zero;

            ParticleSystem ps2 = emitter2.AddComponent<ParticleSystem>();
            var main2 = ps2.main;
            main2.duration = 0.03f;
            main2.startLifetime = 0.03f;
            main2.startSpeed = 1.00f;
            main2.startSize = 0.100f;
            main2.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission2 = ps2.emission;
            emission2.rateOverTime = 50;

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
            main3.duration = 3.00f;
            main3.startLifetime = 3.00f;
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
            shape4.shapeType = ParticleSystemShapeType.Box;
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
            main5.duration = 0.20f;
            main5.startLifetime = 0.20f;
            main5.startSpeed = 1.00f;
            main5.startSize = 0.100f;
            main5.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission5 = ps5.emission;
            emission5.rateOverTime = 80;

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
            main6.duration = 0.50f;
            main6.startLifetime = 0.50f;
            main6.startSpeed = 1.00f;
            main6.startSize = 0.100f;
            main6.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission6 = ps6.emission;
            emission6.rateOverTime = 3;

            // Shape
            var shape6 = ps6.shape;
            shape6.shapeType = ParticleSystemShapeType.Box;
            shape6.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer6 = emitter6.GetComponent<ParticleSystemRenderer>();
            renderer6.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 7: Emitter_1004
            GameObject emitter7 = new GameObject("Emitter_7");
            emitter7.transform.SetParent(transform);
            emitter7.transform.localPosition = Vector3.zero;

            ParticleSystem ps7 = emitter7.AddComponent<ParticleSystem>();
            var main7 = ps7.main;
            main7.duration = 0.10f;
            main7.startLifetime = 0.10f;
            main7.startSpeed = 1.00f;
            main7.startSize = 0.100f;
            main7.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission7 = ps7.emission;
            emission7.rateOverTime = 1;

            // Shape
            var shape7 = ps7.shape;
            shape7.shapeType = ParticleSystemShapeType.Sphere;
            shape7.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer7 = emitter7.GetComponent<ParticleSystemRenderer>();
            renderer7.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 8: Emitter_1004
            GameObject emitter8 = new GameObject("Emitter_8");
            emitter8.transform.SetParent(transform);
            emitter8.transform.localPosition = Vector3.zero;

            ParticleSystem ps8 = emitter8.AddComponent<ParticleSystem>();
            var main8 = ps8.main;
            main8.duration = 0.90f;
            main8.startLifetime = 0.90f;
            main8.startSpeed = 1.00f;
            main8.startSize = 0.100f;
            main8.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission8 = ps8.emission;
            emission8.rateOverTime = 3;

            // Shape
            var shape8 = ps8.shape;
            shape8.shapeType = ParticleSystemShapeType.Box;
            shape8.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer8 = emitter8.GetComponent<ParticleSystemRenderer>();
            renderer8.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 9: Emitter_1005
            GameObject emitter9 = new GameObject("Emitter_9");
            emitter9.transform.SetParent(transform);
            emitter9.transform.localPosition = Vector3.zero;

            ParticleSystem ps9 = emitter9.AddComponent<ParticleSystem>();
            var main9 = ps9.main;
            main9.duration = 0.20f;
            main9.startLifetime = 0.20f;
            main9.startSpeed = 1.00f;
            main9.startSize = 0.100f;
            main9.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission9 = ps9.emission;
            emission9.rateOverTime = 50;

            // Shape
            var shape9 = ps9.shape;
            shape9.shapeType = ParticleSystemShapeType.Sphere;
            shape9.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer9 = emitter9.GetComponent<ParticleSystemRenderer>();
            renderer9.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 10: Emitter_1004
            GameObject emitter10 = new GameObject("Emitter_10");
            emitter10.transform.SetParent(transform);
            emitter10.transform.localPosition = Vector3.zero;

            ParticleSystem ps10 = emitter10.AddComponent<ParticleSystem>();
            var main10 = ps10.main;
            main10.duration = 1.50f;
            main10.startLifetime = 1.50f;
            main10.startSpeed = 1.00f;
            main10.startSize = 0.100f;
            main10.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission10 = ps10.emission;
            emission10.rateOverTime = 3;

            // Shape
            var shape10 = ps10.shape;
            shape10.shapeType = ParticleSystemShapeType.Sphere;
            shape10.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer10 = emitter10.GetComponent<ParticleSystemRenderer>();
            renderer10.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 11: Emitter_1004
            GameObject emitter11 = new GameObject("Emitter_11");
            emitter11.transform.SetParent(transform);
            emitter11.transform.localPosition = Vector3.zero;

            ParticleSystem ps11 = emitter11.AddComponent<ParticleSystem>();
            var main11 = ps11.main;
            main11.duration = 1.50f;
            main11.startLifetime = 1.50f;
            main11.startSpeed = 1.00f;
            main11.startSize = 0.100f;
            main11.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission11 = ps11.emission;
            emission11.rateOverTime = 3;

            // Shape
            var shape11 = ps11.shape;
            shape11.shapeType = ParticleSystemShapeType.Sphere;
            shape11.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer11 = emitter11.GetComponent<ParticleSystemRenderer>();
            renderer11.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 12: Emitter_1004
            GameObject emitter12 = new GameObject("Emitter_12");
            emitter12.transform.SetParent(transform);
            emitter12.transform.localPosition = Vector3.zero;

            ParticleSystem ps12 = emitter12.AddComponent<ParticleSystem>();
            var main12 = ps12.main;
            main12.duration = 0.03f;
            main12.startLifetime = 0.03f;
            main12.startSpeed = 1.00f;
            main12.startSize = 0.100f;
            main12.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission12 = ps12.emission;
            emission12.rateOverTime = 1;

            // Shape
            var shape12 = ps12.shape;
            shape12.shapeType = ParticleSystemShapeType.Sphere;
            shape12.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer12 = emitter12.GetComponent<ParticleSystemRenderer>();
            renderer12.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 13: Emitter_1004
            GameObject emitter13 = new GameObject("Emitter_13");
            emitter13.transform.SetParent(transform);
            emitter13.transform.localPosition = Vector3.zero;

            ParticleSystem ps13 = emitter13.AddComponent<ParticleSystem>();
            var main13 = ps13.main;
            main13.duration = 0.03f;
            main13.startLifetime = 0.03f;
            main13.startSpeed = 1.00f;
            main13.startSize = 0.100f;
            main13.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission13 = ps13.emission;
            emission13.rateOverTime = 133;

            // Shape
            var shape13 = ps13.shape;
            shape13.shapeType = ParticleSystemShapeType.Sphere;
            shape13.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer13 = emitter13.GetComponent<ParticleSystemRenderer>();
            renderer13.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 14: Emitter_1004
            GameObject emitter14 = new GameObject("Emitter_14");
            emitter14.transform.SetParent(transform);
            emitter14.transform.localPosition = Vector3.zero;

            ParticleSystem ps14 = emitter14.AddComponent<ParticleSystem>();
            var main14 = ps14.main;
            main14.duration = 2.00f;
            main14.startLifetime = 2.00f;
            main14.startSpeed = 1.00f;
            main14.startSize = 0.100f;
            main14.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission14 = ps14.emission;
            emission14.rateOverTime = 3;

            // Shape
            var shape14 = ps14.shape;
            shape14.shapeType = ParticleSystemShapeType.Sphere;
            shape14.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer14 = emitter14.GetComponent<ParticleSystemRenderer>();
            renderer14.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 15: Emitter_1004
            GameObject emitter15 = new GameObject("Emitter_15");
            emitter15.transform.SetParent(transform);
            emitter15.transform.localPosition = Vector3.zero;

            ParticleSystem ps15 = emitter15.AddComponent<ParticleSystem>();
            var main15 = ps15.main;
            main15.duration = 4.00f;
            main15.startLifetime = 4.00f;
            main15.startSpeed = 1.00f;
            main15.startSize = 0.100f;
            main15.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission15 = ps15.emission;
            emission15.rateOverTime = 3;

            // Shape
            var shape15 = ps15.shape;
            shape15.shapeType = ParticleSystemShapeType.Sphere;
            shape15.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer15 = emitter15.GetComponent<ParticleSystemRenderer>();
            renderer15.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 16: Emitter_1005
            GameObject emitter16 = new GameObject("Emitter_16");
            emitter16.transform.SetParent(transform);
            emitter16.transform.localPosition = Vector3.zero;

            ParticleSystem ps16 = emitter16.AddComponent<ParticleSystem>();
            var main16 = ps16.main;
            main16.duration = 0.03f;
            main16.startLifetime = 0.03f;
            main16.startSpeed = 1.00f;
            main16.startSize = 0.100f;
            main16.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission16 = ps16.emission;
            emission16.rateOverTime = 50;

            // Shape
            var shape16 = ps16.shape;
            shape16.shapeType = ParticleSystemShapeType.Sphere;
            shape16.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer16 = emitter16.GetComponent<ParticleSystemRenderer>();
            renderer16.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 17: Emitter_1004
            GameObject emitter17 = new GameObject("Emitter_17");
            emitter17.transform.SetParent(transform);
            emitter17.transform.localPosition = Vector3.zero;

            ParticleSystem ps17 = emitter17.AddComponent<ParticleSystem>();
            var main17 = ps17.main;
            main17.duration = 3.00f;
            main17.startLifetime = 3.00f;
            main17.startSpeed = 1.00f;
            main17.startSize = 0.100f;
            main17.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission17 = ps17.emission;
            emission17.rateOverTime = 3;

            // Shape
            var shape17 = ps17.shape;
            shape17.shapeType = ParticleSystemShapeType.Sphere;
            shape17.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer17 = emitter17.GetComponent<ParticleSystemRenderer>();
            renderer17.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 18: Emitter_1004
            GameObject emitter18 = new GameObject("Emitter_18");
            emitter18.transform.SetParent(transform);
            emitter18.transform.localPosition = Vector3.zero;

            ParticleSystem ps18 = emitter18.AddComponent<ParticleSystem>();
            var main18 = ps18.main;
            main18.duration = 2.00f;
            main18.startLifetime = 2.00f;
            main18.startSpeed = 1.00f;
            main18.startSize = 0.100f;
            main18.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission18 = ps18.emission;
            emission18.rateOverTime = 3;

            // Shape
            var shape18 = ps18.shape;
            shape18.shapeType = ParticleSystemShapeType.Box;
            shape18.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer18 = emitter18.GetComponent<ParticleSystemRenderer>();
            renderer18.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 19: Emitter_1004
            GameObject emitter19 = new GameObject("Emitter_19");
            emitter19.transform.SetParent(transform);
            emitter19.transform.localPosition = Vector3.zero;

            ParticleSystem ps19 = emitter19.AddComponent<ParticleSystem>();
            var main19 = ps19.main;
            main19.duration = 0.20f;
            main19.startLifetime = 0.20f;
            main19.startSpeed = 1.00f;
            main19.startSize = 0.100f;
            main19.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission19 = ps19.emission;
            emission19.rateOverTime = 80;

            // Shape
            var shape19 = ps19.shape;
            shape19.shapeType = ParticleSystemShapeType.Sphere;
            shape19.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer19 = emitter19.GetComponent<ParticleSystemRenderer>();
            renderer19.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 20: Emitter_1004
            GameObject emitter20 = new GameObject("Emitter_20");
            emitter20.transform.SetParent(transform);
            emitter20.transform.localPosition = Vector3.zero;

            ParticleSystem ps20 = emitter20.AddComponent<ParticleSystem>();
            var main20 = ps20.main;
            main20.duration = 0.50f;
            main20.startLifetime = 0.50f;
            main20.startSpeed = 1.00f;
            main20.startSize = 0.100f;
            main20.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission20 = ps20.emission;
            emission20.rateOverTime = 3;

            // Shape
            var shape20 = ps20.shape;
            shape20.shapeType = ParticleSystemShapeType.Box;
            shape20.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer20 = emitter20.GetComponent<ParticleSystemRenderer>();
            renderer20.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 21: Emitter_1004
            GameObject emitter21 = new GameObject("Emitter_21");
            emitter21.transform.SetParent(transform);
            emitter21.transform.localPosition = Vector3.zero;

            ParticleSystem ps21 = emitter21.AddComponent<ParticleSystem>();
            var main21 = ps21.main;
            main21.duration = 0.10f;
            main21.startLifetime = 0.10f;
            main21.startSpeed = 1.00f;
            main21.startSize = 0.100f;
            main21.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission21 = ps21.emission;
            emission21.rateOverTime = 1;

            // Shape
            var shape21 = ps21.shape;
            shape21.shapeType = ParticleSystemShapeType.Sphere;
            shape21.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer21 = emitter21.GetComponent<ParticleSystemRenderer>();
            renderer21.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 22: Emitter_1004
            GameObject emitter22 = new GameObject("Emitter_22");
            emitter22.transform.SetParent(transform);
            emitter22.transform.localPosition = Vector3.zero;

            ParticleSystem ps22 = emitter22.AddComponent<ParticleSystem>();
            var main22 = ps22.main;
            main22.duration = 0.90f;
            main22.startLifetime = 0.90f;
            main22.startSpeed = 1.00f;
            main22.startSize = 0.100f;
            main22.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission22 = ps22.emission;
            emission22.rateOverTime = 3;

            // Shape
            var shape22 = ps22.shape;
            shape22.shapeType = ParticleSystemShapeType.Box;
            shape22.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer22 = emitter22.GetComponent<ParticleSystemRenderer>();
            renderer22.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 23: Emitter_1005
            GameObject emitter23 = new GameObject("Emitter_23");
            emitter23.transform.SetParent(transform);
            emitter23.transform.localPosition = Vector3.zero;

            ParticleSystem ps23 = emitter23.AddComponent<ParticleSystem>();
            var main23 = ps23.main;
            main23.duration = 0.20f;
            main23.startLifetime = 0.20f;
            main23.startSpeed = 1.00f;
            main23.startSize = 0.100f;
            main23.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission23 = ps23.emission;
            emission23.rateOverTime = 50;

            // Shape
            var shape23 = ps23.shape;
            shape23.shapeType = ParticleSystemShapeType.Sphere;
            shape23.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer23 = emitter23.GetComponent<ParticleSystemRenderer>();
            renderer23.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 24: Emitter_1004
            GameObject emitter24 = new GameObject("Emitter_24");
            emitter24.transform.SetParent(transform);
            emitter24.transform.localPosition = Vector3.zero;

            ParticleSystem ps24 = emitter24.AddComponent<ParticleSystem>();
            var main24 = ps24.main;
            main24.duration = 1.50f;
            main24.startLifetime = 1.50f;
            main24.startSpeed = 1.00f;
            main24.startSize = 0.100f;
            main24.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission24 = ps24.emission;
            emission24.rateOverTime = 3;

            // Shape
            var shape24 = ps24.shape;
            shape24.shapeType = ParticleSystemShapeType.Sphere;
            shape24.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer24 = emitter24.GetComponent<ParticleSystemRenderer>();
            renderer24.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 25: Emitter_1004
            GameObject emitter25 = new GameObject("Emitter_25");
            emitter25.transform.SetParent(transform);
            emitter25.transform.localPosition = Vector3.zero;

            ParticleSystem ps25 = emitter25.AddComponent<ParticleSystem>();
            var main25 = ps25.main;
            main25.duration = 1.50f;
            main25.startLifetime = 1.50f;
            main25.startSpeed = 1.00f;
            main25.startSize = 0.100f;
            main25.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission25 = ps25.emission;
            emission25.rateOverTime = 3;

            // Shape
            var shape25 = ps25.shape;
            shape25.shapeType = ParticleSystemShapeType.Sphere;
            shape25.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer25 = emitter25.GetComponent<ParticleSystemRenderer>();
            renderer25.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 26: Emitter_1004
            GameObject emitter26 = new GameObject("Emitter_26");
            emitter26.transform.SetParent(transform);
            emitter26.transform.localPosition = Vector3.zero;

            ParticleSystem ps26 = emitter26.AddComponent<ParticleSystem>();
            var main26 = ps26.main;
            main26.duration = 0.03f;
            main26.startLifetime = 0.03f;
            main26.startSpeed = 1.00f;
            main26.startSize = 0.100f;
            main26.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission26 = ps26.emission;
            emission26.rateOverTime = 1;

            // Shape
            var shape26 = ps26.shape;
            shape26.shapeType = ParticleSystemShapeType.Sphere;
            shape26.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer26 = emitter26.GetComponent<ParticleSystemRenderer>();
            renderer26.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 27: Emitter_1004
            GameObject emitter27 = new GameObject("Emitter_27");
            emitter27.transform.SetParent(transform);
            emitter27.transform.localPosition = Vector3.zero;

            ParticleSystem ps27 = emitter27.AddComponent<ParticleSystem>();
            var main27 = ps27.main;
            main27.duration = 0.03f;
            main27.startLifetime = 0.03f;
            main27.startSpeed = 1.00f;
            main27.startSize = 0.100f;
            main27.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission27 = ps27.emission;
            emission27.rateOverTime = 133;

            // Shape
            var shape27 = ps27.shape;
            shape27.shapeType = ParticleSystemShapeType.Sphere;
            shape27.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer27 = emitter27.GetComponent<ParticleSystemRenderer>();
            renderer27.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 28: Emitter_1004
            GameObject emitter28 = new GameObject("Emitter_28");
            emitter28.transform.SetParent(transform);
            emitter28.transform.localPosition = Vector3.zero;

            ParticleSystem ps28 = emitter28.AddComponent<ParticleSystem>();
            var main28 = ps28.main;
            main28.duration = 3.00f;
            main28.startLifetime = 3.00f;
            main28.startSpeed = 1.00f;
            main28.startSize = 0.100f;
            main28.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission28 = ps28.emission;
            emission28.rateOverTime = 3;

            // Shape
            var shape28 = ps28.shape;
            shape28.shapeType = ParticleSystemShapeType.Sphere;
            shape28.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer28 = emitter28.GetComponent<ParticleSystemRenderer>();
            renderer28.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 29: Emitter_1004
            GameObject emitter29 = new GameObject("Emitter_29");
            emitter29.transform.SetParent(transform);
            emitter29.transform.localPosition = Vector3.zero;

            ParticleSystem ps29 = emitter29.AddComponent<ParticleSystem>();
            var main29 = ps29.main;
            main29.duration = 2.00f;
            main29.startLifetime = 2.00f;
            main29.startSpeed = 1.00f;
            main29.startSize = 0.100f;
            main29.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission29 = ps29.emission;
            emission29.rateOverTime = 3;

            // Shape
            var shape29 = ps29.shape;
            shape29.shapeType = ParticleSystemShapeType.Box;
            shape29.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer29 = emitter29.GetComponent<ParticleSystemRenderer>();
            renderer29.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 30: Emitter_1004
            GameObject emitter30 = new GameObject("Emitter_30");
            emitter30.transform.SetParent(transform);
            emitter30.transform.localPosition = Vector3.zero;

            ParticleSystem ps30 = emitter30.AddComponent<ParticleSystem>();
            var main30 = ps30.main;
            main30.duration = 0.20f;
            main30.startLifetime = 0.20f;
            main30.startSpeed = 1.00f;
            main30.startSize = 0.100f;
            main30.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission30 = ps30.emission;
            emission30.rateOverTime = 80;

            // Shape
            var shape30 = ps30.shape;
            shape30.shapeType = ParticleSystemShapeType.Sphere;
            shape30.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer30 = emitter30.GetComponent<ParticleSystemRenderer>();
            renderer30.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 31: Emitter_1004
            GameObject emitter31 = new GameObject("Emitter_31");
            emitter31.transform.SetParent(transform);
            emitter31.transform.localPosition = Vector3.zero;

            ParticleSystem ps31 = emitter31.AddComponent<ParticleSystem>();
            var main31 = ps31.main;
            main31.duration = 0.50f;
            main31.startLifetime = 0.50f;
            main31.startSpeed = 1.00f;
            main31.startSize = 0.100f;
            main31.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission31 = ps31.emission;
            emission31.rateOverTime = 3;

            // Shape
            var shape31 = ps31.shape;
            shape31.shapeType = ParticleSystemShapeType.Box;
            shape31.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer31 = emitter31.GetComponent<ParticleSystemRenderer>();
            renderer31.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 32: Emitter_1004
            GameObject emitter32 = new GameObject("Emitter_32");
            emitter32.transform.SetParent(transform);
            emitter32.transform.localPosition = Vector3.zero;

            ParticleSystem ps32 = emitter32.AddComponent<ParticleSystem>();
            var main32 = ps32.main;
            main32.duration = 0.10f;
            main32.startLifetime = 0.10f;
            main32.startSpeed = 1.00f;
            main32.startSize = 0.100f;
            main32.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission32 = ps32.emission;
            emission32.rateOverTime = 1;

            // Shape
            var shape32 = ps32.shape;
            shape32.shapeType = ParticleSystemShapeType.Sphere;
            shape32.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer32 = emitter32.GetComponent<ParticleSystemRenderer>();
            renderer32.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 33: Emitter_1004
            GameObject emitter33 = new GameObject("Emitter_33");
            emitter33.transform.SetParent(transform);
            emitter33.transform.localPosition = Vector3.zero;

            ParticleSystem ps33 = emitter33.AddComponent<ParticleSystem>();
            var main33 = ps33.main;
            main33.duration = 0.90f;
            main33.startLifetime = 0.90f;
            main33.startSpeed = 1.00f;
            main33.startSize = 0.100f;
            main33.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission33 = ps33.emission;
            emission33.rateOverTime = 3;

            // Shape
            var shape33 = ps33.shape;
            shape33.shapeType = ParticleSystemShapeType.Box;
            shape33.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer33 = emitter33.GetComponent<ParticleSystemRenderer>();
            renderer33.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 34: Emitter_1005
            GameObject emitter34 = new GameObject("Emitter_34");
            emitter34.transform.SetParent(transform);
            emitter34.transform.localPosition = Vector3.zero;

            ParticleSystem ps34 = emitter34.AddComponent<ParticleSystem>();
            var main34 = ps34.main;
            main34.duration = 0.20f;
            main34.startLifetime = 0.20f;
            main34.startSpeed = 1.00f;
            main34.startSize = 0.100f;
            main34.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission34 = ps34.emission;
            emission34.rateOverTime = 50;

            // Shape
            var shape34 = ps34.shape;
            shape34.shapeType = ParticleSystemShapeType.Sphere;
            shape34.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer34 = emitter34.GetComponent<ParticleSystemRenderer>();
            renderer34.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 35: Emitter_1004
            GameObject emitter35 = new GameObject("Emitter_35");
            emitter35.transform.SetParent(transform);
            emitter35.transform.localPosition = Vector3.zero;

            ParticleSystem ps35 = emitter35.AddComponent<ParticleSystem>();
            var main35 = ps35.main;
            main35.duration = 1.50f;
            main35.startLifetime = 1.50f;
            main35.startSpeed = 1.00f;
            main35.startSize = 0.100f;
            main35.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission35 = ps35.emission;
            emission35.rateOverTime = 3;

            // Shape
            var shape35 = ps35.shape;
            shape35.shapeType = ParticleSystemShapeType.Sphere;
            shape35.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer35 = emitter35.GetComponent<ParticleSystemRenderer>();
            renderer35.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 36: Emitter_1004
            GameObject emitter36 = new GameObject("Emitter_36");
            emitter36.transform.SetParent(transform);
            emitter36.transform.localPosition = Vector3.zero;

            ParticleSystem ps36 = emitter36.AddComponent<ParticleSystem>();
            var main36 = ps36.main;
            main36.duration = 1.50f;
            main36.startLifetime = 1.50f;
            main36.startSpeed = 1.00f;
            main36.startSize = 0.100f;
            main36.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission36 = ps36.emission;
            emission36.rateOverTime = 3;

            // Shape
            var shape36 = ps36.shape;
            shape36.shapeType = ParticleSystemShapeType.Sphere;
            shape36.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer36 = emitter36.GetComponent<ParticleSystemRenderer>();
            renderer36.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 37: Emitter_1004
            GameObject emitter37 = new GameObject("Emitter_37");
            emitter37.transform.SetParent(transform);
            emitter37.transform.localPosition = Vector3.zero;

            ParticleSystem ps37 = emitter37.AddComponent<ParticleSystem>();
            var main37 = ps37.main;
            main37.duration = 0.03f;
            main37.startLifetime = 0.03f;
            main37.startSpeed = 1.00f;
            main37.startSize = 0.100f;
            main37.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission37 = ps37.emission;
            emission37.rateOverTime = 1;

            // Shape
            var shape37 = ps37.shape;
            shape37.shapeType = ParticleSystemShapeType.Sphere;
            shape37.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer37 = emitter37.GetComponent<ParticleSystemRenderer>();
            renderer37.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 38: Emitter_1004
            GameObject emitter38 = new GameObject("Emitter_38");
            emitter38.transform.SetParent(transform);
            emitter38.transform.localPosition = Vector3.zero;

            ParticleSystem ps38 = emitter38.AddComponent<ParticleSystem>();
            var main38 = ps38.main;
            main38.duration = 0.03f;
            main38.startLifetime = 0.03f;
            main38.startSpeed = 1.00f;
            main38.startSize = 0.100f;
            main38.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission38 = ps38.emission;
            emission38.rateOverTime = 133;

            // Shape
            var shape38 = ps38.shape;
            shape38.shapeType = ParticleSystemShapeType.Sphere;
            shape38.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer38 = emitter38.GetComponent<ParticleSystemRenderer>();
            renderer38.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 39: Emitter_1004
            GameObject emitter39 = new GameObject("Emitter_39");
            emitter39.transform.SetParent(transform);
            emitter39.transform.localPosition = Vector3.zero;

            ParticleSystem ps39 = emitter39.AddComponent<ParticleSystem>();
            var main39 = ps39.main;
            main39.duration = 2.00f;
            main39.startLifetime = 2.00f;
            main39.startSpeed = 1.00f;
            main39.startSize = 0.100f;
            main39.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission39 = ps39.emission;
            emission39.rateOverTime = 3;

            // Shape
            var shape39 = ps39.shape;
            shape39.shapeType = ParticleSystemShapeType.Box;
            shape39.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer39 = emitter39.GetComponent<ParticleSystemRenderer>();
            renderer39.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 40: Emitter_1004
            GameObject emitter40 = new GameObject("Emitter_40");
            emitter40.transform.SetParent(transform);
            emitter40.transform.localPosition = Vector3.zero;

            ParticleSystem ps40 = emitter40.AddComponent<ParticleSystem>();
            var main40 = ps40.main;
            main40.duration = 0.20f;
            main40.startLifetime = 0.20f;
            main40.startSpeed = 1.00f;
            main40.startSize = 0.100f;
            main40.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission40 = ps40.emission;
            emission40.rateOverTime = 80;

            // Shape
            var shape40 = ps40.shape;
            shape40.shapeType = ParticleSystemShapeType.Sphere;
            shape40.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer40 = emitter40.GetComponent<ParticleSystemRenderer>();
            renderer40.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 41: Emitter_1004
            GameObject emitter41 = new GameObject("Emitter_41");
            emitter41.transform.SetParent(transform);
            emitter41.transform.localPosition = Vector3.zero;

            ParticleSystem ps41 = emitter41.AddComponent<ParticleSystem>();
            var main41 = ps41.main;
            main41.duration = 0.50f;
            main41.startLifetime = 0.50f;
            main41.startSpeed = 1.00f;
            main41.startSize = 0.100f;
            main41.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission41 = ps41.emission;
            emission41.rateOverTime = 3;

            // Shape
            var shape41 = ps41.shape;
            shape41.shapeType = ParticleSystemShapeType.Box;
            shape41.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer41 = emitter41.GetComponent<ParticleSystemRenderer>();
            renderer41.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 42: Emitter_1004
            GameObject emitter42 = new GameObject("Emitter_42");
            emitter42.transform.SetParent(transform);
            emitter42.transform.localPosition = Vector3.zero;

            ParticleSystem ps42 = emitter42.AddComponent<ParticleSystem>();
            var main42 = ps42.main;
            main42.duration = 0.10f;
            main42.startLifetime = 0.10f;
            main42.startSpeed = 1.00f;
            main42.startSize = 0.100f;
            main42.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission42 = ps42.emission;
            emission42.rateOverTime = 1;

            // Shape
            var shape42 = ps42.shape;
            shape42.shapeType = ParticleSystemShapeType.Sphere;
            shape42.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer42 = emitter42.GetComponent<ParticleSystemRenderer>();
            renderer42.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 43: Emitter_1004
            GameObject emitter43 = new GameObject("Emitter_43");
            emitter43.transform.SetParent(transform);
            emitter43.transform.localPosition = Vector3.zero;

            ParticleSystem ps43 = emitter43.AddComponent<ParticleSystem>();
            var main43 = ps43.main;
            main43.duration = 0.90f;
            main43.startLifetime = 0.90f;
            main43.startSpeed = 1.00f;
            main43.startSize = 0.100f;
            main43.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission43 = ps43.emission;
            emission43.rateOverTime = 3;

            // Shape
            var shape43 = ps43.shape;
            shape43.shapeType = ParticleSystemShapeType.Box;
            shape43.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer43 = emitter43.GetComponent<ParticleSystemRenderer>();
            renderer43.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 44: Emitter_1005
            GameObject emitter44 = new GameObject("Emitter_44");
            emitter44.transform.SetParent(transform);
            emitter44.transform.localPosition = Vector3.zero;

            ParticleSystem ps44 = emitter44.AddComponent<ParticleSystem>();
            var main44 = ps44.main;
            main44.duration = 0.20f;
            main44.startLifetime = 0.20f;
            main44.startSpeed = 1.00f;
            main44.startSize = 0.100f;
            main44.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission44 = ps44.emission;
            emission44.rateOverTime = 50;

            // Shape
            var shape44 = ps44.shape;
            shape44.shapeType = ParticleSystemShapeType.Sphere;
            shape44.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer44 = emitter44.GetComponent<ParticleSystemRenderer>();
            renderer44.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 45: Emitter_1004
            GameObject emitter45 = new GameObject("Emitter_45");
            emitter45.transform.SetParent(transform);
            emitter45.transform.localPosition = Vector3.zero;

            ParticleSystem ps45 = emitter45.AddComponent<ParticleSystem>();
            var main45 = ps45.main;
            main45.duration = 1.50f;
            main45.startLifetime = 1.50f;
            main45.startSpeed = 1.00f;
            main45.startSize = 0.100f;
            main45.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission45 = ps45.emission;
            emission45.rateOverTime = 3;

            // Shape
            var shape45 = ps45.shape;
            shape45.shapeType = ParticleSystemShapeType.Sphere;
            shape45.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer45 = emitter45.GetComponent<ParticleSystemRenderer>();
            renderer45.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 46: Emitter_1004
            GameObject emitter46 = new GameObject("Emitter_46");
            emitter46.transform.SetParent(transform);
            emitter46.transform.localPosition = Vector3.zero;

            ParticleSystem ps46 = emitter46.AddComponent<ParticleSystem>();
            var main46 = ps46.main;
            main46.duration = 1.50f;
            main46.startLifetime = 1.50f;
            main46.startSpeed = 1.00f;
            main46.startSize = 0.100f;
            main46.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission46 = ps46.emission;
            emission46.rateOverTime = 3;

            // Shape
            var shape46 = ps46.shape;
            shape46.shapeType = ParticleSystemShapeType.Sphere;
            shape46.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer46 = emitter46.GetComponent<ParticleSystemRenderer>();
            renderer46.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 47: Emitter_1004
            GameObject emitter47 = new GameObject("Emitter_47");
            emitter47.transform.SetParent(transform);
            emitter47.transform.localPosition = Vector3.zero;

            ParticleSystem ps47 = emitter47.AddComponent<ParticleSystem>();
            var main47 = ps47.main;
            main47.duration = 1.50f;
            main47.startLifetime = 1.50f;
            main47.startSpeed = 1.00f;
            main47.startSize = 0.100f;
            main47.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission47 = ps47.emission;
            emission47.rateOverTime = 3;

            // Shape
            var shape47 = ps47.shape;
            shape47.shapeType = ParticleSystemShapeType.Sphere;
            shape47.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer47 = emitter47.GetComponent<ParticleSystemRenderer>();
            renderer47.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 48: Emitter_1004
            GameObject emitter48 = new GameObject("Emitter_48");
            emitter48.transform.SetParent(transform);
            emitter48.transform.localPosition = Vector3.zero;

            ParticleSystem ps48 = emitter48.AddComponent<ParticleSystem>();
            var main48 = ps48.main;
            main48.duration = 1.50f;
            main48.startLifetime = 1.50f;
            main48.startSpeed = 1.00f;
            main48.startSize = 0.100f;
            main48.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission48 = ps48.emission;
            emission48.rateOverTime = 3;

            // Shape
            var shape48 = ps48.shape;
            shape48.shapeType = ParticleSystemShapeType.Sphere;
            shape48.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer48 = emitter48.GetComponent<ParticleSystemRenderer>();
            renderer48.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 49: Emitter_1004
            GameObject emitter49 = new GameObject("Emitter_49");
            emitter49.transform.SetParent(transform);
            emitter49.transform.localPosition = Vector3.zero;

            ParticleSystem ps49 = emitter49.AddComponent<ParticleSystem>();
            var main49 = ps49.main;
            main49.duration = 0.03f;
            main49.startLifetime = 0.03f;
            main49.startSpeed = 1.00f;
            main49.startSize = 0.100f;
            main49.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission49 = ps49.emission;
            emission49.rateOverTime = 1;

            // Shape
            var shape49 = ps49.shape;
            shape49.shapeType = ParticleSystemShapeType.Sphere;
            shape49.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer49 = emitter49.GetComponent<ParticleSystemRenderer>();
            renderer49.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 50: Emitter_1004
            GameObject emitter50 = new GameObject("Emitter_50");
            emitter50.transform.SetParent(transform);
            emitter50.transform.localPosition = Vector3.zero;

            ParticleSystem ps50 = emitter50.AddComponent<ParticleSystem>();
            var main50 = ps50.main;
            main50.duration = 0.03f;
            main50.startLifetime = 0.03f;
            main50.startSpeed = 1.00f;
            main50.startSize = 0.100f;
            main50.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission50 = ps50.emission;
            emission50.rateOverTime = 133;

            // Shape
            var shape50 = ps50.shape;
            shape50.shapeType = ParticleSystemShapeType.Sphere;
            shape50.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer50 = emitter50.GetComponent<ParticleSystemRenderer>();
            renderer50.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 51: Emitter_1004
            GameObject emitter51 = new GameObject("Emitter_51");
            emitter51.transform.SetParent(transform);
            emitter51.transform.localPosition = Vector3.zero;

            ParticleSystem ps51 = emitter51.AddComponent<ParticleSystem>();
            var main51 = ps51.main;
            main51.duration = 2.00f;
            main51.startLifetime = 2.00f;
            main51.startSpeed = 1.00f;
            main51.startSize = 0.100f;
            main51.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission51 = ps51.emission;
            emission51.rateOverTime = 3;

            // Shape
            var shape51 = ps51.shape;
            shape51.shapeType = ParticleSystemShapeType.Sphere;
            shape51.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer51 = emitter51.GetComponent<ParticleSystemRenderer>();
            renderer51.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 52: Emitter_1004
            GameObject emitter52 = new GameObject("Emitter_52");
            emitter52.transform.SetParent(transform);
            emitter52.transform.localPosition = Vector3.zero;

            ParticleSystem ps52 = emitter52.AddComponent<ParticleSystem>();
            var main52 = ps52.main;
            main52.duration = 4.00f;
            main52.startLifetime = 4.00f;
            main52.startSpeed = 1.00f;
            main52.startSize = 0.100f;
            main52.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission52 = ps52.emission;
            emission52.rateOverTime = 3;

            // Shape
            var shape52 = ps52.shape;
            shape52.shapeType = ParticleSystemShapeType.Sphere;
            shape52.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer52 = emitter52.GetComponent<ParticleSystemRenderer>();
            renderer52.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 53: Emitter_1005
            GameObject emitter53 = new GameObject("Emitter_53");
            emitter53.transform.SetParent(transform);
            emitter53.transform.localPosition = Vector3.zero;

            ParticleSystem ps53 = emitter53.AddComponent<ParticleSystem>();
            var main53 = ps53.main;
            main53.duration = 0.03f;
            main53.startLifetime = 0.03f;
            main53.startSpeed = 1.00f;
            main53.startSize = 0.100f;
            main53.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission53 = ps53.emission;
            emission53.rateOverTime = 50;

            // Shape
            var shape53 = ps53.shape;
            shape53.shapeType = ParticleSystemShapeType.Sphere;
            shape53.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer53 = emitter53.GetComponent<ParticleSystemRenderer>();
            renderer53.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 54: Emitter_1004
            GameObject emitter54 = new GameObject("Emitter_54");
            emitter54.transform.SetParent(transform);
            emitter54.transform.localPosition = Vector3.zero;

            ParticleSystem ps54 = emitter54.AddComponent<ParticleSystem>();
            var main54 = ps54.main;
            main54.duration = 3.00f;
            main54.startLifetime = 3.00f;
            main54.startSpeed = 1.00f;
            main54.startSize = 0.100f;
            main54.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission54 = ps54.emission;
            emission54.rateOverTime = 3;

            // Shape
            var shape54 = ps54.shape;
            shape54.shapeType = ParticleSystemShapeType.Sphere;
            shape54.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer54 = emitter54.GetComponent<ParticleSystemRenderer>();
            renderer54.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 55: Emitter_1004
            GameObject emitter55 = new GameObject("Emitter_55");
            emitter55.transform.SetParent(transform);
            emitter55.transform.localPosition = Vector3.zero;

            ParticleSystem ps55 = emitter55.AddComponent<ParticleSystem>();
            var main55 = ps55.main;
            main55.duration = 2.00f;
            main55.startLifetime = 2.00f;
            main55.startSpeed = 1.00f;
            main55.startSize = 0.100f;
            main55.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission55 = ps55.emission;
            emission55.rateOverTime = 3;

            // Shape
            var shape55 = ps55.shape;
            shape55.shapeType = ParticleSystemShapeType.Box;
            shape55.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer55 = emitter55.GetComponent<ParticleSystemRenderer>();
            renderer55.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 56: Emitter_1004
            GameObject emitter56 = new GameObject("Emitter_56");
            emitter56.transform.SetParent(transform);
            emitter56.transform.localPosition = Vector3.zero;

            ParticleSystem ps56 = emitter56.AddComponent<ParticleSystem>();
            var main56 = ps56.main;
            main56.duration = 0.20f;
            main56.startLifetime = 0.20f;
            main56.startSpeed = 1.00f;
            main56.startSize = 0.100f;
            main56.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission56 = ps56.emission;
            emission56.rateOverTime = 80;

            // Shape
            var shape56 = ps56.shape;
            shape56.shapeType = ParticleSystemShapeType.Sphere;
            shape56.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer56 = emitter56.GetComponent<ParticleSystemRenderer>();
            renderer56.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 57: Emitter_1004
            GameObject emitter57 = new GameObject("Emitter_57");
            emitter57.transform.SetParent(transform);
            emitter57.transform.localPosition = Vector3.zero;

            ParticleSystem ps57 = emitter57.AddComponent<ParticleSystem>();
            var main57 = ps57.main;
            main57.duration = 0.50f;
            main57.startLifetime = 0.50f;
            main57.startSpeed = 1.00f;
            main57.startSize = 0.100f;
            main57.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission57 = ps57.emission;
            emission57.rateOverTime = 3;

            // Shape
            var shape57 = ps57.shape;
            shape57.shapeType = ParticleSystemShapeType.Box;
            shape57.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer57 = emitter57.GetComponent<ParticleSystemRenderer>();
            renderer57.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 58: Emitter_1004
            GameObject emitter58 = new GameObject("Emitter_58");
            emitter58.transform.SetParent(transform);
            emitter58.transform.localPosition = Vector3.zero;

            ParticleSystem ps58 = emitter58.AddComponent<ParticleSystem>();
            var main58 = ps58.main;
            main58.duration = 0.10f;
            main58.startLifetime = 0.10f;
            main58.startSpeed = 1.00f;
            main58.startSize = 0.100f;
            main58.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission58 = ps58.emission;
            emission58.rateOverTime = 1;

            // Shape
            var shape58 = ps58.shape;
            shape58.shapeType = ParticleSystemShapeType.Sphere;
            shape58.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer58 = emitter58.GetComponent<ParticleSystemRenderer>();
            renderer58.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 59: Emitter_1004
            GameObject emitter59 = new GameObject("Emitter_59");
            emitter59.transform.SetParent(transform);
            emitter59.transform.localPosition = Vector3.zero;

            ParticleSystem ps59 = emitter59.AddComponent<ParticleSystem>();
            var main59 = ps59.main;
            main59.duration = 0.90f;
            main59.startLifetime = 0.90f;
            main59.startSpeed = 1.00f;
            main59.startSize = 0.100f;
            main59.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission59 = ps59.emission;
            emission59.rateOverTime = 3;

            // Shape
            var shape59 = ps59.shape;
            shape59.shapeType = ParticleSystemShapeType.Box;
            shape59.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer59 = emitter59.GetComponent<ParticleSystemRenderer>();
            renderer59.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 60: Emitter_1005
            GameObject emitter60 = new GameObject("Emitter_60");
            emitter60.transform.SetParent(transform);
            emitter60.transform.localPosition = Vector3.zero;

            ParticleSystem ps60 = emitter60.AddComponent<ParticleSystem>();
            var main60 = ps60.main;
            main60.duration = 0.20f;
            main60.startLifetime = 0.20f;
            main60.startSpeed = 1.00f;
            main60.startSize = 0.100f;
            main60.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission60 = ps60.emission;
            emission60.rateOverTime = 50;

            // Shape
            var shape60 = ps60.shape;
            shape60.shapeType = ParticleSystemShapeType.Sphere;
            shape60.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer60 = emitter60.GetComponent<ParticleSystemRenderer>();
            renderer60.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 61: Emitter_1004
            GameObject emitter61 = new GameObject("Emitter_61");
            emitter61.transform.SetParent(transform);
            emitter61.transform.localPosition = Vector3.zero;

            ParticleSystem ps61 = emitter61.AddComponent<ParticleSystem>();
            var main61 = ps61.main;
            main61.duration = 1.50f;
            main61.startLifetime = 1.50f;
            main61.startSpeed = 1.00f;
            main61.startSize = 0.100f;
            main61.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission61 = ps61.emission;
            emission61.rateOverTime = 3;

            // Shape
            var shape61 = ps61.shape;
            shape61.shapeType = ParticleSystemShapeType.Sphere;
            shape61.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer61 = emitter61.GetComponent<ParticleSystemRenderer>();
            renderer61.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 62: Emitter_1004
            GameObject emitter62 = new GameObject("Emitter_62");
            emitter62.transform.SetParent(transform);
            emitter62.transform.localPosition = Vector3.zero;

            ParticleSystem ps62 = emitter62.AddComponent<ParticleSystem>();
            var main62 = ps62.main;
            main62.duration = 1.50f;
            main62.startLifetime = 1.50f;
            main62.startSpeed = 1.00f;
            main62.startSize = 0.100f;
            main62.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission62 = ps62.emission;
            emission62.rateOverTime = 3;

            // Shape
            var shape62 = ps62.shape;
            shape62.shapeType = ParticleSystemShapeType.Sphere;
            shape62.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer62 = emitter62.GetComponent<ParticleSystemRenderer>();
            renderer62.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 63: Emitter_1004
            GameObject emitter63 = new GameObject("Emitter_63");
            emitter63.transform.SetParent(transform);
            emitter63.transform.localPosition = Vector3.zero;

            ParticleSystem ps63 = emitter63.AddComponent<ParticleSystem>();
            var main63 = ps63.main;
            main63.duration = 0.03f;
            main63.startLifetime = 0.03f;
            main63.startSpeed = 1.00f;
            main63.startSize = 0.100f;
            main63.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission63 = ps63.emission;
            emission63.rateOverTime = 1;

            // Shape
            var shape63 = ps63.shape;
            shape63.shapeType = ParticleSystemShapeType.Sphere;
            shape63.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer63 = emitter63.GetComponent<ParticleSystemRenderer>();
            renderer63.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 64: Emitter_1004
            GameObject emitter64 = new GameObject("Emitter_64");
            emitter64.transform.SetParent(transform);
            emitter64.transform.localPosition = Vector3.zero;

            ParticleSystem ps64 = emitter64.AddComponent<ParticleSystem>();
            var main64 = ps64.main;
            main64.duration = 0.03f;
            main64.startLifetime = 0.03f;
            main64.startSpeed = 1.00f;
            main64.startSize = 0.100f;
            main64.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission64 = ps64.emission;
            emission64.rateOverTime = 133;

            // Shape
            var shape64 = ps64.shape;
            shape64.shapeType = ParticleSystemShapeType.Sphere;
            shape64.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer64 = emitter64.GetComponent<ParticleSystemRenderer>();
            renderer64.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 65: Emitter_1004
            GameObject emitter65 = new GameObject("Emitter_65");
            emitter65.transform.SetParent(transform);
            emitter65.transform.localPosition = Vector3.zero;

            ParticleSystem ps65 = emitter65.AddComponent<ParticleSystem>();
            var main65 = ps65.main;
            main65.duration = 3.00f;
            main65.startLifetime = 3.00f;
            main65.startSpeed = 1.00f;
            main65.startSize = 0.100f;
            main65.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission65 = ps65.emission;
            emission65.rateOverTime = 3;

            // Shape
            var shape65 = ps65.shape;
            shape65.shapeType = ParticleSystemShapeType.Sphere;
            shape65.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer65 = emitter65.GetComponent<ParticleSystemRenderer>();
            renderer65.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 66: Emitter_1004
            GameObject emitter66 = new GameObject("Emitter_66");
            emitter66.transform.SetParent(transform);
            emitter66.transform.localPosition = Vector3.zero;

            ParticleSystem ps66 = emitter66.AddComponent<ParticleSystem>();
            var main66 = ps66.main;
            main66.duration = 2.00f;
            main66.startLifetime = 2.00f;
            main66.startSpeed = 1.00f;
            main66.startSize = 0.100f;
            main66.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission66 = ps66.emission;
            emission66.rateOverTime = 3;

            // Shape
            var shape66 = ps66.shape;
            shape66.shapeType = ParticleSystemShapeType.Box;
            shape66.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer66 = emitter66.GetComponent<ParticleSystemRenderer>();
            renderer66.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 67: Emitter_1004
            GameObject emitter67 = new GameObject("Emitter_67");
            emitter67.transform.SetParent(transform);
            emitter67.transform.localPosition = Vector3.zero;

            ParticleSystem ps67 = emitter67.AddComponent<ParticleSystem>();
            var main67 = ps67.main;
            main67.duration = 0.20f;
            main67.startLifetime = 0.20f;
            main67.startSpeed = 1.00f;
            main67.startSize = 0.100f;
            main67.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission67 = ps67.emission;
            emission67.rateOverTime = 80;

            // Shape
            var shape67 = ps67.shape;
            shape67.shapeType = ParticleSystemShapeType.Sphere;
            shape67.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer67 = emitter67.GetComponent<ParticleSystemRenderer>();
            renderer67.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 68: Emitter_1004
            GameObject emitter68 = new GameObject("Emitter_68");
            emitter68.transform.SetParent(transform);
            emitter68.transform.localPosition = Vector3.zero;

            ParticleSystem ps68 = emitter68.AddComponent<ParticleSystem>();
            var main68 = ps68.main;
            main68.duration = 0.50f;
            main68.startLifetime = 0.50f;
            main68.startSpeed = 1.00f;
            main68.startSize = 0.100f;
            main68.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission68 = ps68.emission;
            emission68.rateOverTime = 3;

            // Shape
            var shape68 = ps68.shape;
            shape68.shapeType = ParticleSystemShapeType.Box;
            shape68.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer68 = emitter68.GetComponent<ParticleSystemRenderer>();
            renderer68.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 69: Emitter_1004
            GameObject emitter69 = new GameObject("Emitter_69");
            emitter69.transform.SetParent(transform);
            emitter69.transform.localPosition = Vector3.zero;

            ParticleSystem ps69 = emitter69.AddComponent<ParticleSystem>();
            var main69 = ps69.main;
            main69.duration = 0.10f;
            main69.startLifetime = 0.10f;
            main69.startSpeed = 1.00f;
            main69.startSize = 0.100f;
            main69.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission69 = ps69.emission;
            emission69.rateOverTime = 1;

            // Shape
            var shape69 = ps69.shape;
            shape69.shapeType = ParticleSystemShapeType.Sphere;
            shape69.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer69 = emitter69.GetComponent<ParticleSystemRenderer>();
            renderer69.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 70: Emitter_1004
            GameObject emitter70 = new GameObject("Emitter_70");
            emitter70.transform.SetParent(transform);
            emitter70.transform.localPosition = Vector3.zero;

            ParticleSystem ps70 = emitter70.AddComponent<ParticleSystem>();
            var main70 = ps70.main;
            main70.duration = 0.90f;
            main70.startLifetime = 0.90f;
            main70.startSpeed = 1.00f;
            main70.startSize = 0.100f;
            main70.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission70 = ps70.emission;
            emission70.rateOverTime = 3;

            // Shape
            var shape70 = ps70.shape;
            shape70.shapeType = ParticleSystemShapeType.Box;
            shape70.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer70 = emitter70.GetComponent<ParticleSystemRenderer>();
            renderer70.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 71: Emitter_1005
            GameObject emitter71 = new GameObject("Emitter_71");
            emitter71.transform.SetParent(transform);
            emitter71.transform.localPosition = Vector3.zero;

            ParticleSystem ps71 = emitter71.AddComponent<ParticleSystem>();
            var main71 = ps71.main;
            main71.duration = 0.20f;
            main71.startLifetime = 0.20f;
            main71.startSpeed = 1.00f;
            main71.startSize = 0.100f;
            main71.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission71 = ps71.emission;
            emission71.rateOverTime = 50;

            // Shape
            var shape71 = ps71.shape;
            shape71.shapeType = ParticleSystemShapeType.Sphere;
            shape71.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer71 = emitter71.GetComponent<ParticleSystemRenderer>();
            renderer71.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 72: Emitter_1004
            GameObject emitter72 = new GameObject("Emitter_72");
            emitter72.transform.SetParent(transform);
            emitter72.transform.localPosition = Vector3.zero;

            ParticleSystem ps72 = emitter72.AddComponent<ParticleSystem>();
            var main72 = ps72.main;
            main72.duration = 1.50f;
            main72.startLifetime = 1.50f;
            main72.startSpeed = 1.00f;
            main72.startSize = 0.100f;
            main72.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission72 = ps72.emission;
            emission72.rateOverTime = 3;

            // Shape
            var shape72 = ps72.shape;
            shape72.shapeType = ParticleSystemShapeType.Sphere;
            shape72.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer72 = emitter72.GetComponent<ParticleSystemRenderer>();
            renderer72.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 73: Emitter_1004
            GameObject emitter73 = new GameObject("Emitter_73");
            emitter73.transform.SetParent(transform);
            emitter73.transform.localPosition = Vector3.zero;

            ParticleSystem ps73 = emitter73.AddComponent<ParticleSystem>();
            var main73 = ps73.main;
            main73.duration = 1.50f;
            main73.startLifetime = 1.50f;
            main73.startSpeed = 1.00f;
            main73.startSize = 0.100f;
            main73.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission73 = ps73.emission;
            emission73.rateOverTime = 3;

            // Shape
            var shape73 = ps73.shape;
            shape73.shapeType = ParticleSystemShapeType.Sphere;
            shape73.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer73 = emitter73.GetComponent<ParticleSystemRenderer>();
            renderer73.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 74: Emitter_1004
            GameObject emitter74 = new GameObject("Emitter_74");
            emitter74.transform.SetParent(transform);
            emitter74.transform.localPosition = Vector3.zero;

            ParticleSystem ps74 = emitter74.AddComponent<ParticleSystem>();
            var main74 = ps74.main;
            main74.duration = 0.03f;
            main74.startLifetime = 0.03f;
            main74.startSpeed = 1.00f;
            main74.startSize = 0.100f;
            main74.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission74 = ps74.emission;
            emission74.rateOverTime = 1;

            // Shape
            var shape74 = ps74.shape;
            shape74.shapeType = ParticleSystemShapeType.Sphere;
            shape74.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer74 = emitter74.GetComponent<ParticleSystemRenderer>();
            renderer74.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 75: Emitter_1004
            GameObject emitter75 = new GameObject("Emitter_75");
            emitter75.transform.SetParent(transform);
            emitter75.transform.localPosition = Vector3.zero;

            ParticleSystem ps75 = emitter75.AddComponent<ParticleSystem>();
            var main75 = ps75.main;
            main75.duration = 0.03f;
            main75.startLifetime = 0.03f;
            main75.startSpeed = 1.00f;
            main75.startSize = 0.100f;
            main75.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission75 = ps75.emission;
            emission75.rateOverTime = 133;

            // Shape
            var shape75 = ps75.shape;
            shape75.shapeType = ParticleSystemShapeType.Sphere;
            shape75.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer75 = emitter75.GetComponent<ParticleSystemRenderer>();
            renderer75.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 76: Emitter_1004
            GameObject emitter76 = new GameObject("Emitter_76");
            emitter76.transform.SetParent(transform);
            emitter76.transform.localPosition = Vector3.zero;

            ParticleSystem ps76 = emitter76.AddComponent<ParticleSystem>();
            var main76 = ps76.main;
            main76.duration = 2.00f;
            main76.startLifetime = 2.00f;
            main76.startSpeed = 1.00f;
            main76.startSize = 0.100f;
            main76.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission76 = ps76.emission;
            emission76.rateOverTime = 3;

            // Shape
            var shape76 = ps76.shape;
            shape76.shapeType = ParticleSystemShapeType.Box;
            shape76.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer76 = emitter76.GetComponent<ParticleSystemRenderer>();
            renderer76.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 77: Emitter_1004
            GameObject emitter77 = new GameObject("Emitter_77");
            emitter77.transform.SetParent(transform);
            emitter77.transform.localPosition = Vector3.zero;

            ParticleSystem ps77 = emitter77.AddComponent<ParticleSystem>();
            var main77 = ps77.main;
            main77.duration = 0.20f;
            main77.startLifetime = 0.20f;
            main77.startSpeed = 1.00f;
            main77.startSize = 0.100f;
            main77.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission77 = ps77.emission;
            emission77.rateOverTime = 80;

            // Shape
            var shape77 = ps77.shape;
            shape77.shapeType = ParticleSystemShapeType.Sphere;
            shape77.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer77 = emitter77.GetComponent<ParticleSystemRenderer>();
            renderer77.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 78: Emitter_1004
            GameObject emitter78 = new GameObject("Emitter_78");
            emitter78.transform.SetParent(transform);
            emitter78.transform.localPosition = Vector3.zero;

            ParticleSystem ps78 = emitter78.AddComponent<ParticleSystem>();
            var main78 = ps78.main;
            main78.duration = 0.50f;
            main78.startLifetime = 0.50f;
            main78.startSpeed = 1.00f;
            main78.startSize = 0.100f;
            main78.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission78 = ps78.emission;
            emission78.rateOverTime = 3;

            // Shape
            var shape78 = ps78.shape;
            shape78.shapeType = ParticleSystemShapeType.Box;
            shape78.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer78 = emitter78.GetComponent<ParticleSystemRenderer>();
            renderer78.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 79: Emitter_1004
            GameObject emitter79 = new GameObject("Emitter_79");
            emitter79.transform.SetParent(transform);
            emitter79.transform.localPosition = Vector3.zero;

            ParticleSystem ps79 = emitter79.AddComponent<ParticleSystem>();
            var main79 = ps79.main;
            main79.duration = 0.10f;
            main79.startLifetime = 0.10f;
            main79.startSpeed = 1.00f;
            main79.startSize = 0.100f;
            main79.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission79 = ps79.emission;
            emission79.rateOverTime = 1;

            // Shape
            var shape79 = ps79.shape;
            shape79.shapeType = ParticleSystemShapeType.Sphere;
            shape79.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer79 = emitter79.GetComponent<ParticleSystemRenderer>();
            renderer79.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 80: Emitter_1004
            GameObject emitter80 = new GameObject("Emitter_80");
            emitter80.transform.SetParent(transform);
            emitter80.transform.localPosition = Vector3.zero;

            ParticleSystem ps80 = emitter80.AddComponent<ParticleSystem>();
            var main80 = ps80.main;
            main80.duration = 0.90f;
            main80.startLifetime = 0.90f;
            main80.startSpeed = 1.00f;
            main80.startSize = 0.100f;
            main80.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission80 = ps80.emission;
            emission80.rateOverTime = 3;

            // Shape
            var shape80 = ps80.shape;
            shape80.shapeType = ParticleSystemShapeType.Box;
            shape80.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer80 = emitter80.GetComponent<ParticleSystemRenderer>();
            renderer80.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 81: Emitter_1005
            GameObject emitter81 = new GameObject("Emitter_81");
            emitter81.transform.SetParent(transform);
            emitter81.transform.localPosition = Vector3.zero;

            ParticleSystem ps81 = emitter81.AddComponent<ParticleSystem>();
            var main81 = ps81.main;
            main81.duration = 0.20f;
            main81.startLifetime = 0.20f;
            main81.startSpeed = 1.00f;
            main81.startSize = 0.100f;
            main81.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission81 = ps81.emission;
            emission81.rateOverTime = 50;

            // Shape
            var shape81 = ps81.shape;
            shape81.shapeType = ParticleSystemShapeType.Sphere;
            shape81.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer81 = emitter81.GetComponent<ParticleSystemRenderer>();
            renderer81.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 82: Emitter_1004
            GameObject emitter82 = new GameObject("Emitter_82");
            emitter82.transform.SetParent(transform);
            emitter82.transform.localPosition = Vector3.zero;

            ParticleSystem ps82 = emitter82.AddComponent<ParticleSystem>();
            var main82 = ps82.main;
            main82.duration = 1.50f;
            main82.startLifetime = 1.50f;
            main82.startSpeed = 1.00f;
            main82.startSize = 0.100f;
            main82.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission82 = ps82.emission;
            emission82.rateOverTime = 3;

            // Shape
            var shape82 = ps82.shape;
            shape82.shapeType = ParticleSystemShapeType.Sphere;
            shape82.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer82 = emitter82.GetComponent<ParticleSystemRenderer>();
            renderer82.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 83: Emitter_1004
            GameObject emitter83 = new GameObject("Emitter_83");
            emitter83.transform.SetParent(transform);
            emitter83.transform.localPosition = Vector3.zero;

            ParticleSystem ps83 = emitter83.AddComponent<ParticleSystem>();
            var main83 = ps83.main;
            main83.duration = 1.50f;
            main83.startLifetime = 1.50f;
            main83.startSpeed = 1.00f;
            main83.startSize = 0.100f;
            main83.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission83 = ps83.emission;
            emission83.rateOverTime = 3;

            // Shape
            var shape83 = ps83.shape;
            shape83.shapeType = ParticleSystemShapeType.Sphere;
            shape83.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer83 = emitter83.GetComponent<ParticleSystemRenderer>();
            renderer83.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 84: Emitter_1004
            GameObject emitter84 = new GameObject("Emitter_84");
            emitter84.transform.SetParent(transform);
            emitter84.transform.localPosition = Vector3.zero;

            ParticleSystem ps84 = emitter84.AddComponent<ParticleSystem>();
            var main84 = ps84.main;
            main84.duration = 1.50f;
            main84.startLifetime = 1.50f;
            main84.startSpeed = 1.00f;
            main84.startSize = 0.100f;
            main84.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission84 = ps84.emission;
            emission84.rateOverTime = 3;

            // Shape
            var shape84 = ps84.shape;
            shape84.shapeType = ParticleSystemShapeType.Sphere;
            shape84.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer84 = emitter84.GetComponent<ParticleSystemRenderer>();
            renderer84.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 85: Emitter_1004
            GameObject emitter85 = new GameObject("Emitter_85");
            emitter85.transform.SetParent(transform);
            emitter85.transform.localPosition = Vector3.zero;

            ParticleSystem ps85 = emitter85.AddComponent<ParticleSystem>();
            var main85 = ps85.main;
            main85.duration = 1.50f;
            main85.startLifetime = 1.50f;
            main85.startSpeed = 1.00f;
            main85.startSize = 0.100f;
            main85.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission85 = ps85.emission;
            emission85.rateOverTime = 3;

            // Shape
            var shape85 = ps85.shape;
            shape85.shapeType = ParticleSystemShapeType.Sphere;
            shape85.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer85 = emitter85.GetComponent<ParticleSystemRenderer>();
            renderer85.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 86: Emitter_1004
            GameObject emitter86 = new GameObject("Emitter_86");
            emitter86.transform.SetParent(transform);
            emitter86.transform.localPosition = Vector3.zero;

            ParticleSystem ps86 = emitter86.AddComponent<ParticleSystem>();
            var main86 = ps86.main;
            main86.duration = 0.03f;
            main86.startLifetime = 0.03f;
            main86.startSpeed = 1.00f;
            main86.startSize = 0.100f;
            main86.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission86 = ps86.emission;
            emission86.rateOverTime = 1;

            // Shape
            var shape86 = ps86.shape;
            shape86.shapeType = ParticleSystemShapeType.Sphere;
            shape86.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer86 = emitter86.GetComponent<ParticleSystemRenderer>();
            renderer86.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 87: Emitter_1004
            GameObject emitter87 = new GameObject("Emitter_87");
            emitter87.transform.SetParent(transform);
            emitter87.transform.localPosition = Vector3.zero;

            ParticleSystem ps87 = emitter87.AddComponent<ParticleSystem>();
            var main87 = ps87.main;
            main87.duration = 0.03f;
            main87.startLifetime = 0.03f;
            main87.startSpeed = 1.00f;
            main87.startSize = 0.100f;
            main87.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission87 = ps87.emission;
            emission87.rateOverTime = 133;

            // Shape
            var shape87 = ps87.shape;
            shape87.shapeType = ParticleSystemShapeType.Sphere;
            shape87.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer87 = emitter87.GetComponent<ParticleSystemRenderer>();
            renderer87.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 88: Emitter_1004
            GameObject emitter88 = new GameObject("Emitter_88");
            emitter88.transform.SetParent(transform);
            emitter88.transform.localPosition = Vector3.zero;

            ParticleSystem ps88 = emitter88.AddComponent<ParticleSystem>();
            var main88 = ps88.main;
            main88.duration = 3.00f;
            main88.startLifetime = 3.00f;
            main88.startSpeed = 1.00f;
            main88.startSize = 0.100f;
            main88.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission88 = ps88.emission;
            emission88.rateOverTime = 3;

            // Shape
            var shape88 = ps88.shape;
            shape88.shapeType = ParticleSystemShapeType.Sphere;
            shape88.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer88 = emitter88.GetComponent<ParticleSystemRenderer>();
            renderer88.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 89: Emitter_1004
            GameObject emitter89 = new GameObject("Emitter_89");
            emitter89.transform.SetParent(transform);
            emitter89.transform.localPosition = Vector3.zero;

            ParticleSystem ps89 = emitter89.AddComponent<ParticleSystem>();
            var main89 = ps89.main;
            main89.duration = 2.00f;
            main89.startLifetime = 2.00f;
            main89.startSpeed = 1.00f;
            main89.startSize = 0.100f;
            main89.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission89 = ps89.emission;
            emission89.rateOverTime = 3;

            // Shape
            var shape89 = ps89.shape;
            shape89.shapeType = ParticleSystemShapeType.Box;
            shape89.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer89 = emitter89.GetComponent<ParticleSystemRenderer>();
            renderer89.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 90: Emitter_1004
            GameObject emitter90 = new GameObject("Emitter_90");
            emitter90.transform.SetParent(transform);
            emitter90.transform.localPosition = Vector3.zero;

            ParticleSystem ps90 = emitter90.AddComponent<ParticleSystem>();
            var main90 = ps90.main;
            main90.duration = 0.20f;
            main90.startLifetime = 0.20f;
            main90.startSpeed = 1.00f;
            main90.startSize = 0.100f;
            main90.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission90 = ps90.emission;
            emission90.rateOverTime = 80;

            // Shape
            var shape90 = ps90.shape;
            shape90.shapeType = ParticleSystemShapeType.Sphere;
            shape90.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer90 = emitter90.GetComponent<ParticleSystemRenderer>();
            renderer90.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 91: Emitter_1004
            GameObject emitter91 = new GameObject("Emitter_91");
            emitter91.transform.SetParent(transform);
            emitter91.transform.localPosition = Vector3.zero;

            ParticleSystem ps91 = emitter91.AddComponent<ParticleSystem>();
            var main91 = ps91.main;
            main91.duration = 0.50f;
            main91.startLifetime = 0.50f;
            main91.startSpeed = 1.00f;
            main91.startSize = 0.100f;
            main91.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission91 = ps91.emission;
            emission91.rateOverTime = 3;

            // Shape
            var shape91 = ps91.shape;
            shape91.shapeType = ParticleSystemShapeType.Box;
            shape91.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer91 = emitter91.GetComponent<ParticleSystemRenderer>();
            renderer91.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 92: Emitter_1004
            GameObject emitter92 = new GameObject("Emitter_92");
            emitter92.transform.SetParent(transform);
            emitter92.transform.localPosition = Vector3.zero;

            ParticleSystem ps92 = emitter92.AddComponent<ParticleSystem>();
            var main92 = ps92.main;
            main92.duration = 0.10f;
            main92.startLifetime = 0.10f;
            main92.startSpeed = 1.00f;
            main92.startSize = 0.100f;
            main92.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission92 = ps92.emission;
            emission92.rateOverTime = 1;

            // Shape
            var shape92 = ps92.shape;
            shape92.shapeType = ParticleSystemShapeType.Sphere;
            shape92.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer92 = emitter92.GetComponent<ParticleSystemRenderer>();
            renderer92.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 93: Emitter_1004
            GameObject emitter93 = new GameObject("Emitter_93");
            emitter93.transform.SetParent(transform);
            emitter93.transform.localPosition = Vector3.zero;

            ParticleSystem ps93 = emitter93.AddComponent<ParticleSystem>();
            var main93 = ps93.main;
            main93.duration = 0.90f;
            main93.startLifetime = 0.90f;
            main93.startSpeed = 1.00f;
            main93.startSize = 0.100f;
            main93.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission93 = ps93.emission;
            emission93.rateOverTime = 3;

            // Shape
            var shape93 = ps93.shape;
            shape93.shapeType = ParticleSystemShapeType.Box;
            shape93.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer93 = emitter93.GetComponent<ParticleSystemRenderer>();
            renderer93.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 94: Emitter_1005
            GameObject emitter94 = new GameObject("Emitter_94");
            emitter94.transform.SetParent(transform);
            emitter94.transform.localPosition = Vector3.zero;

            ParticleSystem ps94 = emitter94.AddComponent<ParticleSystem>();
            var main94 = ps94.main;
            main94.duration = 0.20f;
            main94.startLifetime = 0.20f;
            main94.startSpeed = 1.00f;
            main94.startSize = 0.100f;
            main94.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission94 = ps94.emission;
            emission94.rateOverTime = 50;

            // Shape
            var shape94 = ps94.shape;
            shape94.shapeType = ParticleSystemShapeType.Sphere;
            shape94.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer94 = emitter94.GetComponent<ParticleSystemRenderer>();
            renderer94.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 95: Emitter_1004
            GameObject emitter95 = new GameObject("Emitter_95");
            emitter95.transform.SetParent(transform);
            emitter95.transform.localPosition = Vector3.zero;

            ParticleSystem ps95 = emitter95.AddComponent<ParticleSystem>();
            var main95 = ps95.main;
            main95.duration = 1.50f;
            main95.startLifetime = 1.50f;
            main95.startSpeed = 1.00f;
            main95.startSize = 0.100f;
            main95.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission95 = ps95.emission;
            emission95.rateOverTime = 3;

            // Shape
            var shape95 = ps95.shape;
            shape95.shapeType = ParticleSystemShapeType.Sphere;
            shape95.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer95 = emitter95.GetComponent<ParticleSystemRenderer>();
            renderer95.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 96: Emitter_1004
            GameObject emitter96 = new GameObject("Emitter_96");
            emitter96.transform.SetParent(transform);
            emitter96.transform.localPosition = Vector3.zero;

            ParticleSystem ps96 = emitter96.AddComponent<ParticleSystem>();
            var main96 = ps96.main;
            main96.duration = 1.50f;
            main96.startLifetime = 1.50f;
            main96.startSpeed = 1.00f;
            main96.startSize = 0.100f;
            main96.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission96 = ps96.emission;
            emission96.rateOverTime = 3;

            // Shape
            var shape96 = ps96.shape;
            shape96.shapeType = ParticleSystemShapeType.Sphere;
            shape96.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer96 = emitter96.GetComponent<ParticleSystemRenderer>();
            renderer96.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 97: Emitter_1004
            GameObject emitter97 = new GameObject("Emitter_97");
            emitter97.transform.SetParent(transform);
            emitter97.transform.localPosition = Vector3.zero;

            ParticleSystem ps97 = emitter97.AddComponent<ParticleSystem>();
            var main97 = ps97.main;
            main97.duration = 0.03f;
            main97.startLifetime = 0.03f;
            main97.startSpeed = 1.00f;
            main97.startSize = 0.100f;
            main97.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission97 = ps97.emission;
            emission97.rateOverTime = 1;

            // Shape
            var shape97 = ps97.shape;
            shape97.shapeType = ParticleSystemShapeType.Sphere;
            shape97.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer97 = emitter97.GetComponent<ParticleSystemRenderer>();
            renderer97.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 98: Emitter_1004
            GameObject emitter98 = new GameObject("Emitter_98");
            emitter98.transform.SetParent(transform);
            emitter98.transform.localPosition = Vector3.zero;

            ParticleSystem ps98 = emitter98.AddComponent<ParticleSystem>();
            var main98 = ps98.main;
            main98.duration = 0.03f;
            main98.startLifetime = 0.03f;
            main98.startSpeed = 1.00f;
            main98.startSize = 0.100f;
            main98.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission98 = ps98.emission;
            emission98.rateOverTime = 133;

            // Shape
            var shape98 = ps98.shape;
            shape98.shapeType = ParticleSystemShapeType.Sphere;
            shape98.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer98 = emitter98.GetComponent<ParticleSystemRenderer>();
            renderer98.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 99: Emitter_1004
            GameObject emitter99 = new GameObject("Emitter_99");
            emitter99.transform.SetParent(transform);
            emitter99.transform.localPosition = Vector3.zero;

            ParticleSystem ps99 = emitter99.AddComponent<ParticleSystem>();
            var main99 = ps99.main;
            main99.duration = 2.00f;
            main99.startLifetime = 2.00f;
            main99.startSpeed = 1.00f;
            main99.startSize = 0.100f;
            main99.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission99 = ps99.emission;
            emission99.rateOverTime = 3;

            // Shape
            var shape99 = ps99.shape;
            shape99.shapeType = ParticleSystemShapeType.Box;
            shape99.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer99 = emitter99.GetComponent<ParticleSystemRenderer>();
            renderer99.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 100: Emitter_1004
            GameObject emitter100 = new GameObject("Emitter_100");
            emitter100.transform.SetParent(transform);
            emitter100.transform.localPosition = Vector3.zero;

            ParticleSystem ps100 = emitter100.AddComponent<ParticleSystem>();
            var main100 = ps100.main;
            main100.duration = 0.20f;
            main100.startLifetime = 0.20f;
            main100.startSpeed = 1.00f;
            main100.startSize = 0.100f;
            main100.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission100 = ps100.emission;
            emission100.rateOverTime = 80;

            // Shape
            var shape100 = ps100.shape;
            shape100.shapeType = ParticleSystemShapeType.Sphere;
            shape100.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer100 = emitter100.GetComponent<ParticleSystemRenderer>();
            renderer100.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 101: Emitter_1004
            GameObject emitter101 = new GameObject("Emitter_101");
            emitter101.transform.SetParent(transform);
            emitter101.transform.localPosition = Vector3.zero;

            ParticleSystem ps101 = emitter101.AddComponent<ParticleSystem>();
            var main101 = ps101.main;
            main101.duration = 0.50f;
            main101.startLifetime = 0.50f;
            main101.startSpeed = 1.00f;
            main101.startSize = 0.100f;
            main101.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission101 = ps101.emission;
            emission101.rateOverTime = 3;

            // Shape
            var shape101 = ps101.shape;
            shape101.shapeType = ParticleSystemShapeType.Box;
            shape101.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer101 = emitter101.GetComponent<ParticleSystemRenderer>();
            renderer101.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 102: Emitter_1004
            GameObject emitter102 = new GameObject("Emitter_102");
            emitter102.transform.SetParent(transform);
            emitter102.transform.localPosition = Vector3.zero;

            ParticleSystem ps102 = emitter102.AddComponent<ParticleSystem>();
            var main102 = ps102.main;
            main102.duration = 0.10f;
            main102.startLifetime = 0.10f;
            main102.startSpeed = 1.00f;
            main102.startSize = 0.100f;
            main102.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission102 = ps102.emission;
            emission102.rateOverTime = 1;

            // Shape
            var shape102 = ps102.shape;
            shape102.shapeType = ParticleSystemShapeType.Sphere;
            shape102.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer102 = emitter102.GetComponent<ParticleSystemRenderer>();
            renderer102.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 103: Emitter_1004
            GameObject emitter103 = new GameObject("Emitter_103");
            emitter103.transform.SetParent(transform);
            emitter103.transform.localPosition = Vector3.zero;

            ParticleSystem ps103 = emitter103.AddComponent<ParticleSystem>();
            var main103 = ps103.main;
            main103.duration = 0.90f;
            main103.startLifetime = 0.90f;
            main103.startSpeed = 1.00f;
            main103.startSize = 0.100f;
            main103.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission103 = ps103.emission;
            emission103.rateOverTime = 3;

            // Shape
            var shape103 = ps103.shape;
            shape103.shapeType = ParticleSystemShapeType.Box;
            shape103.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer103 = emitter103.GetComponent<ParticleSystemRenderer>();
            renderer103.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 104: Emitter_1005
            GameObject emitter104 = new GameObject("Emitter_104");
            emitter104.transform.SetParent(transform);
            emitter104.transform.localPosition = Vector3.zero;

            ParticleSystem ps104 = emitter104.AddComponent<ParticleSystem>();
            var main104 = ps104.main;
            main104.duration = 0.20f;
            main104.startLifetime = 0.20f;
            main104.startSpeed = 1.00f;
            main104.startSize = 0.100f;
            main104.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission104 = ps104.emission;
            emission104.rateOverTime = 50;

            // Shape
            var shape104 = ps104.shape;
            shape104.shapeType = ParticleSystemShapeType.Sphere;
            shape104.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer104 = emitter104.GetComponent<ParticleSystemRenderer>();
            renderer104.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 105: Emitter_1004
            GameObject emitter105 = new GameObject("Emitter_105");
            emitter105.transform.SetParent(transform);
            emitter105.transform.localPosition = Vector3.zero;

            ParticleSystem ps105 = emitter105.AddComponent<ParticleSystem>();
            var main105 = ps105.main;
            main105.duration = 1.50f;
            main105.startLifetime = 1.50f;
            main105.startSpeed = 1.00f;
            main105.startSize = 0.100f;
            main105.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission105 = ps105.emission;
            emission105.rateOverTime = 3;

            // Shape
            var shape105 = ps105.shape;
            shape105.shapeType = ParticleSystemShapeType.Sphere;
            shape105.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer105 = emitter105.GetComponent<ParticleSystemRenderer>();
            renderer105.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 106: Emitter_1004
            GameObject emitter106 = new GameObject("Emitter_106");
            emitter106.transform.SetParent(transform);
            emitter106.transform.localPosition = Vector3.zero;

            ParticleSystem ps106 = emitter106.AddComponent<ParticleSystem>();
            var main106 = ps106.main;
            main106.duration = 1.50f;
            main106.startLifetime = 1.50f;
            main106.startSpeed = 1.00f;
            main106.startSize = 0.100f;
            main106.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission106 = ps106.emission;
            emission106.rateOverTime = 3;

            // Shape
            var shape106 = ps106.shape;
            shape106.shapeType = ParticleSystemShapeType.Sphere;
            shape106.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer106 = emitter106.GetComponent<ParticleSystemRenderer>();
            renderer106.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 107: Emitter_1004
            GameObject emitter107 = new GameObject("Emitter_107");
            emitter107.transform.SetParent(transform);
            emitter107.transform.localPosition = Vector3.zero;

            ParticleSystem ps107 = emitter107.AddComponent<ParticleSystem>();
            var main107 = ps107.main;
            main107.duration = 1.50f;
            main107.startLifetime = 1.50f;
            main107.startSpeed = 1.00f;
            main107.startSize = 0.100f;
            main107.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission107 = ps107.emission;
            emission107.rateOverTime = 3;

            // Shape
            var shape107 = ps107.shape;
            shape107.shapeType = ParticleSystemShapeType.Sphere;
            shape107.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer107 = emitter107.GetComponent<ParticleSystemRenderer>();
            renderer107.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 108: Emitter_1004
            GameObject emitter108 = new GameObject("Emitter_108");
            emitter108.transform.SetParent(transform);
            emitter108.transform.localPosition = Vector3.zero;

            ParticleSystem ps108 = emitter108.AddComponent<ParticleSystem>();
            var main108 = ps108.main;
            main108.duration = 1.50f;
            main108.startLifetime = 1.50f;
            main108.startSpeed = 1.00f;
            main108.startSize = 0.100f;
            main108.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission108 = ps108.emission;
            emission108.rateOverTime = 3;

            // Shape
            var shape108 = ps108.shape;
            shape108.shapeType = ParticleSystemShapeType.Sphere;
            shape108.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer108 = emitter108.GetComponent<ParticleSystemRenderer>();
            renderer108.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 109: Emitter_1004
            GameObject emitter109 = new GameObject("Emitter_109");
            emitter109.transform.SetParent(transform);
            emitter109.transform.localPosition = Vector3.zero;

            ParticleSystem ps109 = emitter109.AddComponent<ParticleSystem>();
            var main109 = ps109.main;
            main109.duration = 0.03f;
            main109.startLifetime = 0.03f;
            main109.startSpeed = 1.00f;
            main109.startSize = 0.100f;
            main109.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission109 = ps109.emission;
            emission109.rateOverTime = 1;

            // Shape
            var shape109 = ps109.shape;
            shape109.shapeType = ParticleSystemShapeType.Sphere;
            shape109.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer109 = emitter109.GetComponent<ParticleSystemRenderer>();
            renderer109.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 110: Emitter_1004
            GameObject emitter110 = new GameObject("Emitter_110");
            emitter110.transform.SetParent(transform);
            emitter110.transform.localPosition = Vector3.zero;

            ParticleSystem ps110 = emitter110.AddComponent<ParticleSystem>();
            var main110 = ps110.main;
            main110.duration = 0.03f;
            main110.startLifetime = 0.03f;
            main110.startSpeed = 1.00f;
            main110.startSize = 0.100f;
            main110.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission110 = ps110.emission;
            emission110.rateOverTime = 133;

            // Shape
            var shape110 = ps110.shape;
            shape110.shapeType = ParticleSystemShapeType.Sphere;
            shape110.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer110 = emitter110.GetComponent<ParticleSystemRenderer>();
            renderer110.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 111: Emitter_1004
            GameObject emitter111 = new GameObject("Emitter_111");
            emitter111.transform.SetParent(transform);
            emitter111.transform.localPosition = Vector3.zero;

            ParticleSystem ps111 = emitter111.AddComponent<ParticleSystem>();
            var main111 = ps111.main;
            main111.duration = 2.00f;
            main111.startLifetime = 2.00f;
            main111.startSpeed = 1.00f;
            main111.startSize = 0.100f;
            main111.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission111 = ps111.emission;
            emission111.rateOverTime = 3;

            // Shape
            var shape111 = ps111.shape;
            shape111.shapeType = ParticleSystemShapeType.Box;
            shape111.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer111 = emitter111.GetComponent<ParticleSystemRenderer>();
            renderer111.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 112: Emitter_1004
            GameObject emitter112 = new GameObject("Emitter_112");
            emitter112.transform.SetParent(transform);
            emitter112.transform.localPosition = Vector3.zero;

            ParticleSystem ps112 = emitter112.AddComponent<ParticleSystem>();
            var main112 = ps112.main;
            main112.duration = 0.20f;
            main112.startLifetime = 0.20f;
            main112.startSpeed = 1.00f;
            main112.startSize = 0.100f;
            main112.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission112 = ps112.emission;
            emission112.rateOverTime = 80;

            // Shape
            var shape112 = ps112.shape;
            shape112.shapeType = ParticleSystemShapeType.Sphere;
            shape112.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer112 = emitter112.GetComponent<ParticleSystemRenderer>();
            renderer112.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 113: Emitter_1004
            GameObject emitter113 = new GameObject("Emitter_113");
            emitter113.transform.SetParent(transform);
            emitter113.transform.localPosition = Vector3.zero;

            ParticleSystem ps113 = emitter113.AddComponent<ParticleSystem>();
            var main113 = ps113.main;
            main113.duration = 0.50f;
            main113.startLifetime = 0.50f;
            main113.startSpeed = 1.00f;
            main113.startSize = 0.100f;
            main113.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission113 = ps113.emission;
            emission113.rateOverTime = 3;

            // Shape
            var shape113 = ps113.shape;
            shape113.shapeType = ParticleSystemShapeType.Box;
            shape113.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer113 = emitter113.GetComponent<ParticleSystemRenderer>();
            renderer113.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 114: Emitter_1004
            GameObject emitter114 = new GameObject("Emitter_114");
            emitter114.transform.SetParent(transform);
            emitter114.transform.localPosition = Vector3.zero;

            ParticleSystem ps114 = emitter114.AddComponent<ParticleSystem>();
            var main114 = ps114.main;
            main114.duration = 0.10f;
            main114.startLifetime = 0.10f;
            main114.startSpeed = 1.00f;
            main114.startSize = 0.100f;
            main114.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission114 = ps114.emission;
            emission114.rateOverTime = 1;

            // Shape
            var shape114 = ps114.shape;
            shape114.shapeType = ParticleSystemShapeType.Sphere;
            shape114.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer114 = emitter114.GetComponent<ParticleSystemRenderer>();
            renderer114.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 115: Emitter_1004
            GameObject emitter115 = new GameObject("Emitter_115");
            emitter115.transform.SetParent(transform);
            emitter115.transform.localPosition = Vector3.zero;

            ParticleSystem ps115 = emitter115.AddComponent<ParticleSystem>();
            var main115 = ps115.main;
            main115.duration = 0.90f;
            main115.startLifetime = 0.90f;
            main115.startSpeed = 1.00f;
            main115.startSize = 0.100f;
            main115.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission115 = ps115.emission;
            emission115.rateOverTime = 3;

            // Shape
            var shape115 = ps115.shape;
            shape115.shapeType = ParticleSystemShapeType.Box;
            shape115.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer115 = emitter115.GetComponent<ParticleSystemRenderer>();
            renderer115.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 116: Emitter_1005
            GameObject emitter116 = new GameObject("Emitter_116");
            emitter116.transform.SetParent(transform);
            emitter116.transform.localPosition = Vector3.zero;

            ParticleSystem ps116 = emitter116.AddComponent<ParticleSystem>();
            var main116 = ps116.main;
            main116.duration = 0.20f;
            main116.startLifetime = 0.20f;
            main116.startSpeed = 1.00f;
            main116.startSize = 0.100f;
            main116.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission116 = ps116.emission;
            emission116.rateOverTime = 50;

            // Shape
            var shape116 = ps116.shape;
            shape116.shapeType = ParticleSystemShapeType.Sphere;
            shape116.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer116 = emitter116.GetComponent<ParticleSystemRenderer>();
            renderer116.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 117: Emitter_1004
            GameObject emitter117 = new GameObject("Emitter_117");
            emitter117.transform.SetParent(transform);
            emitter117.transform.localPosition = Vector3.zero;

            ParticleSystem ps117 = emitter117.AddComponent<ParticleSystem>();
            var main117 = ps117.main;
            main117.duration = 1.50f;
            main117.startLifetime = 1.50f;
            main117.startSpeed = 1.00f;
            main117.startSize = 0.100f;
            main117.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission117 = ps117.emission;
            emission117.rateOverTime = 3;

            // Shape
            var shape117 = ps117.shape;
            shape117.shapeType = ParticleSystemShapeType.Sphere;
            shape117.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer117 = emitter117.GetComponent<ParticleSystemRenderer>();
            renderer117.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 118: Emitter_1004
            GameObject emitter118 = new GameObject("Emitter_118");
            emitter118.transform.SetParent(transform);
            emitter118.transform.localPosition = Vector3.zero;

            ParticleSystem ps118 = emitter118.AddComponent<ParticleSystem>();
            var main118 = ps118.main;
            main118.duration = 1.50f;
            main118.startLifetime = 1.50f;
            main118.startSpeed = 1.00f;
            main118.startSize = 0.100f;
            main118.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission118 = ps118.emission;
            emission118.rateOverTime = 3;

            // Shape
            var shape118 = ps118.shape;
            shape118.shapeType = ParticleSystemShapeType.Sphere;
            shape118.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer118 = emitter118.GetComponent<ParticleSystemRenderer>();
            renderer118.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 119: Emitter_1004
            GameObject emitter119 = new GameObject("Emitter_119");
            emitter119.transform.SetParent(transform);
            emitter119.transform.localPosition = Vector3.zero;

            ParticleSystem ps119 = emitter119.AddComponent<ParticleSystem>();
            var main119 = ps119.main;
            main119.duration = 1.50f;
            main119.startLifetime = 1.50f;
            main119.startSpeed = 1.00f;
            main119.startSize = 0.100f;
            main119.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission119 = ps119.emission;
            emission119.rateOverTime = 3;

            // Shape
            var shape119 = ps119.shape;
            shape119.shapeType = ParticleSystemShapeType.Sphere;
            shape119.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer119 = emitter119.GetComponent<ParticleSystemRenderer>();
            renderer119.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 120: Emitter_1004
            GameObject emitter120 = new GameObject("Emitter_120");
            emitter120.transform.SetParent(transform);
            emitter120.transform.localPosition = Vector3.zero;

            ParticleSystem ps120 = emitter120.AddComponent<ParticleSystem>();
            var main120 = ps120.main;
            main120.duration = 1.50f;
            main120.startLifetime = 1.50f;
            main120.startSpeed = 1.00f;
            main120.startSize = 0.100f;
            main120.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission120 = ps120.emission;
            emission120.rateOverTime = 3;

            // Shape
            var shape120 = ps120.shape;
            shape120.shapeType = ParticleSystemShapeType.Sphere;
            shape120.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer120 = emitter120.GetComponent<ParticleSystemRenderer>();
            renderer120.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 121: Emitter_1004
            GameObject emitter121 = new GameObject("Emitter_121");
            emitter121.transform.SetParent(transform);
            emitter121.transform.localPosition = Vector3.zero;

            ParticleSystem ps121 = emitter121.AddComponent<ParticleSystem>();
            var main121 = ps121.main;
            main121.duration = 1.50f;
            main121.startLifetime = 1.50f;
            main121.startSpeed = 1.00f;
            main121.startSize = 0.100f;
            main121.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission121 = ps121.emission;
            emission121.rateOverTime = 3;

            // Shape
            var shape121 = ps121.shape;
            shape121.shapeType = ParticleSystemShapeType.Sphere;
            shape121.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer121 = emitter121.GetComponent<ParticleSystemRenderer>();
            renderer121.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 122: Emitter_1004
            GameObject emitter122 = new GameObject("Emitter_122");
            emitter122.transform.SetParent(transform);
            emitter122.transform.localPosition = Vector3.zero;

            ParticleSystem ps122 = emitter122.AddComponent<ParticleSystem>();
            var main122 = ps122.main;
            main122.duration = 1.50f;
            main122.startLifetime = 1.50f;
            main122.startSpeed = 1.00f;
            main122.startSize = 0.100f;
            main122.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission122 = ps122.emission;
            emission122.rateOverTime = 3;

            // Shape
            var shape122 = ps122.shape;
            shape122.shapeType = ParticleSystemShapeType.Sphere;
            shape122.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer122 = emitter122.GetComponent<ParticleSystemRenderer>();
            renderer122.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 123: Emitter_1004
            GameObject emitter123 = new GameObject("Emitter_123");
            emitter123.transform.SetParent(transform);
            emitter123.transform.localPosition = Vector3.zero;

            ParticleSystem ps123 = emitter123.AddComponent<ParticleSystem>();
            var main123 = ps123.main;
            main123.duration = 0.03f;
            main123.startLifetime = 0.03f;
            main123.startSpeed = 1.00f;
            main123.startSize = 0.100f;
            main123.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission123 = ps123.emission;
            emission123.rateOverTime = 1;

            // Shape
            var shape123 = ps123.shape;
            shape123.shapeType = ParticleSystemShapeType.Sphere;
            shape123.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer123 = emitter123.GetComponent<ParticleSystemRenderer>();
            renderer123.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 124: Emitter_1004
            GameObject emitter124 = new GameObject("Emitter_124");
            emitter124.transform.SetParent(transform);
            emitter124.transform.localPosition = Vector3.zero;

            ParticleSystem ps124 = emitter124.AddComponent<ParticleSystem>();
            var main124 = ps124.main;
            main124.duration = 0.03f;
            main124.startLifetime = 0.03f;
            main124.startSpeed = 1.00f;
            main124.startSize = 0.100f;
            main124.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission124 = ps124.emission;
            emission124.rateOverTime = 133;

            // Shape
            var shape124 = ps124.shape;
            shape124.shapeType = ParticleSystemShapeType.Sphere;
            shape124.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer124 = emitter124.GetComponent<ParticleSystemRenderer>();
            renderer124.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 125: Emitter_1004
            GameObject emitter125 = new GameObject("Emitter_125");
            emitter125.transform.SetParent(transform);
            emitter125.transform.localPosition = Vector3.zero;

            ParticleSystem ps125 = emitter125.AddComponent<ParticleSystem>();
            var main125 = ps125.main;
            main125.duration = 2.00f;
            main125.startLifetime = 2.00f;
            main125.startSpeed = 1.00f;
            main125.startSize = 0.100f;
            main125.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission125 = ps125.emission;
            emission125.rateOverTime = 3;

            // Shape
            var shape125 = ps125.shape;
            shape125.shapeType = ParticleSystemShapeType.Sphere;
            shape125.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer125 = emitter125.GetComponent<ParticleSystemRenderer>();
            renderer125.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

        }
    }
}
