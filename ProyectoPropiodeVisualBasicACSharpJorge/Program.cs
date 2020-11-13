using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System;
using Microsoft.VisualBasic;

static class Module1
{
    // copiar desde aquí 
    // hasta antes de end module 
    // y copiarlo en un archivo 
    // creado en visual studio
    // con siguiendo el menu
    // crear  un proyecto
    // y después elejir las opciopnes
    // visual basic vindows y consola
    // luego poner un nombre que quieras
    // y despues aceptar
    // despues ahi copiar este archivo
    // con copia y pega o tecleando
    // a vuestra eleción.
    // Este programa esta Basado en discoduro de roer y otras webs 
    // problemas con el pase de Vb a C#
    public static void Main()
    {
        AcercaDe(); // infomacion del progrograma
        Console.Clear(); // borra pantalla

        Menu1(); // va al primer menu
    }

    private static void Menu1()
    {
        Marco(); // crear el marco

        Console.SetCursorPosition(20, 3); // pon el cursor en una posicion
        Console.WriteLine(" menu de programas 1"); // ' muestra en la cordenadas abnteriores 

        Console.SetCursorPosition(10, 5); // nueva de posicion
        Console.WriteLine("0.-fin el programa"); // l
        Console.SetCursorPosition(10, 6); // pone en posicion de nuevo el corsor
        Console.WriteLine("1.-Hola como te llamas"); // si pulsar el uno y luego enter va saludarte

        Console.SetCursorPosition(10, 7); // vulve a cambiar la posicion 
        Console.WriteLine("2.-numeros aleatorios"); // en la nuva posicion muestra

        Console.SetCursorPosition(10, 8); // nueva de posicion
        Console.WriteLine("3.-insertar números en un array y luego mostarlos"); // lo que se muestra al operador

        Console.SetCursorPosition(10, 9); // nueva posicio del cursor
        Console.WriteLine("4.-Arear de un triabgulo"); // lo muestra al operador

        Console.SetCursorPosition(10, 10); // nueva posicon del cursor
        Console.WriteLine("5.-Banco"); // muestra al operador

        Console.SetCursorPosition(10, 11); // nueva posicion del curosr
        Console.WriteLine("6.-Tipos de un triangulo"); // lo mostrado aloperador 


        Console.SetCursorPosition(10, 12); // nueva posicion del curosr
        Console.WriteLine("7.-Promedio"); // todavia no ha sido asigana


        Console.SetCursorPosition(10, 13); // nueva posicion del curosr
        Console.WriteLine("8.-Factorial"); // toda via no ha sido asignada


        Console.SetCursorPosition(10, 14); // nueva posicion del curosr
        Console.WriteLine("9.-Ir al menu 2"); // ' se pulsa a esta opcion va la segundo botpn

        Console.SetCursorPosition(10, 20); // nueva posicion del ccursor
        Console.Write("¿ cual es tu opcion? pulse enter despues de apretar el número:"); // preguna por numero
        string opcion; // crea la variable para opciones
        bool verdad;
        do
        {
            try
            {
                opcion = Console.ReadLine();
                Eleccion(opcion);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(10, 22);
                Console.Write(" Opcion equivocada");
            }
        }
        while (!verdad == true)// recoge el valor// aqui va a a la funcion elecion con la opcion selecionada
;


        Borrado(); // borara el marco 
        // Console.ReadKey() ' espera a que pulse una tecla

        Marco(); // crea de nuevo el cuadro
    }


    private static int Eleccion(object opcion) // funcio e las opciones
    {
        switch (opcion)
        {
            case 0 // opcion de salir del progrma
           :
                {
                    Borrado(); // va ha borrado
                    Marco(); // va al marco
                    Console.SetCursorPosition(10, 10); // en la posicion
                    Console.WriteLine("Gracias por haber participado en esta presentacion"); // muesstra en la posicion
                    Borrado(); // va al borafo
                    System.Environment.Exit(0); // fin del rograma
                    break;
                }

            case 1:
                {
                    Borrado(); // va a borrar la pantalla
                    Marco(); // crea el marco
                    Holanombre(); // va ha hola nombre

                    Borrado(); // va al borrado

                    Menu1();// despesu delborrado va al menu 1
                    break;
                }

            case 2:
                {
                    Borrado();
                    Marco();
                    Generarnumerosetrediezycien(); // va al metodo paa generar numeros entre 10 y cien
                    Console.ReadKey(); // espera que se de alhuna tecka

                    Borrado(); // va a borrar la pantalla

                    Menu1();// al menu 1
                    break;
                }

            case 3:
                {
                    IntroduccionArrays(); // va a introducir un array
                    Menu1();// va al menu 1
                    break;
                }

            case 4:
                {
                    Borrado(); // borra marco
                    Marco(); // crea marco
                    Areeadeuntrianguolo(); // va ha areae de un triangulo
                    Borrado(); // va al borrado dee pantala 
                    Menu1(); // va al menu 1
                    break;
                }

            case 5 // opcion del banco
     :
                {
                    Banco(); // va al banco
                    Borrado(); // borra la pantalla
                    Menu1(); // va al menu 1
                    break;
                }

            case 6:
                {
                    Borrado(); // va a borrado 
                    Marco(); // a al marco
                    Console.SetCursorPosition(10, 10); // en la posicion 
                    Console.WriteLine("Tipos de un triangulo"); // muestraen pantalla 
                    Tipostringulos(); // va tipos de trisngulos

                    Borrado(); // va al borrado    
                    Menu1(); // va la menu 1
                    break;
                }

            case 7:
                {
                    Borrado(); // borrala panalla 
                    Marco(); // crea el marco 
                    PromeMedio(); // va a promedio 
                    Borrado(); // va al borrado 
                    Menu1(); // va la menu 1
                    break;
                }

            case 8:
                {
                    Borrado(); // borrado de pantalla 
                    Marco(); // va la marco 
                    preguntafactorial(); // factorial del pro

                    Borrado(); // borrado
                    Menu1(); // va la menu 1
                    break;
                }

            case 9:
                {
                    Borrado(); // borra el marco 
                    Menu2(); // va al menu 2
                    break;
                }

            default:
                {
                    Borrado(); // va aha borrado 
                    Marco(); // va al marco 
                    Console.SetCursorPosition(10, 10); // en la posicion 
                    Console.WriteLine("Tecla equivocada"); // muestra en pantalla 
                    Console.ReadKey(); // espera que el usuaruio haga algo 
                    Borrado();
                    Menu1();
                    break;
                }
        }
     //   return opcion;
    }

