using Assimp;
using static RlGl.Methods;

namespace GLTest;

public static class AssimpExt {

  public static void Draw(this Scene scene) {
    foreach (var mesh in scene.Meshes) {
      rlBegin(RL_TRIANGLES);
      foreach (var face in mesh.Faces) {
        for (int i = 0; i < 3; ++i) {
          var vertex = mesh.Vertices[face.Indices[i]];
          rlVertex3f(vertex.X, vertex.Y, vertex.Z);

          if (mesh.HasNormals) {
            var normal = mesh.Normals[face.Indices[i]];
            rlNormal3f(normal.X, normal.Y, normal.Z);
          }

          //if (mesh.HasTextureCoords(0)) {
          //  var uv = mesh.TextureCoordinateChannels[0][face.Indices[i]];
          //  rlTexCoord2f(uv.X, uv.Y);
          //}

          if (mesh.HasVertexColors(0)) {
            var color = mesh.VertexColorChannels[0][face.Indices[i]];
            rlColor4f(color.R, color.G, color.B, color.A);
          } else {
            rlColor4f(1.0f, 1.0f, 1.0f, 1.0f);
          }
        }
      }
      rlEnd();
    }
  }

}
