
instrucciones: 

abrir APItaiRPSvf

ejecutar APItaiRPS.sln

abrir RPSangularTai en visual estudio Code

Abrir terminal integrado 

ejecutar PS C:\Users\User\RPSangularTai> ng serve --open

Jugar!



direccion de la API https://localhost:7000

direccion de AngularApp: https://localhost:4200

correcciones de version Final ( la x significa corregido y revisado)

  .Net
    Dependencia de .netCors innecesaria (con warnings) (x)
    Cargar los movimientos por defecto al migrar la base de datos ( no se vio ningun problema)
    Las vistas de razor no se pueden acceder (si no se usan eliminarlas) (x)
    en todo caso lo mejor es no tener una parte de la implementación en angular y otra en razor

    Menores
    Clase SecondMigrations está vacía (x)
    Usings sin utilizar en varios archivos


    Angular
    Usar clases tipadas (ejemplo data en GamelogService) (evitar el uso de "any") ( no se vio ningun problema)
    No usar URL a la API. Está hardcodeada en lugares diferentes (gamelog service está llamando a swagger) (x)
    Eliminar console.log (X)
    Mejorar readme para levantar/correr el ambiente
    Evitar uso de variables abreviadas
    Usar camelCase consistentemente, por ejemplo:
    - GetmovesService, debería ser GetMovesService (x)
    - MoveList$!:Observable<any[]>; debería empezar en