    private static void preguntafactorial()
    {
        Console.SetCursorPosition(10, 10); // en la posicon 
        Console.WriteLine("dame un numero y te dire el factorial de ese número "); // muestra 
        
        bool verdad;
        do
        {
            try
            {
                Console.SetCursorPosition(10, 12);
                Console.Write("Escribe un número: ");
                double numero;
                numero = Console.ReadLine();
                // intergere ya que con grandes numeros a factizar daba error de desbordamiento 
                Console.SetCursorPosition(10, 14);
                Console.WriteLine("El facotorial de " + numero + " es: " + factorial(numero));
                verdad = true;
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(10, 16);
                Console.Write("Valor introducido no valido");
                verdad = false;
            }

            Console.ReadKey();
        }
        while (!verdad == true)// en la posicion // pregunta el numero a factorizar// recoge le numero a factirzar, la variable esta en double y no en// recoge le resultado // espera que el usuario pulse caulquier tecla
;
    }

    private static void PromeMedio()
    {
        Console.SetCursorPosition(10, 9); // en la posicion 
        Console.WriteLine("Busqueda del promedio de 10 valores: "); // muetra por pantalla

        double suma; // definicion de juna variable
        int digitos; // define lavariable
        double valor; // define variable
        double promedio; // degine variable
        suma = 0; // variable asignaa con valor cero 
        for (digitos = 1; digitos <= 10; digitos++) // el for recore de un a 10
        {
            bool verdad; // variable control
            do
            {
                try // controla el valopr introduciodo
                {
                    Console.SetCursorPosition(10, 10 + digitos);
                    Console.Write("Dime el " + digitos + " : ");
                    valor = Console.ReadLine();
                    suma += valor;
                    verdad = true;
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(30, 10 + digitos);
                    Console.Write("el valor no es aceptado");
                    verdad = false;
                }
            }
            while (!verdad == true)// en la posicion // muestra que pide un valor // valor  si tofo sale correcto// valor no acptado
;
        } // va al siguiente número

        Console.SetCursorPosition(10, 23); // en la posicivsalon 
        Console.Write("La suma es: " + suma); // muestra 

        promedio = suma / 10; // la operacion del promedio
        Console.SetCursorPosition(10, 25); // en la posicion 
        Console.Write("El promedio es:" + promedio); // muestra el valor
        Console.ReadKey(); // espera que se de alguna tecla
    }

    private static void Generarnumerosetrediezycien() // generar números entre 10 y 100
    {
        Console.SetCursorPosition(10, 10); // en la posicion 

        Console.WriteLine("Generacion de numeros alatorios de 10 al 100");
        Random generator = new Random(); // rea una variable de tipo random
        int randomValue; // crea una vriablepara para recoger con el número 
        randomValue = generator.Next(10, 100); // recoge el valor generado por random entre 10 y 100
        Console.SetCursorPosition(20, 20); // en la posicion 
        Console.WriteLine("El numero generado es: " + randomValue); // muestra el resiltado 
        // en la posicion 
        Console.SetCursorPosition(28, 25);
        Console.WriteLine("pulse cualquier tecla para contiuar..."); // espera una tecla que espera fuera de este procdimento
    }

    private static void IntroduccionArrays()
    {
        int[] numeros = new int[6]; // variable de un arraut

        Borrado(); // va al borrado de pantalla
        Marco(); // va al marco
        Console.SetCursorPosition(10, 10); // marca la posicion del cursor en la pantalla
        Console.WriteLine("introducir un numero en la posiciones"); // muestra en pantalla
        int i; // definicion de la variable i
        for (i = 0; i <= (numeros.Length - 1); i++) // inicio del for hasta 
        {
            bool verdad; // variable de control

            do
            {
                try // Control de introduccion correta del valor
                {
                    Console.SetCursorPosition(10, 15);
                    Console.Write("inserte un numero en la posicion: " + i + " ");
                    numeros[i] = Console.ReadLine();
                    verdad = true;
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(10, 17);
                    Console.Write("El numero que quiere insertar en la posicion: " + i + " No es acetado");
                    verdad = false;
                }
            }
            while (!verdad == true)// pone en la posicion del cursor// muestra en la pantalla// recoge lo pedido en l òscion del array // si es introducodo bien el valor// pone en la posicion del cursor// muestra en la pantalla// Si ha introducodo mal el valor
;
        } // va la siguiente posicon del array
        Console.SetCursorPosition(3, 20); // pone el poscion 
        Console.Write("resultado: "); // muestra el rsultado
        for (i = 0; i <= (numeros.Length - 1); i++) // recorre la variable i

            Console.Write("nuemero: " + numeros[i] + " ");// muestra por separado losl dintintos valores puestos en el array // va al siguente numero dela variable

        Console.SetCursorPosition(28, 25); // muestra en la siguiente poscion 
        Console.WriteLine("pulse cualquier tecla para contiuar..."); // pulsemos cual quier tecla para continuar

        Console.ReadKey(); // espera que demos cualquier tecla
        Borrado(); // va al borrado de pantalla
    }

