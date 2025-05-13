using System;
using SDL2;
using static SDL2.Methods;

class Program {
  static void Main(string[] args) {
    unsafe {
      SDL_Init(SDL_INIT_EVERYTHING);

      SDL_Window *win;
      SDL_Event evt;

      win = SDL_CreateWindow("Hello", (int)SDL_WINDOWPOS_CENTERED, (int)SDL_WINDOWPOS_CENTERED, 800, 600, (uint)SDL_WindowFlags.SDL_WINDOW_OPENGL);

      bool shouldQuit = false;
      while (!shouldQuit) {
        unsafe { SDL_WaitEvent(&evt); }
        switch ((SDL_EventType)evt.type) {
        case SDL_EventType.SDL_QUIT:
          shouldQuit = true;
          break;
        } 
      }
    }
  }
}
