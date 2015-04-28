using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HelloWorld
{
    [KSPAddon(KSPAddon.Startup.EveryScene, false)]
    public class HelloWorldModule : MonoBehaviour
    {
        void Awake()
        {
            Debug.Log("ksp-example-plugins: HelloWorldModule: Hello!");
        }
    }
}