    private static void Areeadeuntrianguolo() // sub rutina de area un triangulo
    {
        Console.SetCursorPosition(10, 10); // Posicion del cursor
        Console.WriteLine("calculemos el area de un triangulo "); // muestra por pantalla

        bool verdad;
        do
        {
            double @base;
            double altura;
            try
            {
                Console.SetCursorPosition(10, 15);
                Console.Write("dime la base:");
                @base = Console.ReadLine();
                Console.SetCursorPosition(10, 17);
                Console.Write("dime la altura: ");
                altura = Console.ReadLine();
                double area;
                area = (@base * altura) / 2;
                Console.SetCursorPosition(10, 20);
                // muestra aqui abajo lo datos recogidos y el resuldado
                Console.WriteLine("El area del trinagulo con la base " + @base + " y la altura " + altura + " = " + area);
                Console.SetCursorPosition(10, 22);
                Console.Write("Pulse cualquier tecla para continuar,,,");
                verdad = true;
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(10, 24);
                Console.Write("Valores Introduciodos incorrectos");
                verdad = false;
            }

            Console.ReadKey();
        }
        while (!verdad == true)// definicion de una variabla// definicion de una variable// la posicion del cursor// pide la base// recoge el valor de la base// `psicion del cursot// muestra que pide la altura// recoge le valor de la actura// variable que recogera la formula // fornula del area de un triangulo// pone la posicion del cursor// en la posicion// Silos valores son correctos// muestrapor pantalla// que low valores no son correctos// si los valores no son correctos // espera a que l usuirario responda
;
    }

    private static void Holanombre() // el hola noombre
    {
        Console.SetCursorPosition(10, 10); // la posicion del cursor

        Console.Write("Dime tu nombre: ");  // preuntael nombre
        string nombre;
        nombre = Console.ReadLine(); // recole el nombre en la variable nombre
        Console.SetCursorPosition(10, 20);
        Console.WriteLine("hola, " + nombre); // saluda a la presona con su nombre

        Console.SetCursorPosition(28, 25); // la posicion del curor
        Console.WriteLine("pulse cualquier tecla para contiuar..."); // muesta en pantaalla 
        Console.ReadKey(); // espera ccion del usuarios
    }

