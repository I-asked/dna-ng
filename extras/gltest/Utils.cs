using System.IO;
using Assimp;
using static RlGl.Methods;

namespace GLTest;

public static class Utils {

  public static Scene LoadScene(string filePath) {
    if (!File.Exists(filePath))
      return null;
    AssimpContext importer = new AssimpContext();
    return importer.ImportFile(filePath, PostProcessPreset.TargetRealTimeQuality | PostProcessSteps.FlipWindingOrder);
  }

}
