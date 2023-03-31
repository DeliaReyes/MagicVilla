namespace MagicVilla_API
{
    public class Notes
    {
        /*
         

Qué es una API
Es responsable de obtener una solicitud del cliente y responder datos en forma de respuesta


Como HTTP funciona?
Funciona a través de los verbos: Get, Post, Put, Patch, Delete

El objeto Request:
	verb
	headers
	Content
	
	Request's metadata
		Content Type: Formato del contenido
		Content Length: Tamaño del contenido
		Authorization: Quién esta haciendo el request?
		Accept: Cuáles son los tipos aceptados
		Más headers ...
		
	Request's Content
		HTML, CSS, XML, JSON
		Información del Request
		Blobs etc.
		
		
El objeto Response:
	Status Code o Códigos de Estado
		100-199: Informational
		200-299: Success
			200-Ok
			201-Created
			202-No Content
		300-399: Redirection
		400-499: Client Errors
			400-Bad Request
			404-No Found
			409-Conflict
		500-599: Server Errors
			500-Internal server error
			
			
	Response's metadata
		Content Type: Formato del contenido
		Content Length: Tamaño del contenido
		Expires: Cuando es valido
		Más headers ...
		
	Content
		HTML, CSS, XML, JSON
		Blobs etc.
		
		
C:\Users\Delia Reyes>dotnet --version
7.0.104

https://dotnet.microsoft.com/en-us/download

https://www.microsoft.com/en-us/sql-server/sql-server-downloads
Developer

Tomar el nombre del servidor durante la instalación del sql server:
Server: OBRWLAP7733

Clikc en el botón: Install SSMS






		
		
		https://www.youtube.com/watch?v=OuiExAqVapk
		Web APIs (NET 7) La Guia Completa (Crear y Consumir API)
		BaezStone Creators

		

		
	Instalar git
	https://git-scm.com
	
	C:\Users\Delia Reyes>git --version
	C:\Users\Delia Reyes>git config --global user.name "DeliaReyes"
	C:\Users\Delia Reyes>git config --global user.email "deliareyes01@hotmail.com"
	C:\Users\Delia Reyes>git config --list
	
	Abrir terminal en la solución desde visual studio
	PS C:\Users\Delia Reyes\source\repos\MagicVilla>git init
	
	Para que se suba toda la solución se indica con . (punto)
	PS C:\Users\Delia Reyes\source\repos\MagicVilla>git add .
	PS C:\Users\Delia Reyes\source\repos\MagicVilla>git commit -m "Creacion Proyecto"
	PS C:\Users\Delia Reyes\source\repos\MagicVilla>git branch -M main
	PS C:\Users\Delia Reyes\source\repos\MagicVilla>git remote add origin https://github.com/DeliaReyes/MagicVilla.git
	PS C:\Users\Delia Reyes\source\repos\MagicVilla>git push -u origin main
	
	
https://jsonpatch.com
	
Instalar estos nugets:
La versión debe de coincidir con la versión del proyecto
Microsoft.AspNetCore.JsonPatch
Microsoft.AspNetCore.Mvc.NewtonsoftJson	
		
En la clase Program.cs en la línea 5 completar la siguiente línea:
builder.Services.AddControllers().AddNewtonsoftJson();


https://localhost:7233/api/Villa/2

ORM
Object Relational Mapping

Paquetes nugets para Entity Framework
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

Server name: OBRWLAP7733


CODE FIRST - Entity Framework crea las tablas en la BD basado en los modelos que vayamos a crear
Tablas en base a los Modelos



PM> add-migration AgregarBaseDatos
PM> update-database


PM> add-migration AlimentarTablaVilla
PM> update-database


Subir cambios a GitHub

Open in Terminal
PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git add .
PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git commit -m "DbContext - Inyección de Dependencia"
PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git push -u origin main



Configurar AutoMapper y Mapping Configurar


AutoMapper
Convierte un objeto a otro

Instalar los sigs. nuggets:
AutoMapper
AutoMapper.Extensions.Microsoft.DependencyInjection

Se crea una clase para colocar las configuraciones de automapeo: MappingConfig.cs


AutoMapper en Acción


PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git add .
PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git commit -m "DTO y AutoMapper"
PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git push -u origin main

Revisar cambios en git



PM> add-migration AgregarNumeroVillaTabla
PM> update-database



	
Crear Modelo
Crear Dto
Crear DbSet en ApplicationDbContext
Ejecutar migración y update database
Crear Map
Crear Interface
Crear clase de implementación de la interface
Crear Servicio en Program

	
PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git add .
PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git commit -m "Patron Repositorio"
PS C:\Users\Delia Reyes\source\repos\MagicVilla\MagicVilla_API> git push -u origin main

Revisamos cambios en la cuenta de github


         */
    }
}