    public static void Marco()
    {
        int l; // variable para las columnas
        int r; // variable para filas


        for (l = 1; l <= 90; l++)
        {
            Console.SetCursorPosition(l, 0); // posicion del  cuersor que se recorre de izquierda a derecha
            // por el for
            Console.Write("*"); // en esa posicion ponen el aterisco

            Temporizador(); // va a un temporazor ya que si no fueraasi no se veria el elfecto de izquierda a derecha
        }
        for (r = 1; r <= 28; r++)
        {
            Console.SetCursorPosition(90, r); // posicion del cursor posicionado por el for de arriba a abaho
            Console.Write("*"); // en la poscion anterir se one un asterico 

            Temporizador();
        }


        for (l = 90; l >= 1; l += -1)
        {
            Console.SetCursorPosition(l, 28); // La posicion del cursor dada por el for de deracha a izquierda
            Console.Write("*"); // muestra el asterisco en esa posicion
            Temporizador(); // va al temporizador
        }
        for (r = 28; r >= 0; r += -1)
        {
            Console.SetCursorPosition(0, r); // la posicion del cursor de abajo a arriba conrolADO POR EL FOR
            Console.Write("*"); // Muestra en la posicion
            Temporizador(); // va al un temporizador
        }
    }
    public static void Borrado()
    {
        for (var l = 0; l <= 40; l++)
        {
            Console.WriteLine(); // imprime el caracter vacio para dar el efecto de borrado de pantalla 
            Temporizador(); // ara el efecto se vea va añ temporizador
        }

        Console.Clear(); // voota realmente la pantalla
    }
    public static void Temporizador()
    {
        double temp; // variable para el Temporizador
        for (temp = 0; temp <= 100000000; temp++) // Cuenta desde 0 a 1000000000 para hacer tiempo
        {
        } // siguiente
    }
    public static void Menu2()
    {
        Marco(); // va la marco 

        Console.SetCursorPosition(20, 3); // pon el cursor en una posicion
        Console.WriteLine(" menu de programas 2"); // ' muestra en la cordenadas abnteriores la cabecera del menu

        Console.SetCursorPosition(10, 5); // nueva de posicion
        Console.WriteLine("0.- fin el programa"); // l

        Console.SetCursorPosition(10, 6); // pone en posicion de nuevo el corsor
        Console.WriteLine("1.- Dime los nomnbre de dos personas y sus edades y te dire cual es la mayor"); // si pulsar el uno y luego enter va saludarte

        Console.SetCursorPosition(10, 7); // vulve a cambiar la posicion 
        Console.WriteLine("2.- tabla de multiplicar"); // en la nuva posicion muestra

        Console.SetCursorPosition(10, 8); // nueva de posicion
        Console.WriteLine("3.- el precio con el iva "); // lo que se muestra al operador

        Console.SetCursorPosition(10, 9); // nueva posicio del cursor
        Console.WriteLine("4.- Numeros entre 0 y 100 no divisible entre 2"); // muestra en pantala

        Console.SetCursorPosition(10, 10); // nueva posicon del cursor
        Console.WriteLine("5.- Genera numero aleatoria, una por cada vez que entres"); // lo muestra por patalla

        Console.SetCursorPosition(10, 11); // nueva posicion del curosr
        Console.WriteLine("6.- Dibujo aleatorio"); // lo muestra por pantalla


        Console.SetCursorPosition(10, 12); // nueva posicion del curosr
        Console.WriteLine("7.- cifrar datos"); // lo muestra por pantalla


        Console.SetCursorPosition(10, 13); // nueva posicion del curosr
        Console.WriteLine("8.- Acerca de");  // lo muestra por pntalla


        Console.SetCursorPosition(10, 14); // nueva posicion del curosr
        Console.WriteLine("9.- Menu 1"); // vulve al menu 1
        bool verdad;
        do
        {
            try
            {
                Console.SetCursorPosition(10, 16);
                Console.Write("¿cual es tu opciòn? pulse enter despuès de apretar el número:");
                int opcion;
                opcion = Console.ReadLine();
                Eleccion1(opcion);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(10, 20);
                Console.Write("Opcion Incorrecta");
            }
        }
        while (!verdad == true)// nueva posicion del ccursor// preguna por numero// recoge el valor// aqui va a a la funcion elecion con la opcion selecionada
;


        Borrado(); // borara el marco 
        // Console.ReadKey() ' espera a que pulse una tecla

        Marco(); // crea de nuevo el cuadro
    }
    private static void Eleccion1(object opcion)
    {
        switch (opcion)
        {
            case 0 // opcion salir del programa
           :
                {
                    Borrado(); // borrado del menu
                    Marco(); // crar un marco
                    Console.SetCursorPosition(10, 10); // pone en su posicion 
                    Console.WriteLine("Gracias por haber participado en esta presentacion"); // muestra en pantalla
                    Borrado(); // borra la pantalla

                    System.Environment.Exit(0); // se termina la aplica
                    break;
                }

            case 1 // va a Cuañes el mayor
     :
                {
                    Borrado(); // va al borrado de pantalla
                    Marco(); // va la marco 
                    CualEsmayor(); // va a la opcion de cual es mayor

                    Borrado(); // va al borrado

                    Menu2(); // va la menu 2
                    break;
                }

            case 2 // va a la tabla de multiplicar
     :
                {
                    Borrado(); // borraqdo de pantalla
                    Marco(); // va al marco 
                    TabladeMultiplicar(); // va a latabla de multiplicar
                    Menu2();// val seundo menu
                    break;
                }

            case 3:
                {
                    Borrado(); // borra la pantalla
                    Marco(); // crea el marco 
                    ProductoconelivaAnadido(); // va producto con el iva añadido
                    Borrado(); // va al borrado

                    Menu2();// va al menu dos
                    break;
                }

            case 4:
                {
                    Borrado(); // va ha borrado

                    NodivisibleEntre2(); // metodo No divisible entre 2

                    Console.ReadKey(); // eno dicisibles enspera resuests del usuario

                    Borrado(); // va ha borado 
                    Menu2();// va almenu 2
                    break;
                }

            case 5:
                {
                    Borrado(); // va borrado de pantalla
                    Marco(); // va al marco 
                    Console.SetCursorPosition(10, 10); // en la posicion 
                    Console.WriteLine("genera numero aleatorio");  // muestraen pantalla
                    Generarnumerosaleatorios(); // genera numeros aletorios de 0 a 50

                    Console.ReadKey(); // espera respuesta del usuario
                    Borrado(); // va al borrado d pantalla
                    Menu2(); // va al menu 2
                    break;
                }

            case 6:
                {
                    Borrado(); // va al borrado
                    Marco(); // va al marco 
                    CrearDibujo(); // crea un dibujo 
                    Console.ReadKey(); // espera que demos alguna tecla 
                    Borrado(); // vaa borrado de pantalla 
                    Menu2(); // va al menu
                    break;
                }

            case 7:
                {
                    Borrado(); // va al borrado de marco 
                    Marco(); // va la creado de marco
                    Descifra(); // codigo descifra

                    Console.ReadKey(); // espera que haya una respuestoa por parte de usuario
                    Borrado(); // va a vorrado
                    Menu2();// va almenu 2
                    break;
                }

            case 8:
                {
                    Borrado(); // va a borrado
                    Marco(); // va al marco
                    AcercaDe(); // va a la informacion del programa que se esta utilizando
                    Borrado(); // va a borrado 
                    Menu2(); // vuelve al menu 2
                    break;
                }

            case 9 // ocion que va al segundo menu
     :
                {
                    Borrado(); // borra la pantalla

                    Menu1(); // va al primer me
                    break;
                }

            default:
                {
                    Borrado(); // borra la pantalla
                    Marco(); // va la marco 
                    Console.SetCursorPosition(10, 10); // pone el posicion el cursor
                    Console.WriteLine("Tecla equivocada"); // dice al usuario qye ha teclado mal 
                    Console.ReadKey(); // espera a que haga la accion el usuaroi 
                    Borrado(); // borra pantalla
                    Menu2(); // va al menu 2 de nuevo
                    break;
                }
        }
        return opcion;
    }

