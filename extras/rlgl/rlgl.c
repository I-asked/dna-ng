#define RLGL_IMPLEMENTATION
#include "rlgl_sdl.h"

#include <SDL2/SDL.h>

void rlSdlLoadExtensions(void) __attribute__((visibility("default")));
void rlSdlLoadExtensions(void) {
  return rlLoadExtensions(SDL_GL_GetProcAddress);
}
