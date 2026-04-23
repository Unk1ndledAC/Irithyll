using UnityEngine;

namespace IrithyllParticles
{
    /// <summary>
    /// Auto-generated particle effect script
    /// Source: f000612310.fxr
    /// Effect ID: 612310
    /// Generated emitters: 31
    /// </summary>
    public class f000612310_fxr : MonoBehaviour
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
            main1.duration = 0.03f;
            main1.startLifetime = 0.03f;
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
            main2.duration = 0.03f;
            main2.startLifetime = 0.03f;
            main2.startSpeed = 1.00f;
            main2.startSize = 0.100f;
            main2.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission2 = ps2.emission;
            emission2.rateOverTime = 80;

            // Shape
            var shape2 = ps2.shape;
            shape2.shapeType = ParticleSystemShapeType.Sphere;
            shape2.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer2 = emitter2.GetComponent<ParticleSystemRenderer>();
            renderer2.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 3: Emitter_1005
            GameObject emitter3 = new GameObject("Emitter_3");
            emitter3.transform.SetParent(transform);
            emitter3.transform.localPosition = Vector3.zero;

            ParticleSystem ps3 = emitter3.AddComponent<ParticleSystem>();
            var main3 = ps3.main;
            main3.duration = 0.03f;
            main3.startLifetime = 0.03f;
            main3.startSpeed = 1.00f;
            main3.startSize = 0.100f;
            main3.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission3 = ps3.emission;
            emission3.rateOverTime = 50;

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
            main5.duration = 0.03f;
            main5.startLifetime = 0.03f;
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
            main6.duration = 0.03f;
            main6.startLifetime = 0.03f;
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

            // Emitter 7: Emitter_1004
            GameObject emitter7 = new GameObject("Emitter_7");
            emitter7.transform.SetParent(transform);
            emitter7.transform.localPosition = Vector3.zero;

            ParticleSystem ps7 = emitter7.AddComponent<ParticleSystem>();
            var main7 = ps7.main;
            main7.duration = 0.03f;
            main7.startLifetime = 0.03f;
            main7.startSpeed = 1.00f;
            main7.startSize = 0.100f;
            main7.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission7 = ps7.emission;
            emission7.rateOverTime = 80;

            // Shape
            var shape7 = ps7.shape;
            shape7.shapeType = ParticleSystemShapeType.Sphere;
            shape7.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer7 = emitter7.GetComponent<ParticleSystemRenderer>();
            renderer7.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 8: Emitter_1005
            GameObject emitter8 = new GameObject("Emitter_8");
            emitter8.transform.SetParent(transform);
            emitter8.transform.localPosition = Vector3.zero;

            ParticleSystem ps8 = emitter8.AddComponent<ParticleSystem>();
            var main8 = ps8.main;
            main8.duration = 0.03f;
            main8.startLifetime = 0.03f;
            main8.startSpeed = 1.00f;
            main8.startSize = 0.100f;
            main8.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission8 = ps8.emission;
            emission8.rateOverTime = 50;

            // Shape
            var shape8 = ps8.shape;
            shape8.shapeType = ParticleSystemShapeType.Sphere;
            shape8.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer8 = emitter8.GetComponent<ParticleSystemRenderer>();
            renderer8.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 9: Emitter_1004
            GameObject emitter9 = new GameObject("Emitter_9");
            emitter9.transform.SetParent(transform);
            emitter9.transform.localPosition = Vector3.zero;

            ParticleSystem ps9 = emitter9.AddComponent<ParticleSystem>();
            var main9 = ps9.main;
            main9.duration = 2.00f;
            main9.startLifetime = 2.00f;
            main9.startSpeed = 1.00f;
            main9.startSize = 0.100f;
            main9.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission9 = ps9.emission;
            emission9.rateOverTime = 3;

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
            main10.duration = 0.03f;
            main10.startLifetime = 0.03f;
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
            main11.duration = 0.03f;
            main11.startLifetime = 0.03f;
            main11.startSpeed = 1.00f;
            main11.startSize = 0.100f;
            main11.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission11 = ps11.emission;
            emission11.rateOverTime = 80;

            // Shape
            var shape11 = ps11.shape;
            shape11.shapeType = ParticleSystemShapeType.Sphere;
            shape11.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer11 = emitter11.GetComponent<ParticleSystemRenderer>();
            renderer11.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 12: Emitter_1005
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
            emission12.rateOverTime = 50;

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
            main13.duration = 2.00f;
            main13.startLifetime = 2.00f;
            main13.startSpeed = 1.00f;
            main13.startSize = 0.100f;
            main13.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission13 = ps13.emission;
            emission13.rateOverTime = 3;

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
            main15.duration = 0.03f;
            main15.startLifetime = 0.03f;
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

            // Emitter 16: Emitter_1004
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
            emission16.rateOverTime = 3;

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
            main17.duration = 0.03f;
            main17.startLifetime = 0.03f;
            main17.startSpeed = 1.00f;
            main17.startSize = 0.100f;
            main17.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission17 = ps17.emission;
            emission17.rateOverTime = 80;

