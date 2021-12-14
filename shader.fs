#version 410

in vec3 pos;
uniform sampler3D ourTexture;
uniform sampler1D ourText;
uniform int now;

void main()
{
	int z=40;
	if(now==1){
			 vec4 colour=texture(ourTexture, pos);

			 vec4 col=texture(ourText,colour.x);
			
			
			//colour.y=colour.y+0.2;
				 gl_FragColor =col;
			
		}

	 if(now==2)
	 gl_FragColor=vec4(1.0,1.0,1.0,1.0);
	 }