    private static void AcercaDe()
    {
        Console.SetCursorPosition(20, 5); // en la poosicion 
        Console.Write("Acerca de"); // muestra
        Console.SetCursorPosition(10, 7); // la posicon 
        Console.Write("Este programa ha sido creado por Jorge Ignacio de villota de villota"); // muesrtra el autor
        Console.SetCursorPosition(10, 9); // la posiiicion 
        Console.Write("con codigos de Gw-basic y visual Studio basic 2019"); // muestra inforacion
        Console.SetCursorPosition(10, 11); // en la posicion 
        Console.Write("de una antigua aplicacion de los años 80 y webs de programacion en español."); // muestra informacioin 
        Console.SetCursorPosition(10, 13); // el la posicion 
        Console.Write("Copyright Jorge Ignacio de Villota 2020"); // muestra 
        // Console.SetCursorPosition(10, 15) ' en la posicion 
        // Console.Write("Proyecto para Afanias") ' muestra

        Console.SetCursorPosition(10, 17); // en la posicion 
        Console.Write("Pulse cual tecla para continuar...."); // esoera resuta del usuarioi 
        Console.ReadKey(); // la espera
    }

    private static void NodivisibleEntre2()
    {
        Console.SetCursorPosition(10, 10); // en la posicion 
        Console.WriteLine(" te presento los numeros no divisible entre 2: "); // muestra 
        int i; // variables
        i = 0; // valor a cero

        while (i <= 100) // miestras i sea menor o igual 
        {
            Console.SetCursorPosition(10, 12 + i); // en la posicion

            if (i % 2 != 0)
                Console.Write("Numero no divisible entre 2: " + i);// muestra por pantalla  // fin del if



            i = i + 1; // suma uno a i
        } // fin del wihle
        Console.SetCursorPosition(10, 115); // en la posicion 
        Console.Write("pulse cualquier tecla para continuar"); // muestra 
        Console.ReadKey(); // espera que el usuario pulse cual quier tecla
    }


    private static void Descifra()
    {
        Console.SetCursorPosition(10, 10); // en la posicion
        Console.Write("el progrma de cifrar datos"); // muestra 
        Console.SetCursorPosition(10, 14); // en la posicion
        Console.Write("¡¡¡porfavor menos de 88 caracteres!!!"); // muestrauna advertencia

        Console.SetCursorPosition(10, 16); // en la posicon 
        Console.Write("Dime lo que quieres cifrar: "); // muestra 

        string nombre; // creo una variable string 
        nombre = Console.ReadLine(); // recoge en una variable de caracteres
        double nombrelen; // variable que recogera la cantidad de caracteres que hay nombre 

        double longitud; // variable que recorrera desde el valor nombrelen hasta 1 
        string nombreReves; // variable que recogera el string al rces de lo puesto en nombre
        nombrelen = Strings.Len(nombre); // recoge la cantida de caracteres que tiene nombre 
        for (longitud = nombrelen; longitud >= 1; longitud += -1) // recoge al reves hasta el final 
        {
            nombreReves = Strings.Mid(nombre, longitud, 1); // recoge el resultado, caracter a caracter al reves
            Console.SetCursorPosition(nombrelen - longitud + 10, 18); // en la posicion 

            Console.Write(nombreReves); // muestra cada caracter cada vez que pasa por el for 
        } // va al siguiente hasta el final

        Console.SetCursorPosition(12, 20); // LA POSICION 
        Console.Write("Presiona cualquier tecla para continuar...."); // Muestra
    }

    private static void CrearDibujo()
    {
        Random generator = new Random(); // Crea una variable de tipo aleatorio 
        int fila; // crea una variable para las filas
        int columna; // crea una variale para las columnos
        int caracter;
        int vez; // crea una variable para repeticiones
        for (vez = 0; vez <= 1000; vez++) // se inicia for 
        {
            fila = generator.Next(2, 88); // geberara un munoero entre 2 y 80 y lo recoge en la variable fila
            caracter = Conversion.Int(VBMath.Rnd() * 220 + 32);
            columna = generator.Next(2, 27); // genera un numero entre 2 y 24 y lo asigna a columna
            Console.SetCursorPosition(fila, columna);  // en la fila columnoa elefgida aleatoriamente 
            Console.WriteLine(Strings.Chr(caracter)); // muestra este caracter
        } // repite la operacion 
    }

    private static void ProductoconelivaAnadido()
    {
        const double IVA = 0.21; // Constante de IVA


        double ValorProducto; // variable que recoge el valor del producto 
        double ProductoconIva; // recoge la operacion del producto con el iva
        double IvadelProducto; // recoge el iva del producto 
        bool verdad;
        do
        {
            try
            {
                Console.SetCursorPosition(5, 10);
                Console.Write("Dime el precio del cual quiers saber el iva y el precio total; ");
                ValorProducto = Console.ReadLine();
                IvadelProducto = ValorProducto * IVA;
                ProductoconIva = ValorProducto + IvadelProducto;
                Console.SetCursorPosition(5, 12);
                // muestra el resultado 
                Console.Write("El producto con valor: " + ValorProducto + " y con un iva del " + IVA + " su iva es " + IvadelProducto + " el valor fanl es " + ProductoconIva);
                Console.SetCursorPosition(28, 25);
                Console.WriteLine("pulse cualquier tecla para contiuar...");
                verdad = true;
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(10, 20);
                Console.Write("Valor No reconocido");
                verdad = false;
            }

            Console.ReadKey();
        }
        while (!verdad == true)// en la posicion // muestra por pantalla // recoge el valor // la operacion que recoge el valor el iva del producto // hace la suma del valor del producto y con iva del producto // ebn la posicion // en la posicion // nuestra poer pantalla  // espera respuesta del usuario
;
    }

