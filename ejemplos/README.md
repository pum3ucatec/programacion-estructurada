# Introducción a CLI y Shell

## ¿Qué es CLI?
**CLI (Command Line Interface)** es una interfaz de usuario basada en texto que permite a los usuarios interactuar con el sistema operativo o aplicaciones mediante comandos escritos. A diferencia de las interfaces gráficas (GUI), la CLI requiere que el usuario introduzca comandos manualmente.

## ¿Qué es Shell?
**Shell** es un programa que actúa como intérprete entre el usuario y el sistema operativo. Procesa los comandos ingresados por el usuario y los ejecuta en el sistema. Existen diferentes tipos de shells como Bash (Bourne Again Shell), Zsh, PowerShell, etc.

# Comandos ordenados por uso frecuente

## Comandos básicos de navegación

### `pwd`
**Explicación**: Muestra la ruta del directorio actual (Print Working Directory).

**Sintaxis**:
```bash
pwd
```

**Ejemplo**:
```bash
$ pwd
/home/usuario/proyectos
```

### `ls -la`
**Explicación**: Lista todos los archivos y directorios (incluyendo ocultos) con detalles.

**Sintaxis**:
```bash
ls -la [directorio]
```

**Ejemplo**:
```bash
$ ls -la
total 24
drwxr-xr-x 4 usuario usuario 4096 May 10 15:30 .
drwxr-xr-x 5 usuario usuario 4096 May  5 09:15 ..
-rw-r--r-- 1 usuario usuario  220 May  5 09:15 .bash_logout
```

### `cd`
**Explicación**: Cambia el directorio actual (Change Directory).

**Sintaxis**:
```bash
cd [ruta]
```

**Ejemplo**:
```bash
$ cd proyectos
```

### `cd ..`
**Explicación**: Retrocede un nivel en la estructura de directorios.

**Sintaxis**:
```bash
cd ..
```

**Ejemplo**:
```bash
$ cd ..
```

### `mkdir`
**Explicación**: Crea un nuevo directorio (Make Directory).

**Sintaxis**:
```bash
mkdir [nombre_directorio]
```

**Ejemplo**:
```bash
$ mkdir nuevo_proyecto
```

## Comandos de manipulación de archivos

### `rm -rf`
**Explicación**: Elimina archivos o directorios de forma recursiva y forzada (Remove).

**Sintaxis**:
```bash
rm -rf [nombre_archivo_o_directorio]
```

**Ejemplo**:
```bash
$ rm -rf directorio_obsoleto
```

## Comandos de Git

### `git clone`
**Explicación**: Clona un repositorio remoto a tu máquina local.

**Sintaxis**:
```bash
git clone [url_repositorio]
```

**Ejemplo**:
```bash
$ git clone https://github.com/usuario/repositorio.git
```

### `git pull`
**Explicación**: Obtiene los últimos cambios del repositorio remoto y los fusiona con la rama local.

**Sintaxis**:
```bash
git pull [remoto] [rama]
```

**Ejemplo**:
```bash
$ git pull origin main
```

### `git push`
**Explicación**: Envía los commits locales al repositorio remoto.

**Sintaxis**:
```bash
git push [remoto] [rama]
```

**Ejemplo**:
```bash
$ git push origin feature-branch
```

### `git fetch`
**Explicación**: Descarga objetos y referencias del repositorio remoto sin fusionarlos.

**Sintaxis**:
```bash
git fetch [remoto]
```

**Ejemplo**:
```bash
$ git fetch origin
```

### `git remote -v`
**Explicación**: Muestra los repositorios remotos configurados con sus URLs.

**Sintaxis**:
```bash
git remote -v
```

**Ejemplo**:
```bash
$ git remote -v
origin  https://github.com/usuario/repositorio.git (fetch)
origin  https://github.com/usuario/repositorio.git (push)
```

### `git --version`
**Explicación**: Muestra la versión instalada de Git.

**Sintaxis**:
```bash
git --version
```

**Ejemplo**:
```bash
$ git --version
git version 2.34.1
```

### `git config --list`
**Explicación**: Muestra la configuración actual de Git.

**Sintaxis**:
```bash
git config --list
```

**Ejemplo**:
```bash
$ git config --list
user.name=Tu Nombre
user.email=tu@email.com
```

## Comandos de .NET

### `dotnet --version`
**Explicación**: Muestra la versión instalada del SDK de .NET.

**Sintaxis**:
```bash
dotnet --version
```

**Ejemplo**:
```bash
$ dotnet --version
6.0.202
```

### `dotnet build`
**Explicación**: Compila un proyecto .NET y sus dependencias.

**Sintaxis**:
```bash
dotnet build [proyecto]
```

**Ejemplo**:
```bash
$ dotnet build MiProyecto.sln
```

### `dotnet run`
**Explicación**: Compila y ejecuta inmediatamente una aplicación .NET.

**Sintaxis**:
```bash
dotnet run [--project proyecto]
```

**Ejemplo**:
```bash
$ dotnet run --project MiProyecto
```
### `dotnet new console`
**Exlicacion**: Crea un nuevo proyecto (hacerlo dentro de la carpeta ejemplos)

**Sintaxis**
```bash
$ dotnet new console -o e3-aprobado-o-reprobado
```
# Conceptos básicos de programación

## Definición de variable
Una variable es un espacio de memoria reservado para almacenar un valor que puede cambiar durante la ejecución del programa.

**Ejemplo en Bash**:
```bash
nombre="Juan"
edad=25
```

## Constante
Una constante es similar a una variable, pero su valor no puede cambiar después de su definición.

**Ejemplo en Bash**:
```bash
readonly PI=3.1416
```

## Asignación
La asignación es el proceso de almacenar un valor en una variable.

**Ejemplo en Bash**:
```bash
saludo="Hola Mundo"
```

## if...then
Estructura condicional que ejecuta un bloque de código si se cumple una condición.

**Sintaxis en Bash**:
```bash
if [ condición ] then
    # comandos
fi
```

**Ejemplo**:
```bash
if [ "$edad" -gt 18 ] then
    echo "Eres mayor de edad"
fi
```

## switch (case)
Estructura que permite ejecutar diferentes bloques de código basados en el valor de una variable.

**Sintaxis en Bash**:
```bash
case $variable in
    patrón1)
        # comandos
        ;;
    patrón2)
        # comandos
        ;;
    *)
        # comandos por defecto
        ;;
esac
```

**Ejemplo**:
```bash
case $opcion in
    "start")
        echo "Iniciando servicio..."
        ;;
    "stop")
        echo "Deteniendo servicio..."
        ;;
    *)
        echo "Opción no válida"
        ;;
esac
```