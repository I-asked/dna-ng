using System;
using System.Threading;
using SDL2;
using static SDL2.Methods;
using RlGl;
using static RlGl.Methods;
using GL;
using static GL.Methods;

class Program {
  static void Main(string[] args) {
    unsafe {
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

      bool shouldQuit = false;
      while (!shouldQuit) {
        unsafe { SDL_WaitEvent(&evt); }

        switch ((SDL_EventType)evt.type) {
        case SDL_EventType.SDL_QUIT:
          shouldQuit = true;
          break;
        case SDL_EventType.SDL_KEYDOWN:
          if (((SDL_KeyboardEvent *)&evt)->keysym.scancode == SDL_Scancode.SDL_SCANCODE_ESCAPE) {
            shouldQuit = true;
          }
          break;
        } 

        rlClearScreenBuffers();

        SDL_GL_SwapWindow(win);
      }
    }
  }
}