    private static void TabladeMultiplicar()
    {
        double numero; // numero por el que multipicar
        int i; // cvariabl del for
        bool verdad;
        do
        {
            try
            {
                Console.SetCursorPosition(5, 10);
                // muestra ls prenga de que numero quieres la multiplicacion
                Console.Write("Nunero por el que quieres tener la tabla de multiplicar los 10 prieros buneros: ");
                numero = Console.ReadLine();
                verdad = true;
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(5, 12);
                Console.Write("Valor no aceptado");
                verdad = false;
            }
        }
        while (!verdad == true)// la posicion del ccuror// lo recoge en la variable número
;


        for (i = 1; i <= 10; i++) // recorre de 1 a 10 el for
        {
            Console.SetCursorPosition(10, 12 + i); // En la posiomm original más i 
            Console.WriteLine(i + " x " + numero + " = " + i * numero); // muestra los valores
        } // va la siguiente
        Console.ReadKey(); // espera que demos una tecla para avsnzar
        Borrado(); // va a borrado 
    }

    private static void CualEsmayor() // opcion cual es el mayor
    {
        string nombre1; // definicion primera variable que soprta texto
        int edad1; // primera variable que soporta la edad
        string nombre2; // segunda variable que soporta el sehundo nombre
        int edad2; // segunda cvariable que sopota la edad
        int ruta = 0; // variable que controla el paso por los dintintos if


        Console.SetCursorPosition(10, 10); // el apolscion del cursor


        Console.Write("Dime un nombre: "); // preunta el nombre

        nombre1 = Console.ReadLine(); // recole el nombre en la variable nombre
        if (Information.IsNumeric(nombre1))
        {
            Console.SetCursorPosition(10, 12); // en la posicion 
            Console.Write("No es un nombre "); // dice que no es un nobre
            Console.ReadKey(); // espera que a que se teclea algo
        }
        else
        {
            ruta += 1; // suma 1 a ruta que un control por donde va


            Console.SetCursorPosition(10, 12); // en la posicion 

            Console.Write("dime la edad de: " + nombre1 + " "); // muestra que quiere la edad del valor nombre
            edad1 = Console.ReadLine(); // recogge el valor de la primera edad

            if (Information.IsNumeric(edad1))
            {
                ruta += 1; // si es asi suma a ruta un al contaor
                Console.SetCursorPosition(10, 14); // en la siguiente posicion 
                Console.Write("dime otro nombre: "); // muestra que quiere el segundo nombre
                nombre2 = Console.ReadLine(); // recoge el nombre de la segunda persona
                if (Information.IsNumeric(nombre2))
                {
                    Console.SetCursorPosition(10, 16); // en la posicion  
                    Console.Write("No me has dado lo que te he pedido"); // muestra su desconformidad
                }
                else
                {
                    ruta += 1; // suma 1 al control ruta

                    Console.SetCursorPosition(10, 16); // en la posicion 
                    Console.Write("Dime la edad de: " + nombre2 + " "); // muestra que quiere la edad del segundo

                    edad2 = Console.ReadLine(); // recoge el valor 
                    if (Information.IsNumeric(edad2))
                        ruta += 1; // muma 1 a la ruta
                    else
                    {
                        Console.SetCursorPosition(10, 16); // en la posicion de pantala
                        Console.Write("te he pedido una edad"); // muestra el mensaje
                        Console.ReadKey(); // espera a qe se teclea algo
                    }
                }
            }
        }
        if (ruta == 4)
        {
            if (edad1 == edad2)
            {
                Console.SetCursorPosition(10, 18); // pone en la posicion 
                // muestra en pantalla que son iguales
                Console.Write("tanto " + nombre1 + " como " + nombre2 + " tienen la misma edad");
            }
            else if (edad1 > edad2)
            {
                Console.SetCursorPosition(10, 18); // en la popsicion 
                                                   // muestra que el señor con edad 1 es mayor que dos
                Console.Write("El señor/a con nombre: " + nombre1 + " tinene más edad que el señor/a: " + nombre2);
            }
            else
            {
                Console.SetCursorPosition(10, 18); // en la posicon 
                                                   // muestra que el s´ñor con nombbre 2 es mayor que nombre 1
                Console.Write("El señor/a con nombre: " + nombre2 + " tinene más edad que el señor/a: " + nombre1);
            }
        }
        else
        {
            // si no ha por pasado por todas las preguntas
            Console.SetCursorPosition(10, 18); // en la posicon
            // muestra que no pasado en algunos de los paasos y basta para que en uno no pase para que
            // llegue a este punto
            Console.Write("no me has dato o nombre valido o edad");
        }


        Console.SetCursorPosition(20, 20); // muestra en esa posicion
        // espera a que el usuario de alguna tecla
        Console.WriteLine("pulse cualquier tecla para contiuar...");
        Console.ReadKey(); // espera que se de alguna tecla
    }

