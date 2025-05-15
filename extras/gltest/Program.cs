using System;
using System.IO;
using SDL2;
using static SDL2.Methods;
using RlGl;
using static RlGl.Methods;
using cgltf;
using static cgltf.Methods;
using System.Collections.Generic;

namespace GLTest;

static class Program {
  static unsafe void Main(string[] args) {
    List<float[]> meshes;
    {
      cgltf_data *data;
      cgltf_options options;
      if (cgltf_parse_file(&options, "file.glb", &data) != cgltf_result.cgltf_result_success)
      {
        Environment.Exit(1);
      }

      cgltf_buffer_view *verticesView;
      for (int i = 0; i < (int)data->buffer_views_count; ++i) {

      }
      for (int i = 0; i < (int)data->meshes_count; ++i)
      {
        cgltf_mesh *mesh = &data->meshes[i];
        for (int j = 0; j < (int)mesh->primitives_count; ++j)
        {
          cgltf_primitive *prim = &mesh->primitives[i];
          cgltf_accessor* acc = prim->indices;
          float[] glmesh = new float[(int)acc->count];
        }
      }
    }

    SDL_Init(SDL_INIT_EVERYTHING);

    SDL_Window *win;
    SDL_Event evt;
    void *ctx;

    SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_MAJOR_VERSION, 3);
    SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_MINOR_VERSION, 3);

    SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_DOUBLEBUFFER, 1);
    SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_DEPTH_SIZE, 16);

    win = SDL_CreateWindow("Hello", (int)SDL_WINDOWPOS_CENTERED, (int)SDL_WINDOWPOS_CENTERED, 800, 600, (uint)SDL_WindowFlags.SDL_WINDOW_SHOWN | (uint)SDL_WindowFlags.SDL_WINDOW_OPENGL);
    ctx = SDL_GL_CreateContext(win);

    SDL_GL_SetSwapInterval(1);

    rlSdlLoadExtensions();

    rlglInit(800, 600);

    rlClearColor(255, 0, 0, 255);

    rlMatrixMode(RL_MODELVIEW);
    rlLoadIdentity();

    rlMatrixMode(RL_PROJECTION);
    rlLoadIdentity();

    bool shouldQuit = false;
    while (!shouldQuit) {
      unsafe { SDL_WaitEvent(&evt); }

      switch ((SDL_EventType)evt.type) {
      case SDL_EventType.SDL_QUIT:
        shouldQuit = true;
        break;
      case SDL_EventType.SDL_KEYDOWN:
        Console.WriteLine(evt.key.keysym.scancode);

        if (evt.key.keysym.scancode == SDL_Scancode.SDL_SCANCODE_ESCAPE) {
          shouldQuit = true;
        }
        break;
      }

      rlClearScreenBuffers();

      SDL_GL_SwapWindow(win);
    }

    rlglClose();

    SDL_GL_DeleteContext(ctx);

    SDL_DestroyWindow(win);
  }
}
