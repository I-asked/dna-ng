using System;
using System.Text;
using SDL2;
using static SDL2.Methods;

class Program {
  static void Main(string[] args) {
    sbyte[] bytes = new sbyte[1] { 0 };

    SDL_Init(SDL_INIT_EVERYTHING);

    unsafe {
      fixed (sbyte *b = &bytes[0]) {
        SDL_CreateWindow(b, (int)SDL_WINDOWPOS_CENTERED, (int)SDL_WINDOWPOS_CENTERED, 800, 600, (uint)SDL_WindowFlags.SDL_WINDOW_OPENGL);
      }
    }
  }
}