    private static void Generarnumerosaleatorios() // private sub para generar numeros
    {
        Console.SetCursorPosition(10, 10); // en la posicin 

        Console.WriteLine("Generacion de numeros alatorios de 10 al 100"); // muestraen pantalla
        Random generator = new Random(); // crear una variable de tipo random
        int randomValue; // variable que recogerá le valor 
        randomValue = generator.Next(0, 50); // genera un numero entre 0 y 50 y lo reecoge en la variablr
        Console.SetCursorPosition(20, 20); // en la posicion 
        Console.WriteLine("El numero generado es: " + randomValue); // muestra el valor del geberador de numeros aleatorio

        Console.SetCursorPosition(28, 25); // en la posicion 
        Console.WriteLine("pulse cualquier tecla para contiuar..."); // muestra en pantalla
    }

    public static void Banco() // sub del banco
    {
        Borrado(); // ca a borrado de pantalla
        Marco(); // va al maroco

        Console.SetCursorPosition(10, 10); // en la posicion 
        Console.WriteLine("bienvenido al Banco de cmmbio de monedas de jorge "); // da la bien venida al banco
        Menubanco(); // va al menu del banco
        Console.ReadKey(); // espera accion por el usuario
    }

    public static void Menubanco() // menu del banco
    {
        double euro; // variable del euro
        const double Eeuu = 0.1; // constante de la moneda de estados unidos de america
        const double Yen = 0.102; // constante dde la mone Yen
        const double Rub = 0.111; // moneda rublo

        double camb; // variable que recibe el resultado
        int opcion; // variable de opcion 

        Console.SetCursorPosition(10, 13); // en la posicion 
        Console.Write("¿Cuantos euros quieres cambiar? "); // pregunta cuanto euros quiere cambiar
        euro = Console.ReadLine(); // recioge le valor  de los euros
        Console.SetCursorPosition(10, 15); // en la posicion
        Console.WriteLine("1.- a dolar Estudinense"); // Si quieres El dolar amricano
        Console.SetCursorPosition(10, 17); // en la posicion 
        Console.WriteLine("2.- a Yen"); // si quieries Yen
        Console.SetCursorPosition(10, 19); // en la posicion 
        Console.WriteLine("3.- a rublos"); // si lo quires cambiar a rubos 
        Console.SetCursorPosition(10, 23); // en la posicion 
        Console.Write("¿que opcion quiere? pulse la opcion y luego enter: "); // pide que le des una opccion 
        opcion = Console.ReadLine(); // recoge el valor en ocion 
        switch (opcion) // en caso de opcion 
        {
            case 1 // el valor 1 es dolar estudianedes 
           :
                {
                    camb = euro / Eeuu; // recoge el valor recogido es los euros entre dolar estaudineses

                    Console.SetCursorPosition(10, 25); // en la posicion 
                    Eruroaeeuu(euro, Eeuu, camb); // va una funcion o sub que muestra el resultado
                    break;
                }

            case 2 // en la opcion 2 euros entre yen
     :
                {
                    camb = euro / Yen;

                    Console.SetCursorPosition(5, 25); // en laposicion 
                    Euroyen(euro, Yen, camb); // va a la funcion euro yen que muestra el resultado
                    break;
                }

            case 3 // en la opccion 3
     :
                {
                    camb = euro / Rub; // se hace la operacion 
                    EuroRub(euro, Rub, camb); // va al funcion que muestra el resultado
                    break;
                }

            default:
                {
                    Console.SetCursorPosition(10, 25); // en la posicion 
                    Console.Write(" Esa Moneda no la tenemos"); // muestraen pantalla
                    break;
                }
        }
        Console.SetCursorPosition(10, 26);
        Console.Write("pulsa cualquier tecla para continuar...");
    }

    private static void EuroRub(double euro, double rub, double camb)
    {
        Console.SetCursorPosition(10, 25); // en la posicion 
        // muestra el resultado 
        Console.Write("El cambio de euros: " + euro + " a rublos: " + rub + " es: " + camb);
    }

    private static void Eruroaeeuu(double euro, double Eeuu, double camb)
    {
        // muestra el valor del cambio euro y el estudindene
        Console.WriteLine(value: " el cambio de euros: " + euro + " ha la moneda estaunidense cuyo cambio es " + Eeuu + "  es: " + camb);
    }
    private static void Euroyen(double euro, double yen, double camb)
    {

        // muestra el resultado del cambio  euro yen
        Console.WriteLine(" el cambio de euros: " + euro + " ha la  moneda Yen cuyo cambio es: " + yen + " es: " + camb);
    }

