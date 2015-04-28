# HelloWorld

This is pretty much the simplest plugin possible.

# How was it built?

## Visual Studio

### Close all existing solutions/projects

Use the “File” menu's “Close Solution” item if you have one open already.

### Create a new project

1. “File” menu, “New” -> “Project”. (Ctrl-Shift N, since apparently it deserves a shortcut)
2. Select “Class Library” from the “Visual C#” template list.
3. Use “HelloWorld” as the Name as well as Solution Name.
4. This will create the HelloWorld namespace, and start you off in Class1.cs.

### Rename the class to “HelloWorldModule”

1. Select “Class1” in the code line containing “public class Class1”, and
   right click and select “Refactor” -> “Rename” (or press Ctrl-R twice).
2. Rename to “HelloWorldModule”.
3. Confirm the rename, noting that the filename will be changed from Class1.cs to HelloWorldModule.cs

### Inherit from MonoBehaviour (note the UK spelling)
1. After “public class HelloWorldModule”, add “: MonoBehaviour”.
2. The full line will now be: “public class HelloWorldModule : MonoBehaviour”.
3. Note the angry red underline showing that Visual Studio has no idea what MonoBehaviour is.
4. Add “using UnityEngine;” below the other “using ...” statements.  This is where MonoBehaviour is defined.
5. Try to build using the “Build” menu’s “Build Solution” item (or Ctrl-shift-B).  It will
   fail, since Visual Studio does not know where to find UnityEngine’s dll.

### Add project references to the KSP libraries

1. Locate KSP on your hard drive (for Steam, look in “Program File (x86)/Steam/SteamApps/common/”)
2. Find the “Solution Explorer” tab, likely on the top right of your Visual
   Studio window.  If you want to return to the default Visual Studio
   layout, use the “Window” menu to find “Reset Window Layout”.
3. Select the project - it should be “HelloWorld” with a C# icon, below “Solution ‘HelloWorld’ (1 project)”.
4. Right click, select the “Add...” menu item, and choose “Reference...”
   (you can also right click on the “References” item in the tree under the
   project).
5. Select the “Browse...” button in the bottom right (next to “Ok”), and find your KSP install.
6. Go into “KSP_Data/Managed” under your KSP installation directory, and
   then multi-select (Control + left click on each) “Assembly-CSharp.dll”
   and “UnityEngine.dll”.

### Build and succeed

Try to build again.  This should now succeed.  If not, check the process listed
above carefully.  Ensure “Assembly-CSharp” and “UnityEngine” show up in
“References” in the “Solution Explorer”.

Check any underlined red marks in your code, and also check the build error
message to see if you can figure out what is up.

Worst case, use a lifeline and call a friend.

### Do something

The class needs to describe to KSP under what circumstances it must be
instantiated.  Should it be created and woken up at the start, or only during
flights?

Add the following line to start up in every scene (scenes are things like
Flight, the Main Menu, the VAB or SPH).

    [KSPAddon(KSPAddon.Startup.EveryScene, false)]

Add an “Awake” method that will now be called whenever a new scene starts.

    void Awake()
    {
        Debug.Log("ksp-example-plugins: HelloWorldModule: Hello!");
    }

This will simply print to the debug log.

### Build and ship

Once you’ve built your plugin, it will create HelloWorld.dll.  The path to this will be in the build output:

>   HelloWorld -> C:\Users\\...\\HelloWorld\HelloWorld\bin\Debug\HelloWorld.dll

Create a folder under “GameData” in your KSP installation directory.  Place
HelloWorld.dll in there.

### Watch the logs

Look at “KSP.log” in your KSP installation directory for your debug output.
Or, for some error when loading your plugin.
