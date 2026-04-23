using UnityEngine;

namespace IrithyllParticles
{
    /// <summary>
    /// Auto-generated particle effect script
    /// Source: f000620332.fxr
    /// Effect ID: 620332
    /// Generated emitters: 203
    /// </summary>
    public class f000620332_fxr : MonoBehaviour
    {
        void Start()
        {
            SetupParticles();
        }

        void SetupParticles()
        {
            // Emitter 1: Emitter_1002
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
            main3.duration = 0.03f;
            main3.startLifetime = 0.03f;
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
            main4.duration = 0.03f;
            main4.startLifetime = 0.03f;
            main4.startSpeed = 1.00f;
            main4.startSize = 0.100f;
            main4.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission4 = ps4.emission;
            emission4.rateOverTime = 80;

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
            emission5.rateOverTime = 1;

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
            emission6.rateOverTime = 200;

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
            emission7.rateOverTime = 3;

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
            main8.duration = 0.03f;
            main8.startLifetime = 0.03f;
            main8.startSpeed = 1.00f;
            main8.startSize = 0.100f;
            main8.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission8 = ps8.emission;
            emission8.rateOverTime = 3;

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
            main9.duration = 0.03f;
            main9.startLifetime = 0.03f;
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
            emission10.rateOverTime = 80;

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
            emission11.rateOverTime = 1;

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
            emission12.rateOverTime = 200;

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
            emission13.rateOverTime = 1;

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
            main14.duration = 0.03f;
            main14.startLifetime = 0.03f;
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

            // Emitter 18: Emitter_1004
            GameObject emitter18 = new GameObject("Emitter_18");
            emitter18.transform.SetParent(transform);
            emitter18.transform.localPosition = Vector3.zero;

            ParticleSystem ps18 = emitter18.AddComponent<ParticleSystem>();
            var main18 = ps18.main;
            main18.duration = 3.00f;
            main18.startLifetime = 3.00f;
            main18.startSpeed = 1.00f;
            main18.startSize = 0.100f;
            main18.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission18 = ps18.emission;
            emission18.rateOverTime = 3;

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
            main19.duration = 3.00f;
            main19.startLifetime = 3.00f;
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

            // Emitter 20: Emitter_1002
            GameObject emitter20 = new GameObject("Emitter_20");
            emitter20.transform.SetParent(transform);
            emitter20.transform.localPosition = Vector3.zero;

            ParticleSystem ps20 = emitter20.AddComponent<ParticleSystem>();
            var main20 = ps20.main;
            main20.duration = 2.00f;
            main20.startLifetime = 2.00f;
            main20.startSpeed = 1.00f;
            main20.startSize = 0.100f;
            main20.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission20 = ps20.emission;
            emission20.rateOverTime = 50;

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
            emission21.rateOverTime = 3;

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
            main22.duration = 0.03f;
            main22.startLifetime = 0.03f;
            main22.startSpeed = 1.00f;
            main22.startSize = 0.100f;
            main22.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission22 = ps22.emission;
            emission22.rateOverTime = 3;

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
            main23.duration = 0.03f;
            main23.startLifetime = 0.03f;
            main23.startSpeed = 1.00f;
            main23.startSize = 0.100f;
            main23.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission23 = ps23.emission;
            emission23.rateOverTime = 80;

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
            main24.duration = 0.03f;
            main24.startLifetime = 0.03f;
            main24.startSpeed = 1.00f;
            main24.startSize = 0.100f;
            main24.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission24 = ps24.emission;
            emission24.rateOverTime = 1;

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
            emission25.rateOverTime = 200;

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
            emission26.rateOverTime = 3;

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
            emission27.rateOverTime = 3;

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
            main28.duration = 0.03f;
            main28.startLifetime = 0.03f;
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
            main29.duration = 0.03f;
            main29.startLifetime = 0.03f;
            main29.startSpeed = 1.00f;
            main29.startSize = 0.100f;
            main29.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission29 = ps29.emission;
            emission29.rateOverTime = 80;

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
            main30.duration = 0.03f;
            main30.startLifetime = 0.03f;
            main30.startSpeed = 1.00f;
            main30.startSize = 0.100f;
            main30.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission30 = ps30.emission;
            emission30.rateOverTime = 1;

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
            emission31.rateOverTime = 200;

            // Shape
            var shape31 = ps31.shape;
            shape31.shapeType = ParticleSystemShapeType.Sphere;
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
            main32.duration = 0.03f;
            main32.startLifetime = 0.03f;
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
            main33.duration = 0.03f;
            main33.startLifetime = 0.03f;
            main33.startSpeed = 1.00f;
            main33.startSize = 0.100f;
            main33.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission33 = ps33.emission;
            emission33.rateOverTime = 3;

            // Shape
            var shape33 = ps33.shape;
            shape33.shapeType = ParticleSystemShapeType.Sphere;
            shape33.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer33 = emitter33.GetComponent<ParticleSystemRenderer>();
            renderer33.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 34: Emitter_1004
            GameObject emitter34 = new GameObject("Emitter_34");
            emitter34.transform.SetParent(transform);
            emitter34.transform.localPosition = Vector3.zero;

            ParticleSystem ps34 = emitter34.AddComponent<ParticleSystem>();
            var main34 = ps34.main;
            main34.duration = 0.03f;
            main34.startLifetime = 0.03f;
            main34.startSpeed = 1.00f;
            main34.startSize = 0.100f;
            main34.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission34 = ps34.emission;
            emission34.rateOverTime = 3;

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
            main35.duration = 0.03f;
            main35.startLifetime = 0.03f;
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
            main36.duration = 0.03f;
            main36.startLifetime = 0.03f;
            main36.startSpeed = 1.00f;
            main36.startSize = 0.100f;
            main36.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission36 = ps36.emission;
            emission36.rateOverTime = 80;

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
            main37.duration = 3.00f;
            main37.startLifetime = 3.00f;
            main37.startSpeed = 1.00f;
            main37.startSize = 0.100f;
            main37.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission37 = ps37.emission;
            emission37.rateOverTime = 3;

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
            main38.duration = 3.00f;
            main38.startLifetime = 3.00f;
            main38.startSpeed = 1.00f;
            main38.startSize = 0.100f;
            main38.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission38 = ps38.emission;
            emission38.rateOverTime = 3;

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
            main39.duration = 0.03f;
            main39.startLifetime = 0.03f;
            main39.startSpeed = 1.00f;
            main39.startSize = 0.100f;
            main39.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission39 = ps39.emission;
            emission39.rateOverTime = 3;

            // Shape
            var shape39 = ps39.shape;
            shape39.shapeType = ParticleSystemShapeType.Sphere;
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
            main40.duration = 0.03f;
            main40.startLifetime = 0.03f;
            main40.startSpeed = 1.00f;
            main40.startSize = 0.100f;
            main40.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission40 = ps40.emission;
            emission40.rateOverTime = 3;

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
            main41.duration = 0.03f;
            main41.startLifetime = 0.03f;
            main41.startSpeed = 1.00f;
            main41.startSize = 0.100f;
            main41.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission41 = ps41.emission;
            emission41.rateOverTime = 80;

            // Shape
            var shape41 = ps41.shape;
            shape41.shapeType = ParticleSystemShapeType.Sphere;
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
            main42.duration = 0.03f;
            main42.startLifetime = 0.03f;
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
            main43.duration = 0.03f;
            main43.startLifetime = 0.03f;
            main43.startSpeed = 1.00f;
            main43.startSize = 0.100f;
            main43.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission43 = ps43.emission;
            emission43.rateOverTime = 200;

            // Shape
            var shape43 = ps43.shape;
            shape43.shapeType = ParticleSystemShapeType.Sphere;
            shape43.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer43 = emitter43.GetComponent<ParticleSystemRenderer>();
            renderer43.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 44: Emitter_1004
            GameObject emitter44 = new GameObject("Emitter_44");
            emitter44.transform.SetParent(transform);
            emitter44.transform.localPosition = Vector3.zero;

            ParticleSystem ps44 = emitter44.AddComponent<ParticleSystem>();
            var main44 = ps44.main;
            main44.duration = 0.03f;
            main44.startLifetime = 0.03f;
            main44.startSpeed = 1.00f;
            main44.startSize = 0.100f;
            main44.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission44 = ps44.emission;
            emission44.rateOverTime = 3;

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
            main45.duration = 0.03f;
            main45.startLifetime = 0.03f;
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
            main46.duration = 0.03f;
            main46.startLifetime = 0.03f;
            main46.startSpeed = 1.00f;
            main46.startSize = 0.100f;
            main46.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission46 = ps46.emission;
            emission46.rateOverTime = 80;

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
            main47.duration = 0.03f;
            main47.startLifetime = 0.03f;
            main47.startSpeed = 1.00f;
            main47.startSize = 0.100f;
            main47.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission47 = ps47.emission;
            emission47.rateOverTime = 1;

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
            main48.duration = 0.03f;
            main48.startLifetime = 0.03f;
            main48.startSpeed = 1.00f;
            main48.startSize = 0.100f;
            main48.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission48 = ps48.emission;
            emission48.rateOverTime = 200;

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
            emission49.rateOverTime = 80;

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
            emission50.rateOverTime = 1;

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
            main51.duration = 0.03f;
            main51.startLifetime = 0.03f;
            main51.startSpeed = 1.00f;
            main51.startSize = 0.100f;
            main51.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission51 = ps51.emission;
            emission51.rateOverTime = 200;

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
            main52.duration = 0.03f;
            main52.startLifetime = 0.03f;
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

            // Emitter 53: Emitter_1004
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
            emission53.rateOverTime = 3;

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
            main54.duration = 0.03f;
            main54.startLifetime = 0.03f;
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
            main55.duration = 0.03f;
            main55.startLifetime = 0.03f;
            main55.startSpeed = 1.00f;
            main55.startSize = 0.100f;
            main55.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission55 = ps55.emission;
            emission55.rateOverTime = 80;

            // Shape
            var shape55 = ps55.shape;
            shape55.shapeType = ParticleSystemShapeType.Sphere;
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
            main56.duration = 0.03f;
            main56.startLifetime = 0.03f;
            main56.startSpeed = 1.00f;
            main56.startSize = 0.100f;
            main56.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission56 = ps56.emission;
            emission56.rateOverTime = 1;

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
            main57.duration = 0.03f;
            main57.startLifetime = 0.03f;
            main57.startSpeed = 1.00f;
            main57.startSize = 0.100f;
            main57.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission57 = ps57.emission;
            emission57.rateOverTime = 200;

            // Shape
            var shape57 = ps57.shape;
            shape57.shapeType = ParticleSystemShapeType.Sphere;
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
            main58.duration = 0.03f;
            main58.startLifetime = 0.03f;
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
            main59.duration = 0.03f;
            main59.startLifetime = 0.03f;
            main59.startSpeed = 1.00f;
            main59.startSize = 0.100f;
            main59.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission59 = ps59.emission;
            emission59.rateOverTime = 3;

            // Shape
            var shape59 = ps59.shape;
            shape59.shapeType = ParticleSystemShapeType.Sphere;
            shape59.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer59 = emitter59.GetComponent<ParticleSystemRenderer>();
            renderer59.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 60: Emitter_1004
            GameObject emitter60 = new GameObject("Emitter_60");
            emitter60.transform.SetParent(transform);
            emitter60.transform.localPosition = Vector3.zero;

            ParticleSystem ps60 = emitter60.AddComponent<ParticleSystem>();
            var main60 = ps60.main;
            main60.duration = 0.03f;
            main60.startLifetime = 0.03f;
            main60.startSpeed = 1.00f;
            main60.startSize = 0.100f;
            main60.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission60 = ps60.emission;
            emission60.rateOverTime = 3;

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
            main61.duration = 0.03f;
            main61.startLifetime = 0.03f;
            main61.startSpeed = 1.00f;
            main61.startSize = 0.100f;
            main61.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission61 = ps61.emission;
            emission61.rateOverTime = 80;

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
            main62.duration = 0.03f;
            main62.startLifetime = 0.03f;
            main62.startSpeed = 1.00f;
            main62.startSize = 0.100f;
            main62.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission62 = ps62.emission;
            emission62.rateOverTime = 1;

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
            emission63.rateOverTime = 200;

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
            emission64.rateOverTime = 1;

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
            main65.duration = 0.03f;
            main65.startLifetime = 0.03f;
            main65.startSpeed = 1.00f;
            main65.startSize = 0.100f;
            main65.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission65 = ps65.emission;
            emission65.rateOverTime = 80;

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
            main66.duration = 0.03f;
            main66.startLifetime = 0.03f;
            main66.startSpeed = 1.00f;
            main66.startSize = 0.100f;
            main66.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission66 = ps66.emission;
            emission66.rateOverTime = 1;

            // Shape
            var shape66 = ps66.shape;
            shape66.shapeType = ParticleSystemShapeType.Sphere;
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
            main67.duration = 0.03f;
            main67.startLifetime = 0.03f;
            main67.startSpeed = 1.00f;
            main67.startSize = 0.100f;
            main67.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission67 = ps67.emission;
            emission67.rateOverTime = 200;

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
            main68.duration = 0.03f;
            main68.startLifetime = 0.03f;
            main68.startSpeed = 1.00f;
            main68.startSize = 0.100f;
            main68.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission68 = ps68.emission;
            emission68.rateOverTime = 1;

            // Shape
            var shape68 = ps68.shape;
            shape68.shapeType = ParticleSystemShapeType.Sphere;
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
            main69.duration = 0.03f;
            main69.startLifetime = 0.03f;
            main69.startSpeed = 1.00f;
            main69.startSize = 0.100f;
            main69.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission69 = ps69.emission;
            emission69.rateOverTime = 3;

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
            main70.duration = 0.03f;
            main70.startLifetime = 0.03f;
            main70.startSpeed = 1.00f;
            main70.startSize = 0.100f;
            main70.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission70 = ps70.emission;
            emission70.rateOverTime = 3;

            // Shape
            var shape70 = ps70.shape;
            shape70.shapeType = ParticleSystemShapeType.Sphere;
            shape70.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer70 = emitter70.GetComponent<ParticleSystemRenderer>();
            renderer70.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 71: Emitter_1004
            GameObject emitter71 = new GameObject("Emitter_71");
            emitter71.transform.SetParent(transform);
            emitter71.transform.localPosition = Vector3.zero;

            ParticleSystem ps71 = emitter71.AddComponent<ParticleSystem>();
            var main71 = ps71.main;
            main71.duration = 0.03f;
            main71.startLifetime = 0.03f;
            main71.startSpeed = 1.00f;
            main71.startSize = 0.100f;
            main71.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission71 = ps71.emission;
            emission71.rateOverTime = 3;

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
            main72.duration = 0.03f;
            main72.startLifetime = 0.03f;
            main72.startSpeed = 1.00f;
            main72.startSize = 0.100f;
            main72.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission72 = ps72.emission;
            emission72.rateOverTime = 80;

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
            main73.duration = 0.03f;
            main73.startLifetime = 0.03f;
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
            emission74.rateOverTime = 80;

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
            emission75.rateOverTime = 80;

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
            main76.duration = 3.00f;
            main76.startLifetime = 3.00f;
            main76.startSpeed = 1.00f;
            main76.startSize = 0.100f;
            main76.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission76 = ps76.emission;
            emission76.rateOverTime = 3;

            // Shape
            var shape76 = ps76.shape;
            shape76.shapeType = ParticleSystemShapeType.Sphere;
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
            main77.duration = 3.00f;
            main77.startLifetime = 3.00f;
            main77.startSpeed = 1.00f;
            main77.startSize = 0.100f;
            main77.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission77 = ps77.emission;
            emission77.rateOverTime = 3;

            // Shape
            var shape77 = ps77.shape;
            shape77.shapeType = ParticleSystemShapeType.Sphere;
            shape77.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer77 = emitter77.GetComponent<ParticleSystemRenderer>();
            renderer77.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 78: Emitter_1002
            GameObject emitter78 = new GameObject("Emitter_78");
            emitter78.transform.SetParent(transform);
            emitter78.transform.localPosition = Vector3.zero;

            ParticleSystem ps78 = emitter78.AddComponent<ParticleSystem>();
            var main78 = ps78.main;
            main78.duration = 2.00f;
            main78.startLifetime = 2.00f;
            main78.startSpeed = 1.00f;
            main78.startSize = 0.100f;
            main78.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission78 = ps78.emission;
            emission78.rateOverTime = 50;

            // Shape
            var shape78 = ps78.shape;
            shape78.shapeType = ParticleSystemShapeType.Sphere;
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
            main79.duration = 0.03f;
            main79.startLifetime = 0.03f;
            main79.startSpeed = 1.00f;
            main79.startSize = 0.100f;
            main79.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission79 = ps79.emission;
            emission79.rateOverTime = 3;

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
            main80.duration = 0.03f;
            main80.startLifetime = 0.03f;
            main80.startSpeed = 1.00f;
            main80.startSize = 0.100f;
            main80.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission80 = ps80.emission;
            emission80.rateOverTime = 3;

            // Shape
            var shape80 = ps80.shape;
            shape80.shapeType = ParticleSystemShapeType.Sphere;
            shape80.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer80 = emitter80.GetComponent<ParticleSystemRenderer>();
            renderer80.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 81: Emitter_1004
            GameObject emitter81 = new GameObject("Emitter_81");
            emitter81.transform.SetParent(transform);
            emitter81.transform.localPosition = Vector3.zero;

            ParticleSystem ps81 = emitter81.AddComponent<ParticleSystem>();
            var main81 = ps81.main;
            main81.duration = 0.03f;
            main81.startLifetime = 0.03f;
            main81.startSpeed = 1.00f;
            main81.startSize = 0.100f;
            main81.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission81 = ps81.emission;
            emission81.rateOverTime = 80;

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
            main82.duration = 0.03f;
            main82.startLifetime = 0.03f;
            main82.startSpeed = 1.00f;
            main82.startSize = 0.100f;
            main82.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission82 = ps82.emission;
            emission82.rateOverTime = 1;

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
            main83.duration = 0.03f;
            main83.startLifetime = 0.03f;
            main83.startSpeed = 1.00f;
            main83.startSize = 0.100f;
            main83.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission83 = ps83.emission;
            emission83.rateOverTime = 200;

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
            main84.duration = 0.03f;
            main84.startLifetime = 0.03f;
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
            main85.duration = 0.03f;
            main85.startLifetime = 0.03f;
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
            emission86.rateOverTime = 3;

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
            emission87.rateOverTime = 80;

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
            main88.duration = 0.03f;
            main88.startLifetime = 0.03f;
            main88.startSpeed = 1.00f;
            main88.startSize = 0.100f;
            main88.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission88 = ps88.emission;
            emission88.rateOverTime = 1;

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
            main89.duration = 0.03f;
            main89.startLifetime = 0.03f;
            main89.startSpeed = 1.00f;
            main89.startSize = 0.100f;
            main89.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission89 = ps89.emission;
            emission89.rateOverTime = 200;

            // Shape
            var shape89 = ps89.shape;
            shape89.shapeType = ParticleSystemShapeType.Sphere;
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
            main90.duration = 0.03f;
            main90.startLifetime = 0.03f;
            main90.startSpeed = 1.00f;
            main90.startSize = 0.100f;
            main90.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission90 = ps90.emission;
            emission90.rateOverTime = 1;

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
            main91.duration = 0.03f;
            main91.startLifetime = 0.03f;
            main91.startSpeed = 1.00f;
            main91.startSize = 0.100f;
            main91.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission91 = ps91.emission;
            emission91.rateOverTime = 3;

            // Shape
            var shape91 = ps91.shape;
            shape91.shapeType = ParticleSystemShapeType.Sphere;
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
            main92.duration = 0.03f;
            main92.startLifetime = 0.03f;
            main92.startSpeed = 1.00f;
            main92.startSize = 0.100f;
            main92.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission92 = ps92.emission;
            emission92.rateOverTime = 3;

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
            main93.duration = 0.03f;
            main93.startLifetime = 0.03f;
            main93.startSpeed = 1.00f;
            main93.startSize = 0.100f;
            main93.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission93 = ps93.emission;
            emission93.rateOverTime = 3;

            // Shape
            var shape93 = ps93.shape;
            shape93.shapeType = ParticleSystemShapeType.Sphere;
            shape93.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer93 = emitter93.GetComponent<ParticleSystemRenderer>();
            renderer93.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 94: Emitter_1004
            GameObject emitter94 = new GameObject("Emitter_94");
            emitter94.transform.SetParent(transform);
            emitter94.transform.localPosition = Vector3.zero;

            ParticleSystem ps94 = emitter94.AddComponent<ParticleSystem>();
            var main94 = ps94.main;
            main94.duration = 0.03f;
            main94.startLifetime = 0.03f;
            main94.startSpeed = 1.00f;
            main94.startSize = 0.100f;
            main94.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission94 = ps94.emission;
            emission94.rateOverTime = 80;

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
            main95.duration = 3.00f;
            main95.startLifetime = 3.00f;
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
            main96.duration = 3.00f;
            main96.startLifetime = 3.00f;
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
            emission97.rateOverTime = 3;

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
            emission98.rateOverTime = 3;

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
            main99.duration = 0.03f;
            main99.startLifetime = 0.03f;
            main99.startSpeed = 1.00f;
            main99.startSize = 0.100f;
            main99.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission99 = ps99.emission;
            emission99.rateOverTime = 80;

            // Shape
            var shape99 = ps99.shape;
            shape99.shapeType = ParticleSystemShapeType.Sphere;
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
            main100.duration = 0.03f;
            main100.startLifetime = 0.03f;
            main100.startSpeed = 1.00f;
            main100.startSize = 0.100f;
            main100.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission100 = ps100.emission;
            emission100.rateOverTime = 1;

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
            main101.duration = 0.03f;
            main101.startLifetime = 0.03f;
            main101.startSpeed = 1.00f;
            main101.startSize = 0.100f;
            main101.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission101 = ps101.emission;
            emission101.rateOverTime = 200;

            // Shape
            var shape101 = ps101.shape;
            shape101.shapeType = ParticleSystemShapeType.Sphere;
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
            main102.duration = 0.03f;
            main102.startLifetime = 0.03f;
            main102.startSpeed = 1.00f;
            main102.startSize = 0.100f;
            main102.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission102 = ps102.emission;
            emission102.rateOverTime = 3;

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
            main103.duration = 0.03f;
            main103.startLifetime = 0.03f;
            main103.startSpeed = 1.00f;
            main103.startSize = 0.100f;
            main103.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission103 = ps103.emission;
            emission103.rateOverTime = 3;

            // Shape
            var shape103 = ps103.shape;
            shape103.shapeType = ParticleSystemShapeType.Sphere;
            shape103.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer103 = emitter103.GetComponent<ParticleSystemRenderer>();
            renderer103.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 104: Emitter_1004
            GameObject emitter104 = new GameObject("Emitter_104");
            emitter104.transform.SetParent(transform);
            emitter104.transform.localPosition = Vector3.zero;

            ParticleSystem ps104 = emitter104.AddComponent<ParticleSystem>();
            var main104 = ps104.main;
            main104.duration = 0.03f;
            main104.startLifetime = 0.03f;
            main104.startSpeed = 1.00f;
            main104.startSize = 0.100f;
            main104.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission104 = ps104.emission;
            emission104.rateOverTime = 80;

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
            main105.duration = 0.03f;
            main105.startLifetime = 0.03f;
            main105.startSpeed = 1.00f;
            main105.startSize = 0.100f;
            main105.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission105 = ps105.emission;
            emission105.rateOverTime = 1;

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
            main106.duration = 0.03f;
            main106.startLifetime = 0.03f;
            main106.startSpeed = 1.00f;
            main106.startSize = 0.100f;
            main106.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission106 = ps106.emission;
            emission106.rateOverTime = 200;

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
            main107.duration = 0.03f;
            main107.startLifetime = 0.03f;
            main107.startSpeed = 1.00f;
            main107.startSize = 0.100f;
            main107.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission107 = ps107.emission;
            emission107.rateOverTime = 80;

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
            main108.duration = 0.03f;
            main108.startLifetime = 0.03f;
            main108.startSpeed = 1.00f;
            main108.startSize = 0.100f;
            main108.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission108 = ps108.emission;
            emission108.rateOverTime = 1;

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
            emission109.rateOverTime = 200;

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
            emission110.rateOverTime = 3;

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
            main111.duration = 0.03f;
            main111.startLifetime = 0.03f;
            main111.startSpeed = 1.00f;
            main111.startSize = 0.100f;
            main111.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission111 = ps111.emission;
            emission111.rateOverTime = 3;

            // Shape
            var shape111 = ps111.shape;
            shape111.shapeType = ParticleSystemShapeType.Sphere;
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
            main112.duration = 0.03f;
            main112.startLifetime = 0.03f;
            main112.startSpeed = 1.00f;
            main112.startSize = 0.100f;
            main112.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission112 = ps112.emission;
            emission112.rateOverTime = 3;

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
            main113.duration = 0.03f;
            main113.startLifetime = 0.03f;
            main113.startSpeed = 1.00f;
            main113.startSize = 0.100f;
            main113.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission113 = ps113.emission;
            emission113.rateOverTime = 80;

            // Shape
            var shape113 = ps113.shape;
            shape113.shapeType = ParticleSystemShapeType.Sphere;
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
            main114.duration = 0.03f;
            main114.startLifetime = 0.03f;
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
            main115.duration = 0.03f;
            main115.startLifetime = 0.03f;
            main115.startSpeed = 1.00f;
            main115.startSize = 0.100f;
            main115.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission115 = ps115.emission;
            emission115.rateOverTime = 200;

            // Shape
            var shape115 = ps115.shape;
            shape115.shapeType = ParticleSystemShapeType.Sphere;
            shape115.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer115 = emitter115.GetComponent<ParticleSystemRenderer>();
            renderer115.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 116: Emitter_1004
            GameObject emitter116 = new GameObject("Emitter_116");
            emitter116.transform.SetParent(transform);
            emitter116.transform.localPosition = Vector3.zero;

            ParticleSystem ps116 = emitter116.AddComponent<ParticleSystem>();
            var main116 = ps116.main;
            main116.duration = 0.03f;
            main116.startLifetime = 0.03f;
            main116.startSpeed = 1.00f;
            main116.startSize = 0.100f;
            main116.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission116 = ps116.emission;
            emission116.rateOverTime = 1;

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
            main117.duration = 0.03f;
            main117.startLifetime = 0.03f;
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
            main118.duration = 0.03f;
            main118.startLifetime = 0.03f;
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
            main119.duration = 0.03f;
            main119.startLifetime = 0.03f;
            main119.startSpeed = 1.00f;
            main119.startSize = 0.100f;
            main119.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission119 = ps119.emission;
            emission119.rateOverTime = 80;

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
            main120.duration = 0.03f;
            main120.startLifetime = 0.03f;
            main120.startSpeed = 1.00f;
            main120.startSize = 0.100f;
            main120.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission120 = ps120.emission;
            emission120.rateOverTime = 1;

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
            main121.duration = 0.03f;
            main121.startLifetime = 0.03f;
            main121.startSpeed = 1.00f;
            main121.startSize = 0.100f;
            main121.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission121 = ps121.emission;
            emission121.rateOverTime = 200;

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
            main122.duration = 0.03f;
            main122.startLifetime = 0.03f;
            main122.startSpeed = 1.00f;
            main122.startSize = 0.100f;
            main122.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission122 = ps122.emission;
            emission122.rateOverTime = 1;

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
            emission123.rateOverTime = 80;

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
            emission124.rateOverTime = 1;

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
            main125.duration = 0.03f;
            main125.startLifetime = 0.03f;
            main125.startSpeed = 1.00f;
            main125.startSize = 0.100f;
            main125.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission125 = ps125.emission;
            emission125.rateOverTime = 200;

            // Shape
            var shape125 = ps125.shape;
            shape125.shapeType = ParticleSystemShapeType.Sphere;
            shape125.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer125 = emitter125.GetComponent<ParticleSystemRenderer>();
            renderer125.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 126: Emitter_1004
            GameObject emitter126 = new GameObject("Emitter_126");
            emitter126.transform.SetParent(transform);
            emitter126.transform.localPosition = Vector3.zero;

            ParticleSystem ps126 = emitter126.AddComponent<ParticleSystem>();
            var main126 = ps126.main;
            main126.duration = 0.03f;
            main126.startLifetime = 0.03f;
            main126.startSpeed = 1.00f;
            main126.startSize = 0.100f;
            main126.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission126 = ps126.emission;
            emission126.rateOverTime = 1;

            // Shape
            var shape126 = ps126.shape;
            shape126.shapeType = ParticleSystemShapeType.Sphere;
            shape126.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer126 = emitter126.GetComponent<ParticleSystemRenderer>();
            renderer126.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 127: Emitter_1004
            GameObject emitter127 = new GameObject("Emitter_127");
            emitter127.transform.SetParent(transform);
            emitter127.transform.localPosition = Vector3.zero;

            ParticleSystem ps127 = emitter127.AddComponent<ParticleSystem>();
            var main127 = ps127.main;
            main127.duration = 0.03f;
            main127.startLifetime = 0.03f;
            main127.startSpeed = 1.00f;
            main127.startSize = 0.100f;
            main127.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission127 = ps127.emission;
            emission127.rateOverTime = 3;

            // Shape
            var shape127 = ps127.shape;
            shape127.shapeType = ParticleSystemShapeType.Sphere;
            shape127.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer127 = emitter127.GetComponent<ParticleSystemRenderer>();
            renderer127.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 128: Emitter_1004
            GameObject emitter128 = new GameObject("Emitter_128");
            emitter128.transform.SetParent(transform);
            emitter128.transform.localPosition = Vector3.zero;

            ParticleSystem ps128 = emitter128.AddComponent<ParticleSystem>();
            var main128 = ps128.main;
            main128.duration = 0.03f;
            main128.startLifetime = 0.03f;
            main128.startSpeed = 1.00f;
            main128.startSize = 0.100f;
            main128.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission128 = ps128.emission;
            emission128.rateOverTime = 3;

            // Shape
            var shape128 = ps128.shape;
            shape128.shapeType = ParticleSystemShapeType.Sphere;
            shape128.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer128 = emitter128.GetComponent<ParticleSystemRenderer>();
            renderer128.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 129: Emitter_1004
            GameObject emitter129 = new GameObject("Emitter_129");
            emitter129.transform.SetParent(transform);
            emitter129.transform.localPosition = Vector3.zero;

            ParticleSystem ps129 = emitter129.AddComponent<ParticleSystem>();
            var main129 = ps129.main;
            main129.duration = 0.03f;
            main129.startLifetime = 0.03f;
            main129.startSpeed = 1.00f;
            main129.startSize = 0.100f;
            main129.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission129 = ps129.emission;
            emission129.rateOverTime = 3;

            // Shape
            var shape129 = ps129.shape;
            shape129.shapeType = ParticleSystemShapeType.Sphere;
            shape129.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer129 = emitter129.GetComponent<ParticleSystemRenderer>();
            renderer129.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 130: Emitter_1004
            GameObject emitter130 = new GameObject("Emitter_130");
            emitter130.transform.SetParent(transform);
            emitter130.transform.localPosition = Vector3.zero;

            ParticleSystem ps130 = emitter130.AddComponent<ParticleSystem>();
            var main130 = ps130.main;
            main130.duration = 0.03f;
            main130.startLifetime = 0.03f;
            main130.startSpeed = 1.00f;
            main130.startSize = 0.100f;
            main130.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission130 = ps130.emission;
            emission130.rateOverTime = 80;

            // Shape
            var shape130 = ps130.shape;
            shape130.shapeType = ParticleSystemShapeType.Sphere;
            shape130.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer130 = emitter130.GetComponent<ParticleSystemRenderer>();
            renderer130.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 131: Emitter_1004
            GameObject emitter131 = new GameObject("Emitter_131");
            emitter131.transform.SetParent(transform);
            emitter131.transform.localPosition = Vector3.zero;

            ParticleSystem ps131 = emitter131.AddComponent<ParticleSystem>();
            var main131 = ps131.main;
            main131.duration = 0.03f;
            main131.startLifetime = 0.03f;
            main131.startSpeed = 1.00f;
            main131.startSize = 0.100f;
            main131.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission131 = ps131.emission;
            emission131.rateOverTime = 3;

            // Shape
            var shape131 = ps131.shape;
            shape131.shapeType = ParticleSystemShapeType.Sphere;
            shape131.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer131 = emitter131.GetComponent<ParticleSystemRenderer>();
            renderer131.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 132: Emitter_1004
            GameObject emitter132 = new GameObject("Emitter_132");
            emitter132.transform.SetParent(transform);
            emitter132.transform.localPosition = Vector3.zero;

            ParticleSystem ps132 = emitter132.AddComponent<ParticleSystem>();
            var main132 = ps132.main;
            main132.duration = 0.03f;
            main132.startLifetime = 0.03f;
            main132.startSpeed = 1.00f;
            main132.startSize = 0.100f;
            main132.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission132 = ps132.emission;
            emission132.rateOverTime = 80;

            // Shape
            var shape132 = ps132.shape;
            shape132.shapeType = ParticleSystemShapeType.Sphere;
            shape132.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer132 = emitter132.GetComponent<ParticleSystemRenderer>();
            renderer132.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 133: Emitter_1004
            GameObject emitter133 = new GameObject("Emitter_133");
            emitter133.transform.SetParent(transform);
            emitter133.transform.localPosition = Vector3.zero;

            ParticleSystem ps133 = emitter133.AddComponent<ParticleSystem>();
            var main133 = ps133.main;
            main133.duration = 0.03f;
            main133.startLifetime = 0.03f;
            main133.startSpeed = 1.00f;
            main133.startSize = 0.100f;
            main133.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission133 = ps133.emission;
            emission133.rateOverTime = 80;

            // Shape
            var shape133 = ps133.shape;
            shape133.shapeType = ParticleSystemShapeType.Sphere;
            shape133.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer133 = emitter133.GetComponent<ParticleSystemRenderer>();
            renderer133.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 134: Emitter_1004
            GameObject emitter134 = new GameObject("Emitter_134");
            emitter134.transform.SetParent(transform);
            emitter134.transform.localPosition = Vector3.zero;

            ParticleSystem ps134 = emitter134.AddComponent<ParticleSystem>();
            var main134 = ps134.main;
            main134.duration = 3.00f;
            main134.startLifetime = 3.00f;
            main134.startSpeed = 1.00f;
            main134.startSize = 0.100f;
            main134.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission134 = ps134.emission;
            emission134.rateOverTime = 3;

            // Shape
            var shape134 = ps134.shape;
            shape134.shapeType = ParticleSystemShapeType.Sphere;
            shape134.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer134 = emitter134.GetComponent<ParticleSystemRenderer>();
            renderer134.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 135: Emitter_1004
            GameObject emitter135 = new GameObject("Emitter_135");
            emitter135.transform.SetParent(transform);
            emitter135.transform.localPosition = Vector3.zero;

            ParticleSystem ps135 = emitter135.AddComponent<ParticleSystem>();
            var main135 = ps135.main;
            main135.duration = 3.00f;
            main135.startLifetime = 3.00f;
            main135.startSpeed = 1.00f;
            main135.startSize = 0.100f;
            main135.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission135 = ps135.emission;
            emission135.rateOverTime = 3;

            // Shape
            var shape135 = ps135.shape;
            shape135.shapeType = ParticleSystemShapeType.Sphere;
            shape135.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer135 = emitter135.GetComponent<ParticleSystemRenderer>();
            renderer135.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 136: Emitter_1004
            GameObject emitter136 = new GameObject("Emitter_136");
            emitter136.transform.SetParent(transform);
            emitter136.transform.localPosition = Vector3.zero;

            ParticleSystem ps136 = emitter136.AddComponent<ParticleSystem>();
            var main136 = ps136.main;
            main136.duration = 0.03f;
            main136.startLifetime = 0.03f;
            main136.startSpeed = 1.00f;
            main136.startSize = 0.100f;
            main136.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission136 = ps136.emission;
            emission136.rateOverTime = 3;

            // Shape
            var shape136 = ps136.shape;
            shape136.shapeType = ParticleSystemShapeType.Sphere;
            shape136.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer136 = emitter136.GetComponent<ParticleSystemRenderer>();
            renderer136.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 137: Emitter_1004
            GameObject emitter137 = new GameObject("Emitter_137");
            emitter137.transform.SetParent(transform);
            emitter137.transform.localPosition = Vector3.zero;

            ParticleSystem ps137 = emitter137.AddComponent<ParticleSystem>();
            var main137 = ps137.main;
            main137.duration = 0.03f;
            main137.startLifetime = 0.03f;
            main137.startSpeed = 1.00f;
            main137.startSize = 0.100f;
            main137.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission137 = ps137.emission;
            emission137.rateOverTime = 3;

            // Shape
            var shape137 = ps137.shape;
            shape137.shapeType = ParticleSystemShapeType.Sphere;
            shape137.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer137 = emitter137.GetComponent<ParticleSystemRenderer>();
            renderer137.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 138: Emitter_1004
            GameObject emitter138 = new GameObject("Emitter_138");
            emitter138.transform.SetParent(transform);
            emitter138.transform.localPosition = Vector3.zero;

            ParticleSystem ps138 = emitter138.AddComponent<ParticleSystem>();
            var main138 = ps138.main;
            main138.duration = 0.03f;
            main138.startLifetime = 0.03f;
            main138.startSpeed = 1.00f;
            main138.startSize = 0.100f;
            main138.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission138 = ps138.emission;
            emission138.rateOverTime = 80;

            // Shape
            var shape138 = ps138.shape;
            shape138.shapeType = ParticleSystemShapeType.Sphere;
            shape138.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer138 = emitter138.GetComponent<ParticleSystemRenderer>();
            renderer138.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 139: Emitter_1004
            GameObject emitter139 = new GameObject("Emitter_139");
            emitter139.transform.SetParent(transform);
            emitter139.transform.localPosition = Vector3.zero;

            ParticleSystem ps139 = emitter139.AddComponent<ParticleSystem>();
            var main139 = ps139.main;
            main139.duration = 0.03f;
            main139.startLifetime = 0.03f;
            main139.startSpeed = 1.00f;
            main139.startSize = 0.100f;
            main139.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission139 = ps139.emission;
            emission139.rateOverTime = 1;

            // Shape
            var shape139 = ps139.shape;
            shape139.shapeType = ParticleSystemShapeType.Sphere;
            shape139.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer139 = emitter139.GetComponent<ParticleSystemRenderer>();
            renderer139.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 140: Emitter_1004
            GameObject emitter140 = new GameObject("Emitter_140");
            emitter140.transform.SetParent(transform);
            emitter140.transform.localPosition = Vector3.zero;

            ParticleSystem ps140 = emitter140.AddComponent<ParticleSystem>();
            var main140 = ps140.main;
            main140.duration = 0.03f;
            main140.startLifetime = 0.03f;
            main140.startSpeed = 1.00f;
            main140.startSize = 0.100f;
            main140.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission140 = ps140.emission;
            emission140.rateOverTime = 200;

            // Shape
            var shape140 = ps140.shape;
            shape140.shapeType = ParticleSystemShapeType.Sphere;
            shape140.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer140 = emitter140.GetComponent<ParticleSystemRenderer>();
            renderer140.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 141: Emitter_1004
            GameObject emitter141 = new GameObject("Emitter_141");
            emitter141.transform.SetParent(transform);
            emitter141.transform.localPosition = Vector3.zero;

            ParticleSystem ps141 = emitter141.AddComponent<ParticleSystem>();
            var main141 = ps141.main;
            main141.duration = 0.03f;
            main141.startLifetime = 0.03f;
            main141.startSpeed = 1.00f;
            main141.startSize = 0.100f;
            main141.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission141 = ps141.emission;
            emission141.rateOverTime = 3;

            // Shape
            var shape141 = ps141.shape;
            shape141.shapeType = ParticleSystemShapeType.Sphere;
            shape141.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer141 = emitter141.GetComponent<ParticleSystemRenderer>();
            renderer141.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 142: Emitter_1004
            GameObject emitter142 = new GameObject("Emitter_142");
            emitter142.transform.SetParent(transform);
            emitter142.transform.localPosition = Vector3.zero;

            ParticleSystem ps142 = emitter142.AddComponent<ParticleSystem>();
            var main142 = ps142.main;
            main142.duration = 0.03f;
            main142.startLifetime = 0.03f;
            main142.startSpeed = 1.00f;
            main142.startSize = 0.100f;
            main142.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission142 = ps142.emission;
            emission142.rateOverTime = 3;

            // Shape
            var shape142 = ps142.shape;
            shape142.shapeType = ParticleSystemShapeType.Sphere;
            shape142.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer142 = emitter142.GetComponent<ParticleSystemRenderer>();
            renderer142.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 143: Emitter_1004
            GameObject emitter143 = new GameObject("Emitter_143");
            emitter143.transform.SetParent(transform);
            emitter143.transform.localPosition = Vector3.zero;

            ParticleSystem ps143 = emitter143.AddComponent<ParticleSystem>();
            var main143 = ps143.main;
            main143.duration = 0.03f;
            main143.startLifetime = 0.03f;
            main143.startSpeed = 1.00f;
            main143.startSize = 0.100f;
            main143.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission143 = ps143.emission;
            emission143.rateOverTime = 80;

            // Shape
            var shape143 = ps143.shape;
            shape143.shapeType = ParticleSystemShapeType.Sphere;
            shape143.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer143 = emitter143.GetComponent<ParticleSystemRenderer>();
            renderer143.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 144: Emitter_1004
            GameObject emitter144 = new GameObject("Emitter_144");
            emitter144.transform.SetParent(transform);
            emitter144.transform.localPosition = Vector3.zero;

            ParticleSystem ps144 = emitter144.AddComponent<ParticleSystem>();
            var main144 = ps144.main;
            main144.duration = 0.03f;
            main144.startLifetime = 0.03f;
            main144.startSpeed = 1.00f;
            main144.startSize = 0.100f;
            main144.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission144 = ps144.emission;
            emission144.rateOverTime = 1;

            // Shape
            var shape144 = ps144.shape;
            shape144.shapeType = ParticleSystemShapeType.Sphere;
            shape144.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer144 = emitter144.GetComponent<ParticleSystemRenderer>();
            renderer144.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 145: Emitter_1004
            GameObject emitter145 = new GameObject("Emitter_145");
            emitter145.transform.SetParent(transform);
            emitter145.transform.localPosition = Vector3.zero;

            ParticleSystem ps145 = emitter145.AddComponent<ParticleSystem>();
            var main145 = ps145.main;
            main145.duration = 0.03f;
            main145.startLifetime = 0.03f;
            main145.startSpeed = 1.00f;
            main145.startSize = 0.100f;
            main145.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission145 = ps145.emission;
            emission145.rateOverTime = 200;

            // Shape
            var shape145 = ps145.shape;
            shape145.shapeType = ParticleSystemShapeType.Sphere;
            shape145.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer145 = emitter145.GetComponent<ParticleSystemRenderer>();
            renderer145.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 146: Emitter_1004
            GameObject emitter146 = new GameObject("Emitter_146");
            emitter146.transform.SetParent(transform);
            emitter146.transform.localPosition = Vector3.zero;

            ParticleSystem ps146 = emitter146.AddComponent<ParticleSystem>();
            var main146 = ps146.main;
            main146.duration = 0.03f;
            main146.startLifetime = 0.03f;
            main146.startSpeed = 1.00f;
            main146.startSize = 0.100f;
            main146.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission146 = ps146.emission;
            emission146.rateOverTime = 80;

            // Shape
            var shape146 = ps146.shape;
            shape146.shapeType = ParticleSystemShapeType.Sphere;
            shape146.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer146 = emitter146.GetComponent<ParticleSystemRenderer>();
            renderer146.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 147: Emitter_1004
            GameObject emitter147 = new GameObject("Emitter_147");
            emitter147.transform.SetParent(transform);
            emitter147.transform.localPosition = Vector3.zero;

            ParticleSystem ps147 = emitter147.AddComponent<ParticleSystem>();
            var main147 = ps147.main;
            main147.duration = 0.03f;
            main147.startLifetime = 0.03f;
            main147.startSpeed = 1.00f;
            main147.startSize = 0.100f;
            main147.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission147 = ps147.emission;
            emission147.rateOverTime = 1;

            // Shape
            var shape147 = ps147.shape;
            shape147.shapeType = ParticleSystemShapeType.Sphere;
            shape147.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer147 = emitter147.GetComponent<ParticleSystemRenderer>();
            renderer147.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 148: Emitter_1004
            GameObject emitter148 = new GameObject("Emitter_148");
            emitter148.transform.SetParent(transform);
            emitter148.transform.localPosition = Vector3.zero;

            ParticleSystem ps148 = emitter148.AddComponent<ParticleSystem>();
            var main148 = ps148.main;
            main148.duration = 0.03f;
            main148.startLifetime = 0.03f;
            main148.startSpeed = 1.00f;
            main148.startSize = 0.100f;
            main148.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission148 = ps148.emission;
            emission148.rateOverTime = 200;

            // Shape
            var shape148 = ps148.shape;
            shape148.shapeType = ParticleSystemShapeType.Sphere;
            shape148.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer148 = emitter148.GetComponent<ParticleSystemRenderer>();
            renderer148.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 149: Emitter_1004
            GameObject emitter149 = new GameObject("Emitter_149");
            emitter149.transform.SetParent(transform);
            emitter149.transform.localPosition = Vector3.zero;

            ParticleSystem ps149 = emitter149.AddComponent<ParticleSystem>();
            var main149 = ps149.main;
            main149.duration = 0.03f;
            main149.startLifetime = 0.03f;
            main149.startSpeed = 1.00f;
            main149.startSize = 0.100f;
            main149.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission149 = ps149.emission;
            emission149.rateOverTime = 3;

            // Shape
            var shape149 = ps149.shape;
            shape149.shapeType = ParticleSystemShapeType.Sphere;
            shape149.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer149 = emitter149.GetComponent<ParticleSystemRenderer>();
            renderer149.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 150: Emitter_1004
            GameObject emitter150 = new GameObject("Emitter_150");
            emitter150.transform.SetParent(transform);
            emitter150.transform.localPosition = Vector3.zero;

            ParticleSystem ps150 = emitter150.AddComponent<ParticleSystem>();
            var main150 = ps150.main;
            main150.duration = 0.03f;
            main150.startLifetime = 0.03f;
            main150.startSpeed = 1.00f;
            main150.startSize = 0.100f;
            main150.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission150 = ps150.emission;
            emission150.rateOverTime = 3;

            // Shape
            var shape150 = ps150.shape;
            shape150.shapeType = ParticleSystemShapeType.Sphere;
            shape150.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer150 = emitter150.GetComponent<ParticleSystemRenderer>();
            renderer150.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 151: Emitter_1004
            GameObject emitter151 = new GameObject("Emitter_151");
            emitter151.transform.SetParent(transform);
            emitter151.transform.localPosition = Vector3.zero;

            ParticleSystem ps151 = emitter151.AddComponent<ParticleSystem>();
            var main151 = ps151.main;
            main151.duration = 0.03f;
            main151.startLifetime = 0.03f;
            main151.startSpeed = 1.00f;
            main151.startSize = 0.100f;
            main151.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission151 = ps151.emission;
            emission151.rateOverTime = 80;

            // Shape
            var shape151 = ps151.shape;
            shape151.shapeType = ParticleSystemShapeType.Sphere;
            shape151.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer151 = emitter151.GetComponent<ParticleSystemRenderer>();
            renderer151.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 152: Emitter_1004
            GameObject emitter152 = new GameObject("Emitter_152");
            emitter152.transform.SetParent(transform);
            emitter152.transform.localPosition = Vector3.zero;

            ParticleSystem ps152 = emitter152.AddComponent<ParticleSystem>();
            var main152 = ps152.main;
            main152.duration = 0.03f;
            main152.startLifetime = 0.03f;
            main152.startSpeed = 1.00f;
            main152.startSize = 0.100f;
            main152.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission152 = ps152.emission;
            emission152.rateOverTime = 1;

            // Shape
            var shape152 = ps152.shape;
            shape152.shapeType = ParticleSystemShapeType.Sphere;
            shape152.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer152 = emitter152.GetComponent<ParticleSystemRenderer>();
            renderer152.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 153: Emitter_1004
            GameObject emitter153 = new GameObject("Emitter_153");
            emitter153.transform.SetParent(transform);
            emitter153.transform.localPosition = Vector3.zero;

            ParticleSystem ps153 = emitter153.AddComponent<ParticleSystem>();
            var main153 = ps153.main;
            main153.duration = 0.03f;
            main153.startLifetime = 0.03f;
            main153.startSpeed = 1.00f;
            main153.startSize = 0.100f;
            main153.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission153 = ps153.emission;
            emission153.rateOverTime = 200;

            // Shape
            var shape153 = ps153.shape;
            shape153.shapeType = ParticleSystemShapeType.Sphere;
            shape153.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer153 = emitter153.GetComponent<ParticleSystemRenderer>();
            renderer153.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 154: Emitter_1004
            GameObject emitter154 = new GameObject("Emitter_154");
            emitter154.transform.SetParent(transform);
            emitter154.transform.localPosition = Vector3.zero;

            ParticleSystem ps154 = emitter154.AddComponent<ParticleSystem>();
            var main154 = ps154.main;
            main154.duration = 0.03f;
            main154.startLifetime = 0.03f;
            main154.startSpeed = 1.00f;
            main154.startSize = 0.100f;
            main154.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission154 = ps154.emission;
            emission154.rateOverTime = 80;

            // Shape
            var shape154 = ps154.shape;
            shape154.shapeType = ParticleSystemShapeType.Sphere;
            shape154.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer154 = emitter154.GetComponent<ParticleSystemRenderer>();
            renderer154.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 155: Emitter_1004
            GameObject emitter155 = new GameObject("Emitter_155");
            emitter155.transform.SetParent(transform);
            emitter155.transform.localPosition = Vector3.zero;

            ParticleSystem ps155 = emitter155.AddComponent<ParticleSystem>();
            var main155 = ps155.main;
            main155.duration = 0.03f;
            main155.startLifetime = 0.03f;
            main155.startSpeed = 1.00f;
            main155.startSize = 0.100f;
            main155.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission155 = ps155.emission;
            emission155.rateOverTime = 1;

            // Shape
            var shape155 = ps155.shape;
            shape155.shapeType = ParticleSystemShapeType.Sphere;
            shape155.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer155 = emitter155.GetComponent<ParticleSystemRenderer>();
            renderer155.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 156: Emitter_1004
            GameObject emitter156 = new GameObject("Emitter_156");
            emitter156.transform.SetParent(transform);
            emitter156.transform.localPosition = Vector3.zero;

            ParticleSystem ps156 = emitter156.AddComponent<ParticleSystem>();
            var main156 = ps156.main;
            main156.duration = 0.03f;
            main156.startLifetime = 0.03f;
            main156.startSpeed = 1.00f;
            main156.startSize = 0.100f;
            main156.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission156 = ps156.emission;
            emission156.rateOverTime = 200;

            // Shape
            var shape156 = ps156.shape;
            shape156.shapeType = ParticleSystemShapeType.Sphere;
            shape156.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer156 = emitter156.GetComponent<ParticleSystemRenderer>();
            renderer156.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 157: Emitter_1004
            GameObject emitter157 = new GameObject("Emitter_157");
            emitter157.transform.SetParent(transform);
            emitter157.transform.localPosition = Vector3.zero;

            ParticleSystem ps157 = emitter157.AddComponent<ParticleSystem>();
            var main157 = ps157.main;
            main157.duration = 0.03f;
            main157.startLifetime = 0.03f;
            main157.startSpeed = 1.00f;
            main157.startSize = 0.100f;
            main157.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission157 = ps157.emission;
            emission157.rateOverTime = 80;

            // Shape
            var shape157 = ps157.shape;
            shape157.shapeType = ParticleSystemShapeType.Sphere;
            shape157.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer157 = emitter157.GetComponent<ParticleSystemRenderer>();
            renderer157.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 158: Emitter_1004
            GameObject emitter158 = new GameObject("Emitter_158");
            emitter158.transform.SetParent(transform);
            emitter158.transform.localPosition = Vector3.zero;

            ParticleSystem ps158 = emitter158.AddComponent<ParticleSystem>();
            var main158 = ps158.main;
            main158.duration = 0.03f;
            main158.startLifetime = 0.03f;
            main158.startSpeed = 1.00f;
            main158.startSize = 0.100f;
            main158.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission158 = ps158.emission;
            emission158.rateOverTime = 1;

            // Shape
            var shape158 = ps158.shape;
            shape158.shapeType = ParticleSystemShapeType.Sphere;
            shape158.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer158 = emitter158.GetComponent<ParticleSystemRenderer>();
            renderer158.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 159: Emitter_1004
            GameObject emitter159 = new GameObject("Emitter_159");
            emitter159.transform.SetParent(transform);
            emitter159.transform.localPosition = Vector3.zero;

            ParticleSystem ps159 = emitter159.AddComponent<ParticleSystem>();
            var main159 = ps159.main;
            main159.duration = 0.03f;
            main159.startLifetime = 0.03f;
            main159.startSpeed = 1.00f;
            main159.startSize = 0.100f;
            main159.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission159 = ps159.emission;
            emission159.rateOverTime = 200;

            // Shape
            var shape159 = ps159.shape;
            shape159.shapeType = ParticleSystemShapeType.Sphere;
            shape159.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer159 = emitter159.GetComponent<ParticleSystemRenderer>();
            renderer159.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 160: Emitter_1004
            GameObject emitter160 = new GameObject("Emitter_160");
            emitter160.transform.SetParent(transform);
            emitter160.transform.localPosition = Vector3.zero;

            ParticleSystem ps160 = emitter160.AddComponent<ParticleSystem>();
            var main160 = ps160.main;
            main160.duration = 0.03f;
            main160.startLifetime = 0.03f;
            main160.startSpeed = 1.00f;
            main160.startSize = 0.100f;
            main160.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission160 = ps160.emission;
            emission160.rateOverTime = 3;

            // Shape
            var shape160 = ps160.shape;
            shape160.shapeType = ParticleSystemShapeType.Sphere;
            shape160.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer160 = emitter160.GetComponent<ParticleSystemRenderer>();
            renderer160.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 161: Emitter_1004
            GameObject emitter161 = new GameObject("Emitter_161");
            emitter161.transform.SetParent(transform);
            emitter161.transform.localPosition = Vector3.zero;

            ParticleSystem ps161 = emitter161.AddComponent<ParticleSystem>();
            var main161 = ps161.main;
            main161.duration = 0.03f;
            main161.startLifetime = 0.03f;
            main161.startSpeed = 1.00f;
            main161.startSize = 0.100f;
            main161.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission161 = ps161.emission;
            emission161.rateOverTime = 3;

            // Shape
            var shape161 = ps161.shape;
            shape161.shapeType = ParticleSystemShapeType.Sphere;
            shape161.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer161 = emitter161.GetComponent<ParticleSystemRenderer>();
            renderer161.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 162: Emitter_1004
            GameObject emitter162 = new GameObject("Emitter_162");
            emitter162.transform.SetParent(transform);
            emitter162.transform.localPosition = Vector3.zero;

            ParticleSystem ps162 = emitter162.AddComponent<ParticleSystem>();
            var main162 = ps162.main;
            main162.duration = 0.03f;
            main162.startLifetime = 0.03f;
            main162.startSpeed = 1.00f;
            main162.startSize = 0.100f;
            main162.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission162 = ps162.emission;
            emission162.rateOverTime = 3;

            // Shape
            var shape162 = ps162.shape;
            shape162.shapeType = ParticleSystemShapeType.Sphere;
            shape162.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer162 = emitter162.GetComponent<ParticleSystemRenderer>();
            renderer162.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 163: Emitter_1004
            GameObject emitter163 = new GameObject("Emitter_163");
            emitter163.transform.SetParent(transform);
            emitter163.transform.localPosition = Vector3.zero;

            ParticleSystem ps163 = emitter163.AddComponent<ParticleSystem>();
            var main163 = ps163.main;
            main163.duration = 0.03f;
            main163.startLifetime = 0.03f;
            main163.startSpeed = 1.00f;
            main163.startSize = 0.100f;
            main163.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission163 = ps163.emission;
            emission163.rateOverTime = 80;

            // Shape
            var shape163 = ps163.shape;
            shape163.shapeType = ParticleSystemShapeType.Sphere;
            shape163.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer163 = emitter163.GetComponent<ParticleSystemRenderer>();
            renderer163.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 164: Emitter_1004
            GameObject emitter164 = new GameObject("Emitter_164");
            emitter164.transform.SetParent(transform);
            emitter164.transform.localPosition = Vector3.zero;

            ParticleSystem ps164 = emitter164.AddComponent<ParticleSystem>();
            var main164 = ps164.main;
            main164.duration = 0.03f;
            main164.startLifetime = 0.03f;
            main164.startSpeed = 1.00f;
            main164.startSize = 0.100f;
            main164.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission164 = ps164.emission;
            emission164.rateOverTime = 1;

            // Shape
            var shape164 = ps164.shape;
            shape164.shapeType = ParticleSystemShapeType.Sphere;
            shape164.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer164 = emitter164.GetComponent<ParticleSystemRenderer>();
            renderer164.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 165: Emitter_1004
            GameObject emitter165 = new GameObject("Emitter_165");
            emitter165.transform.SetParent(transform);
            emitter165.transform.localPosition = Vector3.zero;

            ParticleSystem ps165 = emitter165.AddComponent<ParticleSystem>();
            var main165 = ps165.main;
            main165.duration = 0.03f;
            main165.startLifetime = 0.03f;
            main165.startSpeed = 1.00f;
            main165.startSize = 0.100f;
            main165.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission165 = ps165.emission;
            emission165.rateOverTime = 200;

            // Shape
            var shape165 = ps165.shape;
            shape165.shapeType = ParticleSystemShapeType.Sphere;
            shape165.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer165 = emitter165.GetComponent<ParticleSystemRenderer>();
            renderer165.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 166: Emitter_1004
            GameObject emitter166 = new GameObject("Emitter_166");
            emitter166.transform.SetParent(transform);
            emitter166.transform.localPosition = Vector3.zero;

            ParticleSystem ps166 = emitter166.AddComponent<ParticleSystem>();
            var main166 = ps166.main;
            main166.duration = 0.03f;
            main166.startLifetime = 0.03f;
            main166.startSpeed = 1.00f;
            main166.startSize = 0.100f;
            main166.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission166 = ps166.emission;
            emission166.rateOverTime = 1;

            // Shape
            var shape166 = ps166.shape;
            shape166.shapeType = ParticleSystemShapeType.Sphere;
            shape166.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer166 = emitter166.GetComponent<ParticleSystemRenderer>();
            renderer166.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 167: Emitter_1004
            GameObject emitter167 = new GameObject("Emitter_167");
            emitter167.transform.SetParent(transform);
            emitter167.transform.localPosition = Vector3.zero;

            ParticleSystem ps167 = emitter167.AddComponent<ParticleSystem>();
            var main167 = ps167.main;
            main167.duration = 0.03f;
            main167.startLifetime = 0.03f;
            main167.startSpeed = 1.00f;
            main167.startSize = 0.100f;
            main167.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission167 = ps167.emission;
            emission167.rateOverTime = 3;

            // Shape
            var shape167 = ps167.shape;
            shape167.shapeType = ParticleSystemShapeType.Sphere;
            shape167.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer167 = emitter167.GetComponent<ParticleSystemRenderer>();
            renderer167.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 168: Emitter_1004
            GameObject emitter168 = new GameObject("Emitter_168");
            emitter168.transform.SetParent(transform);
            emitter168.transform.localPosition = Vector3.zero;

            ParticleSystem ps168 = emitter168.AddComponent<ParticleSystem>();
            var main168 = ps168.main;
            main168.duration = 0.03f;
            main168.startLifetime = 0.03f;
            main168.startSpeed = 1.00f;
            main168.startSize = 0.100f;
            main168.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission168 = ps168.emission;
            emission168.rateOverTime = 3;

            // Shape
            var shape168 = ps168.shape;
            shape168.shapeType = ParticleSystemShapeType.Sphere;
            shape168.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer168 = emitter168.GetComponent<ParticleSystemRenderer>();
            renderer168.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 169: Emitter_1004
            GameObject emitter169 = new GameObject("Emitter_169");
            emitter169.transform.SetParent(transform);
            emitter169.transform.localPosition = Vector3.zero;

            ParticleSystem ps169 = emitter169.AddComponent<ParticleSystem>();
            var main169 = ps169.main;
            main169.duration = 0.03f;
            main169.startLifetime = 0.03f;
            main169.startSpeed = 1.00f;
            main169.startSize = 0.100f;
            main169.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission169 = ps169.emission;
            emission169.rateOverTime = 80;

            // Shape
            var shape169 = ps169.shape;
            shape169.shapeType = ParticleSystemShapeType.Sphere;
            shape169.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer169 = emitter169.GetComponent<ParticleSystemRenderer>();
            renderer169.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 170: Emitter_1004
            GameObject emitter170 = new GameObject("Emitter_170");
            emitter170.transform.SetParent(transform);
            emitter170.transform.localPosition = Vector3.zero;

            ParticleSystem ps170 = emitter170.AddComponent<ParticleSystem>();
            var main170 = ps170.main;
            main170.duration = 0.03f;
            main170.startLifetime = 0.03f;
            main170.startSpeed = 1.00f;
            main170.startSize = 0.100f;
            main170.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission170 = ps170.emission;
            emission170.rateOverTime = 1;

            // Shape
            var shape170 = ps170.shape;
            shape170.shapeType = ParticleSystemShapeType.Sphere;
            shape170.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer170 = emitter170.GetComponent<ParticleSystemRenderer>();
            renderer170.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 171: Emitter_1004
            GameObject emitter171 = new GameObject("Emitter_171");
            emitter171.transform.SetParent(transform);
            emitter171.transform.localPosition = Vector3.zero;

            ParticleSystem ps171 = emitter171.AddComponent<ParticleSystem>();
            var main171 = ps171.main;
            main171.duration = 0.03f;
            main171.startLifetime = 0.03f;
            main171.startSpeed = 1.00f;
            main171.startSize = 0.100f;
            main171.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission171 = ps171.emission;
            emission171.rateOverTime = 200;

            // Shape
            var shape171 = ps171.shape;
            shape171.shapeType = ParticleSystemShapeType.Sphere;
            shape171.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer171 = emitter171.GetComponent<ParticleSystemRenderer>();
            renderer171.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 172: Emitter_1004
            GameObject emitter172 = new GameObject("Emitter_172");
            emitter172.transform.SetParent(transform);
            emitter172.transform.localPosition = Vector3.zero;

            ParticleSystem ps172 = emitter172.AddComponent<ParticleSystem>();
            var main172 = ps172.main;
            main172.duration = 0.03f;
            main172.startLifetime = 0.03f;
            main172.startSpeed = 1.00f;
            main172.startSize = 0.100f;
            main172.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission172 = ps172.emission;
            emission172.rateOverTime = 1;

            // Shape
            var shape172 = ps172.shape;
            shape172.shapeType = ParticleSystemShapeType.Sphere;
            shape172.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer172 = emitter172.GetComponent<ParticleSystemRenderer>();
            renderer172.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 173: Emitter_1004
            GameObject emitter173 = new GameObject("Emitter_173");
            emitter173.transform.SetParent(transform);
            emitter173.transform.localPosition = Vector3.zero;

            ParticleSystem ps173 = emitter173.AddComponent<ParticleSystem>();
            var main173 = ps173.main;
            main173.duration = 0.03f;
            main173.startLifetime = 0.03f;
            main173.startSpeed = 1.00f;
            main173.startSize = 0.100f;
            main173.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission173 = ps173.emission;
            emission173.rateOverTime = 80;

            // Shape
            var shape173 = ps173.shape;
            shape173.shapeType = ParticleSystemShapeType.Sphere;
            shape173.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer173 = emitter173.GetComponent<ParticleSystemRenderer>();
            renderer173.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 174: Emitter_1004
            GameObject emitter174 = new GameObject("Emitter_174");
            emitter174.transform.SetParent(transform);
            emitter174.transform.localPosition = Vector3.zero;

            ParticleSystem ps174 = emitter174.AddComponent<ParticleSystem>();
            var main174 = ps174.main;
            main174.duration = 0.03f;
            main174.startLifetime = 0.03f;
            main174.startSpeed = 1.00f;
            main174.startSize = 0.100f;
            main174.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission174 = ps174.emission;
            emission174.rateOverTime = 1;

            // Shape
            var shape174 = ps174.shape;
            shape174.shapeType = ParticleSystemShapeType.Sphere;
            shape174.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer174 = emitter174.GetComponent<ParticleSystemRenderer>();
            renderer174.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 175: Emitter_1004
            GameObject emitter175 = new GameObject("Emitter_175");
            emitter175.transform.SetParent(transform);
            emitter175.transform.localPosition = Vector3.zero;

            ParticleSystem ps175 = emitter175.AddComponent<ParticleSystem>();
            var main175 = ps175.main;
            main175.duration = 0.03f;
            main175.startLifetime = 0.03f;
            main175.startSpeed = 1.00f;
            main175.startSize = 0.100f;
            main175.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission175 = ps175.emission;
            emission175.rateOverTime = 200;

            // Shape
            var shape175 = ps175.shape;
            shape175.shapeType = ParticleSystemShapeType.Sphere;
            shape175.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer175 = emitter175.GetComponent<ParticleSystemRenderer>();
            renderer175.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 176: Emitter_1004
            GameObject emitter176 = new GameObject("Emitter_176");
            emitter176.transform.SetParent(transform);
            emitter176.transform.localPosition = Vector3.zero;

            ParticleSystem ps176 = emitter176.AddComponent<ParticleSystem>();
            var main176 = ps176.main;
            main176.duration = 0.03f;
            main176.startLifetime = 0.03f;
            main176.startSpeed = 1.00f;
            main176.startSize = 0.100f;
            main176.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission176 = ps176.emission;
            emission176.rateOverTime = 1;

            // Shape
            var shape176 = ps176.shape;
            shape176.shapeType = ParticleSystemShapeType.Sphere;
            shape176.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer176 = emitter176.GetComponent<ParticleSystemRenderer>();
            renderer176.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 177: Emitter_1004
            GameObject emitter177 = new GameObject("Emitter_177");
            emitter177.transform.SetParent(transform);
            emitter177.transform.localPosition = Vector3.zero;

            ParticleSystem ps177 = emitter177.AddComponent<ParticleSystem>();
            var main177 = ps177.main;
            main177.duration = 0.03f;
            main177.startLifetime = 0.03f;
            main177.startSpeed = 1.00f;
            main177.startSize = 0.100f;
            main177.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission177 = ps177.emission;
            emission177.rateOverTime = 3;

            // Shape
            var shape177 = ps177.shape;
            shape177.shapeType = ParticleSystemShapeType.Sphere;
            shape177.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer177 = emitter177.GetComponent<ParticleSystemRenderer>();
            renderer177.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 178: Emitter_1004
            GameObject emitter178 = new GameObject("Emitter_178");
            emitter178.transform.SetParent(transform);
            emitter178.transform.localPosition = Vector3.zero;

            ParticleSystem ps178 = emitter178.AddComponent<ParticleSystem>();
            var main178 = ps178.main;
            main178.duration = 0.03f;
            main178.startLifetime = 0.03f;
            main178.startSpeed = 1.00f;
            main178.startSize = 0.100f;
            main178.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission178 = ps178.emission;
            emission178.rateOverTime = 3;

            // Shape
            var shape178 = ps178.shape;
            shape178.shapeType = ParticleSystemShapeType.Sphere;
            shape178.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer178 = emitter178.GetComponent<ParticleSystemRenderer>();
            renderer178.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 179: Emitter_1004
            GameObject emitter179 = new GameObject("Emitter_179");
            emitter179.transform.SetParent(transform);
            emitter179.transform.localPosition = Vector3.zero;

            ParticleSystem ps179 = emitter179.AddComponent<ParticleSystem>();
            var main179 = ps179.main;
            main179.duration = 0.03f;
            main179.startLifetime = 0.03f;
            main179.startSpeed = 1.00f;
            main179.startSize = 0.100f;
            main179.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission179 = ps179.emission;
            emission179.rateOverTime = 80;

            // Shape
            var shape179 = ps179.shape;
            shape179.shapeType = ParticleSystemShapeType.Sphere;
            shape179.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer179 = emitter179.GetComponent<ParticleSystemRenderer>();
            renderer179.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 180: Emitter_1004
            GameObject emitter180 = new GameObject("Emitter_180");
            emitter180.transform.SetParent(transform);
            emitter180.transform.localPosition = Vector3.zero;

            ParticleSystem ps180 = emitter180.AddComponent<ParticleSystem>();
            var main180 = ps180.main;
            main180.duration = 0.03f;
            main180.startLifetime = 0.03f;
            main180.startSpeed = 1.00f;
            main180.startSize = 0.100f;
            main180.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission180 = ps180.emission;
            emission180.rateOverTime = 1;

            // Shape
            var shape180 = ps180.shape;
            shape180.shapeType = ParticleSystemShapeType.Sphere;
            shape180.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer180 = emitter180.GetComponent<ParticleSystemRenderer>();
            renderer180.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 181: Emitter_1004
            GameObject emitter181 = new GameObject("Emitter_181");
            emitter181.transform.SetParent(transform);
            emitter181.transform.localPosition = Vector3.zero;

            ParticleSystem ps181 = emitter181.AddComponent<ParticleSystem>();
            var main181 = ps181.main;
            main181.duration = 0.03f;
            main181.startLifetime = 0.03f;
            main181.startSpeed = 1.00f;
            main181.startSize = 0.100f;
            main181.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission181 = ps181.emission;
            emission181.rateOverTime = 200;

            // Shape
            var shape181 = ps181.shape;
            shape181.shapeType = ParticleSystemShapeType.Sphere;
            shape181.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer181 = emitter181.GetComponent<ParticleSystemRenderer>();
            renderer181.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 182: Emitter_1004
            GameObject emitter182 = new GameObject("Emitter_182");
            emitter182.transform.SetParent(transform);
            emitter182.transform.localPosition = Vector3.zero;

            ParticleSystem ps182 = emitter182.AddComponent<ParticleSystem>();
            var main182 = ps182.main;
            main182.duration = 0.03f;
            main182.startLifetime = 0.03f;
            main182.startSpeed = 1.00f;
            main182.startSize = 0.100f;
            main182.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission182 = ps182.emission;
            emission182.rateOverTime = 1;

            // Shape
            var shape182 = ps182.shape;
            shape182.shapeType = ParticleSystemShapeType.Sphere;
            shape182.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer182 = emitter182.GetComponent<ParticleSystemRenderer>();
            renderer182.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 183: Emitter_1004
            GameObject emitter183 = new GameObject("Emitter_183");
            emitter183.transform.SetParent(transform);
            emitter183.transform.localPosition = Vector3.zero;

            ParticleSystem ps183 = emitter183.AddComponent<ParticleSystem>();
            var main183 = ps183.main;
            main183.duration = 0.03f;
            main183.startLifetime = 0.03f;
            main183.startSpeed = 1.00f;
            main183.startSize = 0.100f;
            main183.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission183 = ps183.emission;
            emission183.rateOverTime = 80;

            // Shape
            var shape183 = ps183.shape;
            shape183.shapeType = ParticleSystemShapeType.Sphere;
            shape183.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer183 = emitter183.GetComponent<ParticleSystemRenderer>();
            renderer183.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 184: Emitter_1004
            GameObject emitter184 = new GameObject("Emitter_184");
            emitter184.transform.SetParent(transform);
            emitter184.transform.localPosition = Vector3.zero;

            ParticleSystem ps184 = emitter184.AddComponent<ParticleSystem>();
            var main184 = ps184.main;
            main184.duration = 0.03f;
            main184.startLifetime = 0.03f;
            main184.startSpeed = 1.00f;
            main184.startSize = 0.100f;
            main184.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission184 = ps184.emission;
            emission184.rateOverTime = 1;

            // Shape
            var shape184 = ps184.shape;
            shape184.shapeType = ParticleSystemShapeType.Sphere;
            shape184.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer184 = emitter184.GetComponent<ParticleSystemRenderer>();
            renderer184.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 185: Emitter_1004
            GameObject emitter185 = new GameObject("Emitter_185");
            emitter185.transform.SetParent(transform);
            emitter185.transform.localPosition = Vector3.zero;

            ParticleSystem ps185 = emitter185.AddComponent<ParticleSystem>();
            var main185 = ps185.main;
            main185.duration = 0.03f;
            main185.startLifetime = 0.03f;
            main185.startSpeed = 1.00f;
            main185.startSize = 0.100f;
            main185.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission185 = ps185.emission;
            emission185.rateOverTime = 200;

            // Shape
            var shape185 = ps185.shape;
            shape185.shapeType = ParticleSystemShapeType.Sphere;
            shape185.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer185 = emitter185.GetComponent<ParticleSystemRenderer>();
            renderer185.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 186: Emitter_1004
            GameObject emitter186 = new GameObject("Emitter_186");
            emitter186.transform.SetParent(transform);
            emitter186.transform.localPosition = Vector3.zero;

            ParticleSystem ps186 = emitter186.AddComponent<ParticleSystem>();
            var main186 = ps186.main;
            main186.duration = 0.03f;
            main186.startLifetime = 0.03f;
            main186.startSpeed = 1.00f;
            main186.startSize = 0.100f;
            main186.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission186 = ps186.emission;
            emission186.rateOverTime = 1;

            // Shape
            var shape186 = ps186.shape;
            shape186.shapeType = ParticleSystemShapeType.Sphere;
            shape186.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer186 = emitter186.GetComponent<ParticleSystemRenderer>();
            renderer186.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 187: Emitter_1004
            GameObject emitter187 = new GameObject("Emitter_187");
            emitter187.transform.SetParent(transform);
            emitter187.transform.localPosition = Vector3.zero;

            ParticleSystem ps187 = emitter187.AddComponent<ParticleSystem>();
            var main187 = ps187.main;
            main187.duration = 0.03f;
            main187.startLifetime = 0.03f;
            main187.startSpeed = 1.00f;
            main187.startSize = 0.100f;
            main187.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission187 = ps187.emission;
            emission187.rateOverTime = 80;

            // Shape
            var shape187 = ps187.shape;
            shape187.shapeType = ParticleSystemShapeType.Sphere;
            shape187.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer187 = emitter187.GetComponent<ParticleSystemRenderer>();
            renderer187.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 188: Emitter_1004
            GameObject emitter188 = new GameObject("Emitter_188");
            emitter188.transform.SetParent(transform);
            emitter188.transform.localPosition = Vector3.zero;

            ParticleSystem ps188 = emitter188.AddComponent<ParticleSystem>();
            var main188 = ps188.main;
            main188.duration = 0.03f;
            main188.startLifetime = 0.03f;
            main188.startSpeed = 1.00f;
            main188.startSize = 0.100f;
            main188.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission188 = ps188.emission;
            emission188.rateOverTime = 1;

            // Shape
            var shape188 = ps188.shape;
            shape188.shapeType = ParticleSystemShapeType.Sphere;
            shape188.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer188 = emitter188.GetComponent<ParticleSystemRenderer>();
            renderer188.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 189: Emitter_1004
            GameObject emitter189 = new GameObject("Emitter_189");
            emitter189.transform.SetParent(transform);
            emitter189.transform.localPosition = Vector3.zero;

            ParticleSystem ps189 = emitter189.AddComponent<ParticleSystem>();
            var main189 = ps189.main;
            main189.duration = 0.03f;
            main189.startLifetime = 0.03f;
            main189.startSpeed = 1.00f;
            main189.startSize = 0.100f;
            main189.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission189 = ps189.emission;
            emission189.rateOverTime = 200;

            // Shape
            var shape189 = ps189.shape;
            shape189.shapeType = ParticleSystemShapeType.Sphere;
            shape189.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer189 = emitter189.GetComponent<ParticleSystemRenderer>();
            renderer189.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 190: Emitter_1004
            GameObject emitter190 = new GameObject("Emitter_190");
            emitter190.transform.SetParent(transform);
            emitter190.transform.localPosition = Vector3.zero;

            ParticleSystem ps190 = emitter190.AddComponent<ParticleSystem>();
            var main190 = ps190.main;
            main190.duration = 0.03f;
            main190.startLifetime = 0.03f;
            main190.startSpeed = 1.00f;
            main190.startSize = 0.100f;
            main190.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission190 = ps190.emission;
            emission190.rateOverTime = 1;

            // Shape
            var shape190 = ps190.shape;
            shape190.shapeType = ParticleSystemShapeType.Sphere;
            shape190.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer190 = emitter190.GetComponent<ParticleSystemRenderer>();
            renderer190.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 191: Emitter_1004
            GameObject emitter191 = new GameObject("Emitter_191");
            emitter191.transform.SetParent(transform);
            emitter191.transform.localPosition = Vector3.zero;

            ParticleSystem ps191 = emitter191.AddComponent<ParticleSystem>();
            var main191 = ps191.main;
            main191.duration = 0.03f;
            main191.startLifetime = 0.03f;
            main191.startSpeed = 1.00f;
            main191.startSize = 0.100f;
            main191.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission191 = ps191.emission;
            emission191.rateOverTime = 3;

            // Shape
            var shape191 = ps191.shape;
            shape191.shapeType = ParticleSystemShapeType.Sphere;
            shape191.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer191 = emitter191.GetComponent<ParticleSystemRenderer>();
            renderer191.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 192: Emitter_1004
            GameObject emitter192 = new GameObject("Emitter_192");
            emitter192.transform.SetParent(transform);
            emitter192.transform.localPosition = Vector3.zero;

            ParticleSystem ps192 = emitter192.AddComponent<ParticleSystem>();
            var main192 = ps192.main;
            main192.duration = 0.03f;
            main192.startLifetime = 0.03f;
            main192.startSpeed = 1.00f;
            main192.startSize = 0.100f;
            main192.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission192 = ps192.emission;
            emission192.rateOverTime = 3;

            // Shape
            var shape192 = ps192.shape;
            shape192.shapeType = ParticleSystemShapeType.Sphere;
            shape192.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer192 = emitter192.GetComponent<ParticleSystemRenderer>();
            renderer192.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 193: Emitter_1004
            GameObject emitter193 = new GameObject("Emitter_193");
            emitter193.transform.SetParent(transform);
            emitter193.transform.localPosition = Vector3.zero;

            ParticleSystem ps193 = emitter193.AddComponent<ParticleSystem>();
            var main193 = ps193.main;
            main193.duration = 0.03f;
            main193.startLifetime = 0.03f;
            main193.startSpeed = 1.00f;
            main193.startSize = 0.100f;
            main193.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission193 = ps193.emission;
            emission193.rateOverTime = 3;

            // Shape
            var shape193 = ps193.shape;
            shape193.shapeType = ParticleSystemShapeType.Sphere;
            shape193.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer193 = emitter193.GetComponent<ParticleSystemRenderer>();
            renderer193.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 194: Emitter_1004
            GameObject emitter194 = new GameObject("Emitter_194");
            emitter194.transform.SetParent(transform);
            emitter194.transform.localPosition = Vector3.zero;

            ParticleSystem ps194 = emitter194.AddComponent<ParticleSystem>();
            var main194 = ps194.main;
            main194.duration = 0.03f;
            main194.startLifetime = 0.03f;
            main194.startSpeed = 1.00f;
            main194.startSize = 0.100f;
            main194.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission194 = ps194.emission;
            emission194.rateOverTime = 80;

            // Shape
            var shape194 = ps194.shape;
            shape194.shapeType = ParticleSystemShapeType.Sphere;
            shape194.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer194 = emitter194.GetComponent<ParticleSystemRenderer>();
            renderer194.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 195: Emitter_1004
            GameObject emitter195 = new GameObject("Emitter_195");
            emitter195.transform.SetParent(transform);
            emitter195.transform.localPosition = Vector3.zero;

            ParticleSystem ps195 = emitter195.AddComponent<ParticleSystem>();
            var main195 = ps195.main;
            main195.duration = 0.03f;
            main195.startLifetime = 0.03f;
            main195.startSpeed = 1.00f;
            main195.startSize = 0.100f;
            main195.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission195 = ps195.emission;
            emission195.rateOverTime = 3;

            // Shape
            var shape195 = ps195.shape;
            shape195.shapeType = ParticleSystemShapeType.Sphere;
            shape195.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer195 = emitter195.GetComponent<ParticleSystemRenderer>();
            renderer195.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 196: Emitter_1004
            GameObject emitter196 = new GameObject("Emitter_196");
            emitter196.transform.SetParent(transform);
            emitter196.transform.localPosition = Vector3.zero;

            ParticleSystem ps196 = emitter196.AddComponent<ParticleSystem>();
            var main196 = ps196.main;
            main196.duration = 0.03f;
            main196.startLifetime = 0.03f;
            main196.startSpeed = 1.00f;
            main196.startSize = 0.100f;
            main196.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission196 = ps196.emission;
            emission196.rateOverTime = 80;

            // Shape
            var shape196 = ps196.shape;
            shape196.shapeType = ParticleSystemShapeType.Sphere;
            shape196.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer196 = emitter196.GetComponent<ParticleSystemRenderer>();
            renderer196.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 197: Emitter_1004
            GameObject emitter197 = new GameObject("Emitter_197");
            emitter197.transform.SetParent(transform);
            emitter197.transform.localPosition = Vector3.zero;

            ParticleSystem ps197 = emitter197.AddComponent<ParticleSystem>();
            var main197 = ps197.main;
            main197.duration = 0.03f;
            main197.startLifetime = 0.03f;
            main197.startSpeed = 1.00f;
            main197.startSize = 0.100f;
            main197.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission197 = ps197.emission;
            emission197.rateOverTime = 80;

            // Shape
            var shape197 = ps197.shape;
            shape197.shapeType = ParticleSystemShapeType.Sphere;
            shape197.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer197 = emitter197.GetComponent<ParticleSystemRenderer>();
            renderer197.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 198: Emitter_1004
            GameObject emitter198 = new GameObject("Emitter_198");
            emitter198.transform.SetParent(transform);
            emitter198.transform.localPosition = Vector3.zero;

            ParticleSystem ps198 = emitter198.AddComponent<ParticleSystem>();
            var main198 = ps198.main;
            main198.duration = 0.03f;
            main198.startLifetime = 0.03f;
            main198.startSpeed = 1.00f;
            main198.startSize = 0.100f;
            main198.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission198 = ps198.emission;
            emission198.rateOverTime = 3;

            // Shape
            var shape198 = ps198.shape;
            shape198.shapeType = ParticleSystemShapeType.Sphere;
            shape198.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer198 = emitter198.GetComponent<ParticleSystemRenderer>();
            renderer198.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 199: Emitter_1004
            GameObject emitter199 = new GameObject("Emitter_199");
            emitter199.transform.SetParent(transform);
            emitter199.transform.localPosition = Vector3.zero;

            ParticleSystem ps199 = emitter199.AddComponent<ParticleSystem>();
            var main199 = ps199.main;
            main199.duration = 0.03f;
            main199.startLifetime = 0.03f;
            main199.startSpeed = 1.00f;
            main199.startSize = 0.100f;
            main199.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission199 = ps199.emission;
            emission199.rateOverTime = 80;

            // Shape
            var shape199 = ps199.shape;
            shape199.shapeType = ParticleSystemShapeType.Sphere;
            shape199.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer199 = emitter199.GetComponent<ParticleSystemRenderer>();
            renderer199.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 200: Emitter_1004
            GameObject emitter200 = new GameObject("Emitter_200");
            emitter200.transform.SetParent(transform);
            emitter200.transform.localPosition = Vector3.zero;

            ParticleSystem ps200 = emitter200.AddComponent<ParticleSystem>();
            var main200 = ps200.main;
            main200.duration = 0.03f;
            main200.startLifetime = 0.03f;
            main200.startSpeed = 1.00f;
            main200.startSize = 0.100f;
            main200.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission200 = ps200.emission;
            emission200.rateOverTime = 80;

            // Shape
            var shape200 = ps200.shape;
            shape200.shapeType = ParticleSystemShapeType.Sphere;
            shape200.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer200 = emitter200.GetComponent<ParticleSystemRenderer>();
            renderer200.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 201: Emitter_1004
            GameObject emitter201 = new GameObject("Emitter_201");
            emitter201.transform.SetParent(transform);
            emitter201.transform.localPosition = Vector3.zero;

            ParticleSystem ps201 = emitter201.AddComponent<ParticleSystem>();
            var main201 = ps201.main;
            main201.duration = 0.03f;
            main201.startLifetime = 0.03f;
            main201.startSpeed = 1.00f;
            main201.startSize = 0.100f;
            main201.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission201 = ps201.emission;
            emission201.rateOverTime = 80;

            // Shape
            var shape201 = ps201.shape;
            shape201.shapeType = ParticleSystemShapeType.Sphere;
            shape201.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer201 = emitter201.GetComponent<ParticleSystemRenderer>();
            renderer201.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 202: Emitter_1004
            GameObject emitter202 = new GameObject("Emitter_202");
            emitter202.transform.SetParent(transform);
            emitter202.transform.localPosition = Vector3.zero;

            ParticleSystem ps202 = emitter202.AddComponent<ParticleSystem>();
            var main202 = ps202.main;
            main202.duration = 3.00f;
            main202.startLifetime = 3.00f;
            main202.startSpeed = 1.00f;
            main202.startSize = 0.100f;
            main202.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission202 = ps202.emission;
            emission202.rateOverTime = 3;

            // Shape
            var shape202 = ps202.shape;
            shape202.shapeType = ParticleSystemShapeType.Sphere;
            shape202.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer202 = emitter202.GetComponent<ParticleSystemRenderer>();
            renderer202.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

            // Emitter 203: Emitter_1004
            GameObject emitter203 = new GameObject("Emitter_203");
            emitter203.transform.SetParent(transform);
            emitter203.transform.localPosition = Vector3.zero;

            ParticleSystem ps203 = emitter203.AddComponent<ParticleSystem>();
            var main203 = ps203.main;
            main203.duration = 3.00f;
            main203.startLifetime = 3.00f;
            main203.startSpeed = 1.00f;
            main203.startSize = 0.100f;
            main203.simulationSpace = ParticleSystemSimulationSpace.World;

            // Emission
            var emission203 = ps203.emission;
            emission203.rateOverTime = 3;

            // Shape
            var shape203 = ps203.shape;
            shape203.shapeType = ParticleSystemShapeType.Sphere;
            shape203.radius = 0.5f;

            // Renderer
            ParticleSystemRenderer renderer203 = emitter203.GetComponent<ParticleSystemRenderer>();
            renderer203.renderMode = ParticleSystemRenderMode.Billboard;
            // Note: Assign particle material for visual output

        }
    }
}