    public static void Tipostringulos()
    {
        // se busca los nombres de los triangulos
        Console.SetCursorPosition(10, 13);
        // se selecciona saber los nombres de los trianngulos por sus angulos
        Console.Write("1.- por angulos");
        Console.SetCursorPosition(10, 15);
        // se busca los nombres por las dimensiones de sus lados 
        Console.Write("2.- por tamaño de los lados ");
        // pide que se elegia un numero del menu
        Console.SetCursorPosition(10, 17);
        Console.Write("que opcion elige: ");
        int opcion;
        // la variable opcion te lleva a una des las dos opciones
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case 1 // es la opcion por de los angulos
           :
                {
                    Borrado(); // borrala pantalla
                    Marco(); // va al marco
                    Console.SetCursorPosition(5, 4); // en la posicion 
                                                     // pone como aclaracion como escribirr los grados
                    Console.Write("al escribir los angulos utilizar XXX,XX para poner los medios grados donde");
                    Console.SetCursorPosition(5, 5);

                    Console.Write("las X es para los números y ',' para los medios grados");
                    Console.SetCursorPosition(10, 10); // Posicion del cursor en la pantalla
                    Console.Write("Dime el primer angulo: "); // muestra que quiere el primer angulo
                    double angulo1; // variable que recoge el primer angulo
                    angulo1 = Console.ReadLine(); // ' recogiada del primer abgulo


                    Console.SetCursorPosition(10, 12); // poscion del cursor en la pantalla
                    Console.Write("Dime el segundo angulo: "); // muestra por pantala

                    double angulo2; // ddvine la vaeiable
                    angulo2 = Console.ReadLine(); // recoge el valor
                    Console.SetCursorPosition(10, 14); // en la posicion de la pantalla
                    Console.Write("dime el terner angulo: "); // muestra en pantalla
                    double angulo3; // define la variable 
                    angulo3 = Console.ReadLine(); // recoge el valor de la variable 

                    // Compruba si la suma de los angulos es superior a 179
                    if (angulo1 + angulo2 + angulo3 > 180)
                    {

                        // muestra e pantalla 
                        Console.SetCursorPosition(10, 16);
                        // lo muetra 
                        Console.WriteLine("Esto no es un triangulo, si no una semi circunferencia");
                        Console.ReadLine(); // espera que haya una resp,uesta por parte del ussuario
                    }
                    else

                               // compruaba si los angulos son iguales
                               if (angulo1 == 60 & angulo2 == 60 & angulo3 == 60)
                    {
                        // muestra en la posicion 
                        Console.SetCursorPosition(10, 16);
                        Console.WriteLine("Es un triangulo equilatero");
                        Console.ReadLine(); // espera un Enter por parte del usuario
                    }
                    else
                                   // mira si alguno de los angulos es de 90 grados 
                                   if (angulo1 == 90 | angulo2 == 90 | angulo3 == 90)
                    {
                        Console.SetCursorPosition(10, 16); // en la posicion
                                                           // muestra por pantalla 
                        Console.WriteLine("Es un triangulo rectangulo");
                        Console.ReadLine(); // espera un enter por parte del usuario
                    }
                    else
                    {
                        // en la posicion 
                        Console.SetCursorPosition(10, 16);
                        // muestra en pantalla 
                        Console.WriteLine("Es un triangulo escaleno");
                        Console.ReadLine(); // espera un enter or parte del usuario
                    }

                    break;
                }

            case 2 // CASO 2
     :
                {
                    Borrado(); // Va a borrado
                    Marco(); // va la marco
                    Console.SetCursorPosition(5, 4); // la posicion 
                                                     // muestra en pantalla
                    Console.Write("Para las distacias con decimales utilizar XXX,X donde la X es el múmero y la ','");
                    Console.SetCursorPosition(5, 5);

                    Console.Write("es para separar la parte decimal");

                    Console.SetCursorPosition(10, 10); // en la osicion
                    Console.Write("Dime el valor del primer lado: "); // pide la longitud del proimer lado
                    double lado1; // crea la variablre
                    lado1 = Console.ReadLine(); // recoge el valor
                    Console.SetCursorPosition(10, 12); // pone el cursor en la poscion
                    double lado2; // define la valriable
                    Console.Write("Dime el valor del segundo lado: "); // muestra que pide otra longitud
                    lado2 = Console.ReadLine(); // recoge el valor 
                    double lado3; // define la variable
                    Console.SetCursorPosition(10, 14); // pone el cursor ebn
                    Console.Write("Dime el valor del tercer lado: "); // muestra en pantalla
                    lado3 = Console.ReadLine(); // recoge el valor 

                    if (lado1 == lado2 & lado2 == lado3)
                    {
                        Console.SetCursorPosition(10, 16); // en la posicion 
                        Console.Write("Es un triangulo equilatero"); // muestra en pantalla
                        Console.ReadLine(); // espera que demos un retorno de carro o enter
                    }
                    else if (lado1 == lado2 & lado2 != lado3)
                    {
                        // son iguales y el tercero distinto al segundo
                        Console.SetCursorPosition(10, 16); // muestra en posicion 
                        Console.Write("Es un triangulo isoceles"); // pone por pantalla
                        Console.ReadLine(); // espera que le demos un retorno de carro
                    }
                    else if (lado1 != lado3 & lado2 == lado3)
                    {
                        // y lado dos y tres son iguales y muesra en las cordenadas que son
                        Console.SetCursorPosition(10, 16);
                        Console.Write("es u triangulo isoceles");
                        Console.ReadLine(); // espera que haga,os un retorno de carro
                    }
                    else
                    {
                        Console.SetCursorPosition(10, 20); // muestra en pantalla 
                        Console.Write("Es un triangulo escaleno "); // es un triangilo escaleno
                        Console.ReadLine();
                    }

                    break;
                }

            default:
                {
                    Console.SetCursorPosition(10, 20); // la posicion
                    Console.Write("opcion equivocada"); // muestra
                    Console.ReadKey(); // espera que 
                    break;
                }
        }
    }
    public static double factorial(double numero) // la funcion factrioal
    {
        // creo la variable producto y la variable para hacre la operacion de factirzacion
        var producto = numero; // declara y asigna el valor de la varibla enrdada
        double i;
        for (i = numero; i >= 1; i += -1) // cuenta atras con el for
            producto *= i;// hace la oeracion // si no ha llegado a cero vuelve al for
        return producto; // devuelve el resultado
    }
}

namespace ProyectoPropiodeVisualBasicACSharpJorge
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
