using System;
namespace anyworld
{
	class anyworld
	{
		static void Main(String[] args)
		{
			int peso; //Una variable tipo entero para el peso.
			double altura; //Unas que retornen en flotante para la división.
			double imc;//Acá igual.
			//string causa;a
			//string efecto;
			//string c_medica;
            /*Esos comentarios estarán ahí hasta la actualización del bucle. "Proxima update."*/
			
			string nombre_usuario;//Declaramos una variable tipo String para caracteres que serán usados despues.
		    	string apellido;//Acá igual.
			/*Postdata: En las variables de caracteres también puede ser utilicado el tipo "dinamyc o dinamic" No recuerdo como se escribe. xd
			ambas funcionan para cadena de caracteres.*/
			//Mensaje de bienvenida
			Console.WriteLine("Éste es un calculador de su IMC ´Indice de masa corporal´ el cual determina la complexión de tu cuerpo. ¿Are you ready?\n if you´re ready press any key.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("Primero antes que nada, vamos a tomar tus datos basicos.");
			Console.WriteLine("¿Cual es su nombre?");
			nombre_usuario = Convert.ToString(Console.ReadLine());
			Console.Clear();
			Console.WriteLine("¿Su apellido?");
			apellido = Convert.ToString(Console.ReadLine());
			Console.Clear();
			Console.WriteLine("Bueno, Bienvenido seas señor/a {0}", apellido+" Digite su peso en kilogramos ´Kg´: ");
			peso = Convert.ToInt16(Console.ReadLine());
			Console.Clear();
			Console.WriteLine("Bien, todo bien hasta ahora. Ahora digite su altura. ¡Ojo! La altura ha de estár en metros: (Ejemplo: 1.70) ");
			altura = Convert.ToDouble(Console.ReadLine());
			Console.Clear();
			imc = Convert.ToDouble(peso/(altura*altura));//Ahí es donde se produce el calculo 
			//Ahí comienza la fiesta
			//Let´s go, baby.
			if (imc <= 16)//Si los datos introducidos por el usuario denotan en un imc por debajo a 16 resultará en el mensaje de ahí abajo.
            {
                Console.WriteLine("Hem... No son muy buenas noticias que digamos... señor/a {0}", nombre_usuario +" Su peso está muy por debajo de los estandares.\n\n Nivel: Infrapeso\n Su imc total es: "+Math.Floor(imc));
                Console.Write("");
                Console.WriteLine("Presiona cualquier letra para salir de la consola.");
                Console.ReadKey();
            }
 
            else if (imc >= 16.00 && imc < 16.99)
            {
                Console.WriteLine("Hmph... Señor/a {0}", nombre_usuario+"No estás tan tan mal de salud, pero facilmente podría empeorar.\n\n Nivel: Infrapeso(Delgadez moderada)\n Su imc total es: "+Math.Floor(imc));
                Console.Write("");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc > 17.00 && imc < 18.49)
            {
                Console.WriteLine("Bueno, según su imc, usted no está tan tan mal señor/a {0}", nombre_usuario + "\n\nNivel: Infrapeso(Delgadez aceptable)\n Su imc total es: "+Math.Floor(imc));
                Console.Write("");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc > 18.50 && imc < 24.99)
            {
                Console.WriteLine("Resultados estandares, señor/a {0}", nombre_usuario + "\n\nTienes un peso bastante normal ~\n Su imc total es: "+Math.Floor(imc));
                Console.Write("");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc > 25.00 && imc < 29.99)
            {
                Console.WriteLine("Hum... Su peso está un poco desvalanceado, Señor/a {0}", nombre_usuario + "\n\n Tiene un poco de sobrepeso.\n Su imc total es: "+Math.Floor(imc));
                Console.Write("");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc > 30.00 && imc < 34.99)
            {
                Console.WriteLine("Es horrible {0}", nombre_usuario + "Su IMC actual indica altos niveles de grasa en su cuerpo provocando \n\nSobrepeso: Nivel I\n Su imc total es: "+Math.Floor(imc));
                Console.Write("");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
            else if (imc > 35.00 && imc < 40.00)
            {
            	Console.WriteLine("Es horrible {0}", nombre_usuario + "Quizás ya ni pueda caminar... \n\nSobrepeso: Nivel II & III\n Su imc total es: "+Math.Floor(imc));
            }
 
            else
            {
                Console.WriteLine("Hey, algo anda mal. Procura usar numeros & valores aceptables o seguir las instrucciones al pie de la letra.\n Su imc total es: "+Math.Floor(imc));
                Console.ReadKey();
            }

		}
	}
}/*Supongo que todo el codigo es facilmente legible, ya que hace uso de condiciones, variables simples & demás que cualquiera iniciando en la programacion sabría*/
