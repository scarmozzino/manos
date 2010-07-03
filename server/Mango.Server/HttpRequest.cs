


using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;

using Mono.Unix.Native;


namespace Mango.Server {

	public class HttpRequest {

		public HttpRequest (HttpConnection connection, HttpHeaders headers, string verb, string path, bool support_1_1)
		{
			Connection = connection;
			Headers = headers;
			Verb = verb;
			Path = path;
			Http_1_1_Supported = support_1_1;
		}

		public HttpConnection Connection {
			get;
			private set;
		}

		public HttpHeaders Headers {
			get;
			private set;
		}

		public string Verb {
			get;
			private set;
		}

		public string Path {
			get;
			private set;
		}

		public bool Http_1_1_Supported {
			get;
			private set;
		}
	}
}

