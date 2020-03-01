using System;
using System.Text;

using static LTP.Interop.OpenGL.Bindings.GLFW3;
using static LTP.Interop.OpenGL.Bindings.OpenGL;

namespace LTP.Interop.OpenGL.Tests.Triangle
{
	class Program
	{
		static unsafe void Main( string[] args )
		{
			// We will need to create a GL context before calling the LTP.Interop.OpenGL.Bindings.OpenGL constructor
			glfwInit();

			void* window;
			byte[] titleBytes = Encoding.ASCII.GetBytes( "Triangle Test" );

			fixed( byte* titleBytesPtr = titleBytes )
			{
				window = glfwCreateWindow( 640, 480, titleBytesPtr, (void*)0, (void*)0 );
			}

			glfwMakeContextCurrent( window );
			// From this point on we can use the gl* methods

			glfwSwapInterval( 1 );
			glfwShowWindow( window );

			glViewport( 0, 0, 640, 480 );

			while( glfwWindowShouldClose( window ) == 0 )
			{
				glfwSwapBuffers( window );
				glfwPollEvents();
			}
		}
	}
}
