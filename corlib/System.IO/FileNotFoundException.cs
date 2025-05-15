#if !LOCALTEST

namespace System.IO {
	public class FileNotFoundException : IOException {

		public FileNotFoundException(string msg) : base(msg) { }

		public FileNotFoundException(string msg, string file) : base(msg) { }

	}
}

#endif
