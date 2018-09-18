using UnityEditor;
class WebGLBuilder {
    static void build() {

        // Place all your scenes here
        string[] scenes = {"Assets/scenes/SampleScene.unity"};

        string pathToDeploy = "Built/Build.exe";       

        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.StandaloneWindows, BuildOptions.None);      
    }
}