            // Shape
            var shape17 = ps17.shape;
            shape17.shapeType = ParticleSystemShapeType.Sphere;
            shape17.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer17 = emitter17.GetComponent<ParticleSystemRenderer>();
            renderer17.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 18: Emitter_1005
            GameObject emitter18 = new GameObject("Emitter_18");
            emitter18.transform.SetParent(transform);
            emitter18.transform.localPosition = Vector3.zero;

            ParticleSystem ps18 = emitter18.AddComponent<ParticleSystem>();
            var main18 = ps18.main;
            main18.duration = 0.03f;
            main18.startLifetime = 0.03f;
            main18.startSpeed = 1.00f;
            main18.startSize = 0.100f;
            main18.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission18 = ps18.emission;
            emission18.rateOverTime = 50;

            // Shape
            var shape18 = ps18.shape;
            shape18.shapeType = ParticleSystemShapeType.Sphere;
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
            main19.duration = 2.00f;
            main19.startLifetime = 2.00f;
            main19.startSpeed = 1.00f;
            main19.startSize = 0.100f;
            main19.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission19 = ps19.emission;
            emission19.rateOverTime = 3;

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
            main20.duration = 0.03f;
            main20.startLifetime = 0.03f;
            main20.startSpeed = 1.00f;
            main20.startSize = 0.100f;
            main20.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission20 = ps20.emission;
            emission20.rateOverTime = 3;

            // Shape
            var shape20 = ps20.shape;
            shape20.shapeType = ParticleSystemShapeType.Sphere;
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
            main21.duration = 0.03f;
            main21.startLifetime = 0.03f;
            main21.startSpeed = 1.00f;
            main21.startSize = 0.100f;
            main21.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission21 = ps21.emission;
            emission21.rateOverTime = 80;

            // Shape
            var shape21 = ps21.shape;
            shape21.shapeType = ParticleSystemShapeType.Sphere;
            shape21.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer21 = emitter21.GetComponent<ParticleSystemRenderer>();
            renderer21.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 22: Emitter_1005
            GameObject emitter22 = new GameObject("Emitter_22");
            emitter22.transform.SetParent(transform);
            emitter22.transform.localPosition = Vector3.zero;

            ParticleSystem ps22 = emitter22.AddComponent<ParticleSystem>();
            var main22 = ps22.main;
            main22.duration = 0.03f;
            main22.startLifetime = 0.03f;
            main22.startSpeed = 1.00f;
            main22.startSize = 0.100f;
            main22.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission22 = ps22.emission;
            emission22.rateOverTime = 50;

            // Shape
            var shape22 = ps22.shape;
            shape22.shapeType = ParticleSystemShapeType.Sphere;
            shape22.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer22 = emitter22.GetComponent<ParticleSystemRenderer>();
            renderer22.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 23: Emitter_1004
            GameObject emitter23 = new GameObject("Emitter_23");
            emitter23.transform.SetParent(transform);
            emitter23.transform.localPosition = Vector3.zero;

            ParticleSystem ps23 = emitter23.AddComponent<ParticleSystem>();
            var main23 = ps23.main;
            main23.duration = 2.00f;
            main23.startLifetime = 2.00f;
            main23.startSpeed = 1.00f;
            main23.startSize = 0.100f;
            main23.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission23 = ps23.emission;
            emission23.rateOverTime = 3;

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
            main24.duration = 2.00f;
            main24.startLifetime = 2.00f;
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
            main25.duration = 0.03f;
            main25.startLifetime = 0.03f;
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
            emission26.rateOverTime = 80;

            // Shape
            var shape26 = ps26.shape;
            shape26.shapeType = ParticleSystemShapeType.Sphere;
            shape26.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer26 = emitter26.GetComponent<ParticleSystemRenderer>();
            renderer26.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 27: Emitter_1005
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
            emission27.rateOverTime = 50;

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
            main28.duration = 2.00f;
            main28.startLifetime = 2.00f;
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
            shape29.shapeType = ParticleSystemShapeType.Sphere;
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
            main30.duration = 2.00f;
            main30.startLifetime = 2.00f;
            main30.startSpeed = 1.00f;
            main30.startSize = 0.100f;
            main30.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission30 = ps30.emission;
            emission30.rateOverTime = 3;

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
            main31.duration = 0.03f;
            main31.startLifetime = 0.03f;
            main31.startSpeed = 1.00f;
            main31.startSize = 0.100f;
            main31.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission31 = ps31.emission;
            emission31.rateOverTime = 3;

            // Shape
            var shape31 = ps31.shape;
            shape31.shapeType = ParticleSystemShapeType.Sphere;
            shape31.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer31 = emitter31.GetComponent<ParticleSystemRenderer>();
            renderer31.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

        }
    }
}
