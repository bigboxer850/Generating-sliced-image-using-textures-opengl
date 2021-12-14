#version 410

in vec3 Position;

out vec3 pos;
uniform mat4 gWorld;

void main()
{
	pos=vec3(Position.x/255,Position.y/255,Position.z/178);
	gl_Position = gWorld * vec4(0.005*Position, 1.0);
	
}
